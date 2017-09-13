
$(document).ready(function () {
    //no longer using toggle...making ajax calls and partial views instead
    //$("#jonb").click(function () {
    //    $("jon_bio").slideToggle();
    //})

    //$("#michelleb").click(function () {
    //    $("#michelle_bio").slideToggle();
    //})

    //ajax calls for about page partial views
    $("#about_history").click(function () {
        $.ajax({
            url: "/home/_BanducciStory",
            success: function (result) {
                $("#about_info").html(result);
            }
        })
    })

    $("#about_leadership").click(function () {
        $.ajax({
            url: "/home/_LeadershipTeam",
            success: function (result) {
                $("#about_info").html(result);
            }
        })
    })

    $("#about_partnerships").click(function () {
        $.ajax({
            url: "/home/_Partnerships",
            success: function (result) {
                $("#about_info").html(result);
            }
        })
    })

    //nav bar
    $(window).scroll(
        {
            previousTop: 0
        },
        function(){
            var currentTop = $(window).scrollTop();
            if (currentTop < this.previousTop){
                $("#nav").show();
            }
            else {
                $("#nav").hide();
            }
            this.previousTop = currentTop;
        })
            
})