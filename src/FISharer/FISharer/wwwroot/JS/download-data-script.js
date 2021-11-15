async function sendRequestByToken(query) {
    const formData = new FormData();
    const token = $(".paste-token-textbox").val();
    formData.append("token", token);

    let response = await (await fetch(query, {
        method: "POST",
        body: formData
    })).json();
    return response;
}
async function downloadArchive() {
    const formData = new FormData();
    const token = $(".paste-token-textbox").val();
    formData.append("token", token);

    let response = await (await fetch("/FilesShare/DownloadArchive", {
        method: "POST",
        body: formData
    })).blob;
    return response;
}

async function getArchiveInfos() {
    return await sendRequestByToken("/FilesShare/GetFilesInfo");
}

$(document).ready(function () {
    $(".paste-token-btn").click(async function (e) {
        e.preventDefault();
        let copiedText = await navigator.clipboard.readText();
        $(".paste-token-textbox").val(copiedText);
    });

    $(".get-archive-info-btn").click(async function (e) {
        e.preventDefault();
        const response = await getArchiveInfos();
        console.log(response);

        if (response.status == "BAD") {
            alert("Invalid token");
        }
        else {
            $(".b-download-form").slideDown();
            const formData = new FormData(document.querySelector(".download-archive-form"));
            console.log(formData);
            formData.set("token", $(".paste-token-textbox").val());
        }
    });

});