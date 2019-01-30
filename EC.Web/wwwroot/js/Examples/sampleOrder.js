//show Modal
function addNewOrder() {
    $('#newOrderModal').modal();
}
// Add multiple order
$('#addToList').click(function (e) {
    e.preventDefault();

    if ($.trim($('#productId').val()) === "" || $.trim($('#itemNo').val()) === "" || $.trim($('#partNo').val()) === "" || $.trim($('#productDescription').val()) === "" || $.trim($('#unitPrice').val()) === "" || $.trim($('#quantity').val()) === "") return;

    var productId = $('#productId').val(),
        itemNo = $('#itemNo').val(),
        partNo = $('#partNo').val(),
        productDescription = $('#productDescription').val(),
        unitPrice = $('#unitPrice').val(),
        quantity = $('#quantity').val(),
        amount = parseInt(unitPrice) * parseInt(quantity),
        detailsTableBody = $('#detailsTable tbody');

    var orderItem = '<tr><td>' + itemNo +
        '</td><td>' + productId +
        '</td><td>' + partNo +
        '</td><td>' + productDescription +
        '</td><td>' + unitPrice +
        '</td><td>' + quantity +
        '</td><td>' +
        '</td><td>' + amount +
        '</td><td><a data-itemId="0" href="#" class="deleteItem">Remove</a> | <a data-itemId="0" href="#" class="editItem">Edit</a></td></tr>';
    detailsTableBody.append(orderItem);
    clearItem();
});
// After add a new order detail in the list, clear clean the form and add more order detail
function clearItem() {
    $('#productId').val('');
    $('#itemNo').val('');
    $('#partNo').val('');
    $('#productDescription').val('');
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
$(document).on('click', 'a.editItem', function (e) {
    e.preventDefault();
    var $self = $(this);
    if ($(this).attr('data-itemId') === "0") {
        $(this).parents('tr').css('background-color', '#ff6347').fadeOut(800, function () {
            $('#productId').val($(this).find('td:eq(1)').html());
            $('#itemNo').val($(this).find('td:eq(0)').html());
            $('#partNo').val($(this).find('td:eq(2)').html());
            $('#productDescription').val($(this).find('td:eq(3)').html());
            $('#unitPrice').val($(this).find('td:eq(4)').html());
            $('#quantity').val($(this).find('td:eq(5)').html());
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
        url: '/Examples/SampleOrder?handler=SaveOrder',
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
            productId: $(this).find('td:eq(1)').html(),
            //partNo: $(this).find('td:eq(2)').html(),
            //productDescription: $(this).find('td:eq(3)').html(),
            unitPrice: $(this).find('td:eq(4)').html(),
            quantity: $(this).find('td:eq(5)').html(),
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
        customerId: $('#customerId').val(),
        customerName: $('#customerName').val(),
        items: orderArray,
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
        url: "/Examples/SampleOrder?handler=UploadFilesAjax",
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

//autocomplete
var modalDialog = $('#modalDialog');

$('#partNo').autocomplete({
    source: function (request, response) {
        $.ajax({
            url: "/api/examples/Products/GetProducts",
            type: "GET",
            dataType: "json",
            data: { Prefix: $('#partNo').val() },
            success: function (data) {
                response($.map(data, function (item) {
                    console.log(item);                                       
                    //return { label: item.partNo, value: item.partNo };
                    return { label: item.partNo, value: item.partNo, productId: item.id, productDescription: item.productDescription, unitPrice: item.unitPrice };
                    //return { id: item.id, partNo: item.partNo, productDescription: item.productDescription, unitPrice: item.unitPrice, label: item.partNo, value: item.partNo };
                }));
            },
            error: function (xhr, status, error) {
                alert("Error");
            }
        });
    },
    select: function (evt, ui) {
        $('#productId').val(ui.item.productId);
        $('#productDescription').val(ui.item.productDescription);
        $('#unitPrice').val(ui.item.unitPrice);
        return false;
    },
    minLength: 5,
    appendTo: modalDialog,
    message: {
        noResults: "", results: ""
    }
});

$('#customerName').autocomplete({
    source: function (request, response) {
        $.ajax({
            url: "/api/examples/Customers/GetCustomers",
            type: "GET",
            dataType: "json",
            data: { Prefix: $('#customerName').val() },
            success: function (data) {
                response($.map(data, function (item) {
                    console.log(item);
                    return { label: item.customerName, value: item.customerName };
                    //return { id: item.id, label: item.customerName, value: item.customerName, customerId: item.id, customerName: item.customerName };
                }));
            }
        });
    },
    select: function (evt, ui) {
        $('#customerId').val(ui.item.id);
        return false;
    },
    minLength: 3,
    appendTo: modalDialog,
    message: {
        noResults: "", results: ""
    }
});