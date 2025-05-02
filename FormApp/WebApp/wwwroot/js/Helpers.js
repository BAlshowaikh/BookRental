// Function for cards that are clickable (Prevent the parent card from interfering with the child buttons inside it)
function preventStretchedLinkClick(selector = '.prevent-stretch') {
    document.querySelectorAll(selector).forEach(function (btn) {
        btn.addEventListener('click', function (e) {
            e.stopPropagation();  // Prevents click from reaching the stretched-link
        });
    });
}


// Function to show successfull or error message
function showFloatingMessage(message, type, iconClass) {
    const container = document.createElement("div");
    container.className = `alert alert-${type} shadow-sm d-inline-flex align-items-center animate-message`;

    container.style.position = "fixed";
    container.style.top = "20px";
    container.style.left = "50%";
    container.style.transform = "translateX(-50%)";
    container.style.zIndex = "1055"; 
    container.style.padding = "1rem 1.5rem";
    container.style.borderRadius = "0.5rem";
    container.style.boxShadow = "0 0.5rem 1rem rgba(0, 0, 0, 0.15)";
    container.style.transition = "opacity 0.3s ease, transform 0.3s ease";

    const icon = document.createElement("i");
    icon.className = `bi ${iconClass} me-2`;

    const span = document.createElement("span");
    span.textContent = message;

    container.appendChild(icon);
    container.appendChild(span);

    document.body.appendChild(container);

    // Animate and remove after 3 seconds
    setTimeout(() => {
        container.style.opacity = "0";
        container.style.transform = "translateX(-50%) translateY(-20px)";
    }, 2500);

    setTimeout(() => {
        container.remove();
    }, 3000);
}


function showSuccessMessage(message) {
    showFloatingMessage(message, "success", "bi-check-circle-fill");
}

function showErrorMessage(message) {
    showFloatingMessage(message, "danger", "bi-exclamation-circle-fill");
}


// You can Apply (similar code) if you have a "Serach" functionality whare the user should typefunction setupAutocomplete(inputSelector, suggestionListSelector, url) {
function setupAutocomplete(inputSelector, suggestionListSelector, url) {
    $(document).ready(function () {
        const $input = $(inputSelector);
        const $suggestions = $(suggestionListSelector);

        // On input event
        $input.on("input", function () {
            const query = $input.val();

            if (query.length >= 2) {
                $.ajax({
                    url: url,
                    data: { term: query },
                    success: function (data) {
                        $suggestions.empty().hide();

                        if (data.length > 0) {
                            $.each(data, function (index, item) {
                                $suggestions.append(
                                    '<li class="list-group-item list-group-item-action">' + item + '</li>'
                                );
                            });
                            $suggestions.show();
                        }
                    },
                    error: function () {
                        // Optional error handling
                    }
                });
            } else {
                $suggestions.empty().hide();
            }
        });

        // When a suggestion is clicked
        $(document).on("click", suggestionListSelector + " li", function () {
            const selected = $(this).text();
            $input.val(selected);
            $suggestions.empty().hide();
        });

        // Hide suggestions on outside click
        $(document).click(function (e) {
            if (!$(e.target).closest(inputSelector).length) {
                $suggestions.empty().hide();
            }
        });
    });
}

