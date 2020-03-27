$(function () {


    $("#btnLogin").click(function () {

        const username = $("#txtUsername").val();
        const password = $("#txtPassword").val();
        const rememberme = $("#cbRememberme").is(":checked");

        var json = {
            Username: username,
            Password: password,
            Rememberme: rememberme
        };
        $.ajax({
            url: '/Login/Login',
            type: 'POST',
            dataType: 'json',
            data: json,
            success: function (data) {
                if (data.Status === true) {
                    window.location.href = "/dashboard/index";
                }
            }
        });

    });

});