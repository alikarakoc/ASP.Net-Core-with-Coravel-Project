$(function () {


    $("#btnAddTask").click(function () {
        const url = $("#txtUrl").val();
        const period = $("#drpPeriod option:selected").val();
        var json = {
            SiteUrl: url,
            Period: period
        };
        $.ajax({
            url: '/dashboard/addtaskpost',
            type: 'POST',
            dataType: 'json',
            data: json,
            success: function (data) {
                window.location.href = "/dashboard/tasks";
            }
        });

    });

});