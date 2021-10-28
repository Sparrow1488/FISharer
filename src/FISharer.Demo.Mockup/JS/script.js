function hidePreloader(){
    $(".preloader").animate({ opacity: 0 }, "slow");
    setTimeout(() => {
        $(".preloader").remove();
    }, 500);
}
function enableScroll(){
    $("body").css("overflow-y", "scroll");
}
function disableScroll(){
    $("body").css("overflow-y", "hidden");
}
function init(){
    $(window).scrollTop(0);
}
function hideAll(){
    $(".main__item").hide();
}
function showBlock(index){
    hideAll();
    const first = document.querySelectorAll(".main__item")[index];
    $(first).show();
}

$(document).ready(function () {
    init();
    // showBlock(0);
    disableScroll();
    setTimeout(() => {
        hidePreloader();
        enableScroll();
    }, 1500);

    $(".burger").click(function() {
        $(".menu").toggle("slow");
    });

    const navBtns = document.querySelectorAll(".nav__btn");
    const mainBlocks = document.querySelectorAll(".main__item");
    $(navBtns).click(function(e) {
        e.preventDefault();
        const btnIndex = $(this).index();
        const positY = $(mainBlocks[btnIndex]).offset().top;
        console.log(positY);
        window.scroll({top: positY, left: 0, behavior: 'smooth' });
    });
    
});