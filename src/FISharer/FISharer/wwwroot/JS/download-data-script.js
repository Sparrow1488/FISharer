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
function bytesToSize(bytes) {
    var sizes = ['Bytes', 'KB', 'MB', 'GB', 'TB'];
    if (bytes == 0) return '0 Byte';
    var i = parseInt(Math.floor(Math.log(bytes) / Math.log(1024)));
    return Math.round(bytes / Math.pow(1024, i), 2) + ' ' + sizes[i];
}
function correctDisplayName(fileName) {
    let resString = fileName;
    if (fileName.length > 20) {
        resString = fileName.substring(0, 20) + "...";
    }
    return resString;
    for (var i = 0; i < length; i++) {

    }
}
function displayDataInfos(dataInfos) {
    $(".files-preview").html("");
    for (let index = 0; index < dataInfos.length; index++) {
        const dataInfo = dataInfos[index];
        $(".files-preview").append(`
                        <div class="files-preview__item">
                            <div class="file__name">
                                <h3 class="text_small text text_dark">
                                    ${correctDisplayName(dataInfo.name)}
                                </h3>
                            </div>
                            <div class="file__size">
                                <h3 class="text text_dark text_small">${bytesToSize(dataInfo.size)}</h3>
                            </div>
                        </div>
                    `);
    }
    $(".files-preview").slideDown();
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
            displayDataInfos(response.infos);
            $(".b-download-form").slideDown();
            const token = $(".paste-token-textbox").val();
            $(document.getElementsByName("token")).val(token);
        }
    });

});