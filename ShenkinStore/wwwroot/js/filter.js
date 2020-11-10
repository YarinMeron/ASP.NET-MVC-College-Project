

$(function () {
    var form = $("#myForm")
    var url = form.attr('action')

    $("#filterName").keyup(function () {
        $.ajax({
            url: url,
            data: form.serialize(),
            success: function (data) {
                $("tbody").html(data);
            }
        });
    });
});
