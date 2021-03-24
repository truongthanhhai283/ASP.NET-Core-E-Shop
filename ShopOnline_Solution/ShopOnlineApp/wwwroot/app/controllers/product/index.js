﻿var productController = function () {
    this.initialize = function () {
        loadData();
    }

    function registerEvents() {
        //todo: binding events to controls
    }

    function loadData() {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAll',
            dataType: 'json',
            success: function (response) {
                $.each(response, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Name: item.Name,
                        Image: item.Image == null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.Image + '" width=25 />',
                        CategoryName: item.ProductCategory.Name,
                        Price: shoponline.formatNumber(item.Price, 0),
                        CreatedDate: shoponline.dateTimeFormatJson(item.DateCreated),
                        Status: shoponline.getStatus(item.Status)
                    });
                    if (render != '') {
                        $('#tbl-content').html(render);
                    }
                });
            },
            error: function (status) {
                console.log(status);
                shoponline.notify('Cannot loading data', 'error');
            }
        })
    }
}