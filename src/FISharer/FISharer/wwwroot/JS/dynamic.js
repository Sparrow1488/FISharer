$(document).ready(function () {
    $(".burger").click(function () {
        $(".menu").toggle("slow");
    });

    $(".up-btn").click(function () {
        setNavBtnActiveByIndex(0);
        window.scroll({ top: 0, left: 0, behavior: 'smooth' });
    });

    $("a").click(async function (e) {
        e.preventDefault();
        const href = this.href;
        if (href && !href.includes("#")) {
            $("body").load(href);
            setTimeout(() => hidePreloader(), 1500);
        }
        else console.log("Не навигационная кнопка");
    });
});