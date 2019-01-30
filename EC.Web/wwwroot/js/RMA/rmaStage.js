// Add multiple stages
$('#addToList').click(function (e) {
    e.preventDefault();

    if ($.trim($('#note').val()) === "" &&
        $.trim($('#rmaCorrectiveAction').val()) === "" &&
        $.trim($('#id').val() === "")) return;

    var note = $('#note').val(),
        rmaCorrectiveAction = $('#rmaCorrectiveAction').val(),        
        serialNumbers = $('#serialNumbers').val(),
        isActionDone = $('#isActionDone').is(':checked'),        
        correctiveActionNote = $('#correctiveActionNote').val(),
        id = $('#id').val(),
        detailsTableBody = $('#detailsTable tbody');

    var tdIsDoneChecked = '<label class="switch switch-pill switch-text switch-primary">'
        + '<input type="checkbox" class="switch-input" checked="checked">'
        + '<span class="switch-label" data-on="On" data-off="Off"></span>'
        + '<span class="switch-handle"></span>'
        + '</label>';

    var tdIsDoneNotChecked = '<label class="switch switch-pill switch-text switch-primary">'
        + '<input type="checkbox" class="switch-input">'
        + '<span class="switch-label" data-on="On" data-off="Off"></span>'
        + '<span class="switch-handle"></span>'
        + '</label>';

    var tdIsDone = '';
    if (isActionDone)
        tdIsDone = tdIsDoneChecked;
    else
        tdIsDone = tdIsDoneNotChecked;

    var caseItem = '<tr><td>' + rmaCorrectiveAction +
        '</td><td>' + note +
        '</td><td>' + serialNumbers +
        '</td><td>' +
        '</td><td>' +
        '</td><td>' + tdIsDone +
        '</td><td>' + correctiveActionNote +
        '</td><td hidden>' + id +
        '</td><td><a data-itemId="0" href="#" class="deleteItem">Remove</a></td></tr>';
    detailsTableBody.append(caseItem);
    clearItem();
});
// After add a new order detail in the list, clear clean the form and add more order detail
function clearItem() {
    $('#id').val('');
    $('#note').val('');
    $('#serialNumbers').val('');
    $('#rmaCorrectiveAction').val('');
    $('#isActionDone').val('');
    $('#correctiveActionNote').val('');
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
function saveStages(data) {
    return $.ajax({
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        type: 'POST',
        url: '/RMA/RMARequests/RMAStages?handler=SaveStages',
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
        error: function (error) {
            alert('Error!');
        }
    });
}
//collect multiple stage detail for pass to backend
$('#saveStages').click(function (e) {
    e.preventDefault();

    var stagesArray = [];
    stagesArray.length = 0;

    $.each($('#detailsTable tbody tr'), function () {
        stagesArray.push({
            correctiveAction: $(this).find('td:eq(0)').html(),
            note: $(this).find('td:eq(1)').html(),
            rMACaseId: $('#RMACaseId').val(),
            serialNumbers: $(this).find('td:eq(2)').html(),
            isActionDone: $(this).find('td:eq(5)').find('input[type=checkbox]').is(":checked"),
            correctiveActionNote: $(this).find('td:eq(6)').html(),
            id: $(this).find('td:eq(7)').html()
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
        id: $('#RMACaseId').val(),
        rMAStages: stagesArray,
        attachments: attachmentArray
    });

    $.when(saveStages(data)).then(function (response) {
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
                    return { label: item.partNo, value: item.partNo };
                    //return { id: item.id, partNo: item.partNo, productDescription: item.productDescription, unitPrice: item.unitPrice, label: item.partNo, value: item.partNo };
                }));
            },
            error: function (xhr, status, error) {
                alert("Error");
            }
        });
    },
    select: function (evt, ui) {
        $('#productId').val(ui.item.id);
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