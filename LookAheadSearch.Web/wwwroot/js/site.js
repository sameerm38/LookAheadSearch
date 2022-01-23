// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.



// Write your JavaScript code.
function getData() {
    let serchterm = $("input").val();
    if (serchterm.length == 0) {
        $("table").find("tr:gt(0)").remove();
        $("div").empty();
        $("div").html("Please type in to get product data");
    }
    var jqhr = $.ajax({
        url: "LookAheadSearch/Search",
        data: { SearchTerm: serchterm }
    }).done(function (result) {
        $("table").find("tr:gt(0)").remove();
        if (result.length>0) {
            for (var product in result) {

                $("table").append("<tr id= row" + result[product].id + ">");
                var idcol = "<td>" + result[product].id + "</td>";
                var catcol = "<td>" + result[product].category + "</td>";
                var prodcol = "<td>" + result[product].name + "</td>";
                var molcol = "<td>" + result[product].molecule + "</td>";
                var hylcol = "<td><a href=" + result[product].hyperLink + " target=\"_blank\">" + result[product].hyperLink+"</a></td>";
                $("#row" + result[product].id).append(idcol);
                $("#row" + result[product].id).append(catcol);
                $("#row" + result[product].id).append(prodcol);
                $("#row" + result[product].id).append(molcol);
                $("#row" + result[product].id).append(hylcol);
            }
        }
        else {
            $("table").find("tr:gt(0)").remove();
            $("div").empty();
            $("div").html("No Data found");
        }
    }).fail(function () {
        $("table").find("tr:gt(0)").remove();
        $("div").empty();
        $("div").html("No Data found");
    });
}
