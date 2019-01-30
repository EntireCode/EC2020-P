$('#CustomerERPId').change(function () {
    var selectedERPId = $('#CustomerERPId').val();
    $.ajax({
        url: '/api/B1Cards/GetCustomer',
        type: 'GET',
        dataType: 'json',
        data: { CardCode: selectedERPId },
        success: function (data) {
            $('#CustomerName').val(data.cardName);
            $('#CustomerContactEmail').val(data.e_Mail);
        },
        error: function (xhr, status, error) {
            alert(error);
        }
    });
    $('#CustomerName').val();
});
// Add multiple part numbers
$('#addToList').click(function (e) {
    e.preventDefault();

    if ($.trim($('#PartNumber').val()) === "" &&
        $.trim($('#SerialNumber').val()) === "") return;

    var PartNumber = $('#PartNumber').val(),
        SerialNumber = $('#SerialNumber').val(),
        detailsTableBody = $('#detailsTable tbody');

    var item = '<tr><td>' + PartNumber +
        '</td><td>' + SerialNumber +
        '</td><td><a data-itemId="0" href="#" class="deleteItem">Remove</a></td></tr>';

    detailsTableBody.append(item);
    clearItem();
});

// After add a new item in the list, clear clean the form and add more item
function clearItem() {
    $('#SerialNumber').val('');
}

// after add a new item in the list, if you want, you can remove it.
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
function saveRequest(data) {
    return $.ajax({
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        type: 'POST',
        url: '/RMA/RMARequests/RMARequestEdit?handler=SaveRequest',
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
            location.href = "./RMARequestsIndex";
            //location.reload();
        },
        error: function (error) {
            alert('Error!');
        }
    });
}

//collect multiple part numbers for pass to backend
$('#saveRequest').click(function (e) {
    e.preventDefault();

    var itemArray = [];
    itemArray.length = 0;

    $.each($('#detailsTable tbody tr'), function () {
        itemArray.push({
            partNumber: $(this).find('td:eq(0)').html(),
            serialNumber: $(this).find('td:eq(1)').html()
        });
    });

    var data = JSON.stringify({
        id: $('#Id').val(),
        customerERPId: $('#CustomerERPId').val(),
        customerContact: $('#CustomerContact').val(),
        invoiceNumber: $('#InvoiceNumber').val(),
        defectPhenomenon: $('#DefectPhenomenon').val(),
        remark: $('#Remark').val(),
        customerName: $('#CustomerName').val(),
        customerContactEmail: $('#CustomerContactEmail').val(),
        salesPersonUserId: $('#SalesPersonUserId').val(),
        rMANumber: $('#RMANumber').val(),
        rMAIssueDate: $('#RMAIssueDate').val(),
        status: $('#Status').val(),
        rMARequestItems: itemArray
    });

    $.when(saveRequest(data)).then(function (response) {
        console.log(response);
    }).fail(function (err) {
        console.log(err);
    });
});

$('#AssignRMANumber').click(function () {
    $.ajax({
        url: '/api/RMANumbers/GetNext',
        type: 'GET',
        dataType: 'json',
        data: {},
        success: function (data) {            
            $('#RMANumber').val(data);
            var today = new Date();
            var month = today.getMonth() + 1;
            var day = today.getDate();
            var hours = today.getHours();
            var minutes = today.getMinutes();
            var seconds = today.getSeconds();
            var monthString = '';
            var hoursString = '';
            var dayString = '';
            var minutesString = '';
            var secondsString = '';

            if (month > 9)
                monthString = month;
            else
                monthString = '0' + month;

            if (day > 9)
                dayString = day;
            else
                dayString = '0' + day;

            if (hours > 9)
                hoursString = hours;
            else
                hoursString = '0' + hours;

            if (minutes > 9)
                minutesString = minutes;
            else
                minutesString = '0' + minutes;

            if (seconds > 9)
                secondsString = seconds;
            else
                secondsString = '0' + seconds;

            var date = today.getFullYear() + "-" + monthString + "-" + dayString
                + 'T' + hoursString + ':' + minutesString + ':' + secondsString;
            $('#RMAIssueDate').val(date);
            $('#Status').val("RMAIssued");
        },
        error: function (xhr, status, error) {
            alert(error);
        }
    });
});

$('#CloseRMA').click(function (e) {
    var data = JSON.stringify({
        id: $('#Id').val()
    });
    $.ajax({
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        type: 'POST',
        url: '/RMA/RMARequests/RMARequestEdit?handler=CloseRMA',
        data: data,
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        success: function (result) {
            location.href = "./RMARequestsIndex";
        },
        error: function (error) {
            alert('Error!');
        }
    });
});

