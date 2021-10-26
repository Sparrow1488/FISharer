function hidePreloader(){
    $(".preloader").animate({ opacity: 0 }, "slow");
    setTimeout(() => {
        $(".preloader").remove();
    }, 500);
}

$(document).ready(function () {
    setTimeout(() => {
        hidePreloader();
    }, 1500);

    // $(".menu").show();
    $(".burger").click(function() {
        $(".menu").toggle("slow");
    });
});