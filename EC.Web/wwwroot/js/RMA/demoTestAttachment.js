//show Modal
function addNewOrder() {
    $('#newOrderModal').modal();
}
// Add multiple order
$('#addToList').click(function (e) {
    e.preventDefault();

    if ($.trim($('#itemNo').val()) === "" || $.trim($('#partNo').val()) === "" || $.trim($('#unitPrice').val()) === "" || $.trim($('#quantity').val()) === "") return;

    var itemNo = $('#itemNo').val(),
        partNo = $('#partNo').val(),
        unitPrice = $('#unitPrice').val(),
        quantity = $('#quantity').val(),
        amount = parseInt(unitPrice) * parseInt(quantity),
        detailsTableBody = $('#detailsTable tbody');

    var orderItem = '<tr><td>' + itemNo + '</td><td>' + partNo + '</td><td>' + unitPrice + '</td><td>' + quantity + '</td><td>' + '</td><td>' + amount + '</td><td><a data-itemId="0" href="#" class="deleteItem">Remove</a></td></tr>';
    detailsTableBody.append(orderItem);
    clearItem();
});
// After add a new order detail in the list, clear clean the form and add more order detail
function clearItem() {
    $('#itemNo').val('');
    $('#partNo').val('');
    $('#unitPrice').val('');
    $('#quantity').val('');
}
// after add a new order detail in the list, if you want, you can remove it.
$(document).on('click', 'a.deleteItem', function (e) {
    e.preventDefault();
    var $self = $(this);
    if ($(this).attr('data-itemId') === "0") {
        $(this).parents('tr').css('background-color', '#ff6347').fadeOut(800, function () {
            $(this).remove();
        });
    }
});
//after click save button pass all data view to backend for saving to database
function saveOrder(data) {
    return $.ajax({
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        type: 'POST',
        url: '/RMA/Demo/DemoTestAttachment?handler=SaveOrder',
        data: data,
        //headers: {
        //    RequestVerificationToken:
        //        $('input:hidden[name="__RequestVerificationToken"]').val()
        //},
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        success: function (result) {
            alert(result);
            location.reload();
        },
        error: function () {
            alert('Error!');
        }
    });
}
//collect multiple order detail for pass to backend
$('#saveOrder').click(function (e) {
    e.preventDefault();

    var orderArray = [];
    orderArray.length = 0;

    $.each($('#detailsTable tbody tr'), function () {
        orderArray.push({
            itemNo: $(this).find('td:eq(0)').html(),
            partNo: $(this).find('td:eq(1)').html(),
            unitPrice: $(this).find('td:eq(2)').html(),
            quantity: $(this).find('td:eq(3)').html(),
        });
    });

    var attachmentArray = [];
    attachmentArray.length = 0;

    $.each($('#attachmentsTable tbody tr'), function () {
        attachmentArray.push({
            id: $(this).find('td:eq(0)').html(),
            fileName: $(this).find('td:eq(1)').html(),
            size: $(this).find('td:eq(2)').html()          
        });
    });

    var data = JSON.stringify({
        customer: $('#customer').val(),
        details: orderArray,
        attachments: attachmentArray
    });

    $.when(saveOrder(data)).then(function (response) {
        console.log(response);
    }).fail(function (err) {
        console.log(err);
    });
});

// Attachment Process
//var formData = new FormData();
//var index = 0;
function onDrop(event) {
    //var pfiles = $('#fUpload').prop("files");
    var pfiles = $('#fUpload').prop("Files");
    var fdata = new FormData();
    var dt = event.dataTransfer;
    var files = dt.files;

    for (var i = 0; i < files.length; i++) {
        fdata.append("files", files[i]);
    }

    console.log(files);

    $.ajax({
        type: "POST",
        url: "/RMA/Demo/DemoTestAttachment?handler=UploadFilesAjax",
        processData: false,
        contentType: false,
        //cache: false,
        //enctype: 'multipart/form-data',
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: fdata,
        success: function (response) {
            var attachmentsTableBody = $('#attachmentsTable tbody');
            $.each(response, function (i, item) {
                //var $tr = $('<li>').append(item).appendTo(dvItems);
                var attachmentItem = '<tr><td>' + item.id + '</td><td>' + item.fileName + '</td><td>' + item.size + '</td><td><a data-attachmentId="0" href="#" class="deleteAttachmentItem">Remove</a></td></tr>';
                attachmentsTableBody.append(attachmentItem);
                clearItem();
            });
        },
        failure: function (response) {
            alert(response);
        }
    });
}
// after add a new order detail in the list, if you want, you can remove it.
$(document).on('click', 'a.deleteAttachmentItem', function (e) {
    e.preventDefault();
    var $self = $(this);
    if ($(this).attr('data-attachmentId') === "0") {
        $(this).parents('tr').css('background-color', '#ff6347').fadeOut(800, function () {
            $(this).remove();
        });
    }
});