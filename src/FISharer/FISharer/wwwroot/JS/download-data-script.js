$(document).ready(function () {
    $(".paste-token-btn").click(async function (e) {
        e.preventDefault();
        let copiedText = await navigator.clipboard.readText();
        $(".paste-token-textbox").val(copiedText);
    });

    $(".get-archive-info-btn").click(async function (e) {
        e.preventDefault();
        const formData = new FormData();
        const token = $(".paste-token-textbox").val();
        formData.append("token", token);

        let response = await (await fetch("/FilesShare/GetFilesInfo", {
            method: "POST",
            body: formData)
        })).json();
        console.log(response);
    });
});