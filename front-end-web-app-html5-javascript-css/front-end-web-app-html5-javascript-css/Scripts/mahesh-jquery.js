
$(document).ready(function () {
    console.log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

    var resultDiv = $("#TestResult")

    resultDiv.text("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

    var tonggleButton = $("#tonggleButton");

    tonggleButton.on("click", function () {
        resultDiv.toggle(500, function () {
            resultDiv.text("BBBBBBBBBBBBBBBBBBBBBBBB");
        });

        if (tonggleButton.text() == "Hide")
            tonggleButton.text("Show");
        else
            tonggleButton.text("Hide");
    });

    var itemlist = $("body li");
    itemlist.css("font-size", "8px");
    itemlist.filter(":first").css("font-sze", "20px");

    var resultArray1 = [{
        name: "Mahesh resultArray 1",
        showName: function () {
            console.log(name);
        },
        result2: {
            name: "Mahesh Result2"
        }
    },
    {
    name: "Mahesh resultArray 2",
    showName: function () {
        console.log(name);
    },
    result2: {
        name: "Mahesh Result2"
    }
    }];

    $.each(resultArray1, function (i, item) {
        var results = "<div> " + item.name + "</div>";
        $("#resultArray1Div").append(results);
    });

});