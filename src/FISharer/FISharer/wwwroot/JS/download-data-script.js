$(document).ready(function () {
    $(".paste-token-btn").click(async function (e) {
        e.preventDefault();
        let copiedText = await navigator.clipboard.readText();
        $(".paste-token-textbox").val(copiedText);
    });

    $(".get-archive-info-btn").click(async function (e) {
        e.preventDefault();
        let formData = new FormData();
        formData.append("token", "che");

        let response = await (await fetch("/FilesShare/GetFilesInfo", {
            headers: {
                'Content-Type': 'application/json'
            },
            method: "POST",
            body: formData
        })).json();
        console.log(response);
    });
});