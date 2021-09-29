// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function ShowDetails(uid) {
    $.ajax({
        type: "Get",
        url: "/ControlPanel/Details",
        data: { id: uid },
        success: function (response) {
            $("#details #Details_Body").html(response);
            $(".modal-header").html("User Details");
            $("#details").modal("show");
        }
    })
}
function Create() {
    $.ajax({
        type: "Get",
        url: "/ControlPanel/Create",
        success: function (response) {
            $("#details #Details_Body").html(response);
            $(".modal-header").html("Create User");
            $("#details").modal("show");
        }
    })
}
function Edit(uid) {
    $.ajax({
        type: "Get",
        url: "/ControlPanel/Edit",
        data: { id: uid },
        success: function (response) {
            $("#details #Details_Body").html(response);
            $(".modal-header").html("Edit");
            $("#details").modal("show");
        }
    })
}


//Hall And Shop
function select() {
    let type = $("#Type").val();
    if (type == 'Hall') {
        document.getElementById("area").style.display = "block";
        document.getElementById("typeOfShop").style.display = "none";
    }
    else if (type == 'Shop') {
        document.getElementById("area").style.display = "none";
        document.getElementById("typeOfShop").style.display = "block";
    }
}

function Details(uid) {
    $.ajax({
        type: "Get",
        url: "/HallShops/Details",
        data: { id: uid },
        success: function (response) {
            $("#details #Details_Body").html(response);
            $(".modal-header").html("User Details");
            $("#details").modal("show");
        }
    })
}