$(function () {
    var form = $("#myForm")
    var url = form.attr('action')

    $("#filterName").keyup(function (event) {
        event.preventDefault()
        if ($(this).val().length === 0) {
            location.reload(true);
        }

        else {
            $.ajax({
                url: url,
                data: form.serialize(),
                success: function (data) {
                    $('.tbody').html(data);
                }
            });
        }
    });
});


$(function () {
    var form = $("#myForm2")
    var url = form.attr('action')

    $("#myForm2").on('change', function () {
        $.ajax({
            url: url,
            data: form.serialize(),
            success: function (data) {
                $(".tbody").html(data);
            }
        });
    });
});

$(function () {
    var form = $("#myForm3")
    var url = form.attr('action')

    $("#filterDate").keyup(function () {
        if ($(this).val().length === 0) {
            location.reload(true);
        }
        else {
            $.ajax({
                url: url,
                data: form.serialize(),
                success: function (data) {
                    $("tbody").html(data);
                }
            });
        }
    });
});

$(function () {
    var form = $("#myForm4")
    var url = form.attr('action')

    $("#userNamefilter").keyup(function () {
        if ($(this).val().length === 0) {
            location.reload(true);
        }
        else {
            $.ajax({
                url: url,
                data: form.serialize(),
                success: function (data) {
                    $("tbody").html(data);
                }
            });
        }
    });
});