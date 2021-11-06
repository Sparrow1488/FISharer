function bytesToSize(bytes) {
    var sizes = ['Bytes', 'KB', 'MB', 'GB', 'TB'];
    if (bytes == 0) return '0 Byte';
    var i = parseInt(Math.floor(Math.log(bytes) / Math.log(1024)));
    return Math.round(bytes / Math.pow(1024, i), 2) + ' ' + sizes[i];
 }
 function correctDisplayName(fileName){
     let resString = fileName;
    if(fileName.length > 20) {
        resString = fileName.substring(0,20) + "...";
    }
    return resString;
 }

$(document).ready(function () {
    let filesCount = 0;
    let filesFullSize = 0;

    const filesChanger = document.querySelector(".upload-data-input"); 
    filesChanger.onchange = function(event){
        filesFullSize = 0;
        filesCount = 0;
        $(".files-preview").html("");

        const filesList = this.files;

        if(filesList.length < 1 || !filesList){
            $(".b-preview").slideUp();
        } else{
            for (let index = 0; index < filesList.length; index++) {
                const element = filesList[index];
                $(".files-preview").append(`
                    <div class="files-preview__item">
                        <div class="file__name">
                            <h3 class="text_small text text_dark">
                                ${correctDisplayName(element.name)}
                            </h3>
                        </div>
                        <div class="file__size">
                            <h3 class="text text_dark text_small">${bytesToSize(element.size)}</h3>
                        </div>
                    </div>
                `);
    
                filesCount++;
                filesFullSize += element.size;
                console.log(element);
            }

            $(".b-preview").slideDown();
            $(".files-amout__value").html(`${filesCount}`);
            $(".total-size__value").html(`${bytesToSize(filesFullSize)}`);
        }
    }

    $(".files-submit-btn").click(function(e){
        //e.preventDefault();
        $(".b-upload").slideUp();
        $(".b-success").slideDown();
    });

    $(".copy-link-btn").click(function(e){
        e.preventDefault();
        $(this).html("Copied✅");
        $(".back-page-btn").show();
    });
});