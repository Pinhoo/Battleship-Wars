$(document).ready(function () {

    $("td").on("click", function () {
        var row = $(this).attr("id")[0];
        var col = $(this).attr("id")[1];

        $("select#opcaoX").prop('selectedIndex', col);
        $("select#opcaoY").prop('selectedIndex', row);

    })




});

