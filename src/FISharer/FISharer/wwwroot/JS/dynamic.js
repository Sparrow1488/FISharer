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
            console.log("asd");
            const response = await fetch(href);
            console.log(response);
            const html = await response.text();
            $("body").html(html);
            //$("body").load(href);
            setTimeout(() => hidePreloader(), 1500);
        }
        else console.log("Не навигационная кнопка");
    });
});