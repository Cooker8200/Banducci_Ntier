console.log("Profile Scripts running");

//leadership profile ajax calls
$(document).ready(function () {
    $("#jonb_bio").click(function () {
        $.ajax({
            url: "/home/_JonB_GetBio",
            success: function (result) {
                $("#bio_area").html(result);
            }
        })
    })

    $("#michelleb_bio").click(function () {
        $.ajax({
            url: "/home/_MichelleB_GetBio",
            success: function (result) {
                $("#bio_area").html(result);
            }
        })
    })

    $("#therese_bio").click(function () {
        $.ajax({
            url: "/home/_Therese_GetBio",
            success: function (result) {
                $("#bio_area").html(result);
            }
        })
    })

    $("#jim_bio").click(function () {
        $.ajax({
            url: "/home/_Jim_GetBio",
            success: function (result) {
                $("#bio_area").html(result);
            }
        })
    })

    $("#angie_bio").click(function () {
        $.ajax({
            url: "/home/_Angie_GetBio",
            success: function (result) {
                $("#bio_area").html(result);
            }
        })
    })

    $("#julie_bio").click(function () {
        $.ajax({
            url: "/home/_Julie_GetBio",
            success: function (result) {
                $("#bio_area").html(result);
            }
        })
    })

    $("#barb_bio").click(function () {
        $.ajax({
            url: "/home/_Barb_GetBio",
            success: function (result) {
                $("#bio_area").html(result);
            }
        })
    })

    $("#carol_bio").click(function () {
        $.ajax({
            url: "/home/_carol_GetBio",
            success: function (result) {
                $("#bio_area").html(result);
            }
        })
    })

})
