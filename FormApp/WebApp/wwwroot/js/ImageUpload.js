document.addEventListener("DOMContentLoaded", function () {
    const imageInput = document.getElementById('ImageFile');
    const uploadBox = document.getElementById('uploadBox');
    const previewDiv = document.getElementById('uploadPreview');
    const placeholderDiv = document.getElementById('uploadPlaceholder');

    if (!imageInput || !uploadBox) return;

    // Prevent double trigger by checking the event target
    uploadBox.addEventListener('click', function (e) {
        // If the actual click is on the input, do nothing (it already opens file dialog)
        if (e.target === imageInput) return;
        imageInput.click();
    });

    imageInput.addEventListener('change', function (e) {
        const file = e.target.files[0];

        if (file && file.type.startsWith('image/')) {
            const reader = new FileReader();
            reader.onload = function (event) {
                previewDiv.style.backgroundImage = `url('${event.target.result}')`;
                previewDiv.classList.remove('d-none');
                placeholderDiv.classList.add('d-none');
            };
            reader.readAsDataURL(file);
        } else {
            previewDiv.classList.add('d-none');
            previewDiv.style.backgroundImage = '';
            placeholderDiv.classList.remove('d-none');
        }
    });
});
