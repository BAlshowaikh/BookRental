// Function for cards that are clickable (Prevent the parent card from interfering with the child buttons inside it)
function preventStretchedLinkClick(selector = '.prevent-stretch') {
    document.querySelectorAll(selector).forEach(function (btn) {
        btn.addEventListener('click', function (e) {
            e.stopPropagation();  // Prevents click from reaching the stretched-link
        });
    });
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

