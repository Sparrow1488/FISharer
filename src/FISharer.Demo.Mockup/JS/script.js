const mainBlocks = document.querySelectorAll(".main__item");
const navBtns = document.querySelectorAll(".nav__btn");
const activeBtnColors = ["#C70039", "#FFC300", "#1A5276", "#F7DC6F", "#F4F6F7"];

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
function siteStartPosition(){
    $(window).scrollTop(0);
}
function setNavBtnActive(button){
    const rndActiveColor = activeBtnColors[Math.floor(Math.random() * activeBtnColors.length)];

    $(navBtns).removeClass("nav__btn_active");
    $(button).addClass("nav__btn_active");
    $(navBtns).css("background", "transparent");
    $(button).css("background", rndActiveColor);
}
function setNavBtnActiveByIndex(index){
    setNavBtnActive(navBtns[index]);
}

$(document).ready(function () {
    siteStartPosition();
    setTimeout(() => {
        hidePreloader();
    }, 1500);

    $(".up-btn").click(function(){
        setNavBtnActiveByIndex(0);
        window.scroll({top: 0, left: 0, behavior: 'smooth' });
    });

    $(".burger").click(function() {
        $(".menu").toggle("slow");
    });

    $(navBtns).click(function(e) {
        e.preventDefault();

        const btnIndex = $(this).index();
        const positY = $(mainBlocks[btnIndex]).offset().top;
        setNavBtnActive(this);

        window.scroll({top: positY, left: 0, behavior: 'smooth' });
    });
    
});