$(document).ready(function () {
    $(".paste-token-btn").click(async function (e) {
        let copiedText = await navigator.clipboard.readText();
        $(".paste-token-textbox").val(copiedText);
    });
});