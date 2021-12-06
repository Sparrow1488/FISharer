const mainBlocks = document.querySelectorAll(".main__item");
const navBtns = document.querySelectorAll(".nav__btn");
const activeBtnColors = ["#85929E", "#F4F6F7", "#E5E8E8", "#D4E6F1", "#EBDEF0", "#FAE5D3"];

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
function navigateToBlock(mainBlockIndex){
    const positY = $(mainBlocks[mainBlockIndex]).offset().top;
    setNavBtnActive(navBtns[mainBlockIndex]);
    window.scroll({top: positY, left: 0, behavior: 'smooth' });
}

$(document).ready(function () {
    siteStartPosition();
    setTimeout(() => {
        hidePreloader();
    }, 1500);

    

    

    window.addEventListener("click", function(e) {
        const menu = document.querySelector(".menu");
        if (e.target == menu) {
            $(menu).slideUp();
        }
    }); 

    let serviceCardsWasDisplay = false;
    function startServiceCardAnimation(){
        if(!serviceCardsWasDisplay){
            const cards = $(".service-card");
            $(cards).css("opacity", "0");
            $(cards).animate({ opacity: 1 }, 1500);
        }
        serviceCardsWasDisplay = true;
    }


    let currentTopLocation = 0;
    $(window).scroll(function () { 
        currentTopLocation = window.scrollY;
        if(currentTopLocation > 100){
            startServiceCardAnimation();
        }
    });

    $(navBtns).click(function(e) {
        e.preventDefault();

        const btnIndex = $(this).index();
        navigateToBlock(btnIndex);
    });
});