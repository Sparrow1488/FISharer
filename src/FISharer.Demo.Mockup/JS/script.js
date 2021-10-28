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
    $(window).scroll(function () { 
        const offsetTop = window.scrollY;
        if(offsetTop > 1){
            startServiceCardAnimation();
        }
    });

    $(navBtns).click(function(e) {
        e.preventDefault();

        const btnIndex = $(this).index();
        const positY = $(mainBlocks[btnIndex]).offset().top;
        setNavBtnActive(this);

        window.scroll({top: positY, left: 0, behavior: 'smooth' });
    });
    
});