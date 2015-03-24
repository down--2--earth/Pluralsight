var msg = "Mahesh";
console.log(msg);

var none;

var number = 10;

var testDiv = document.getElementById("TestDiv");
testDiv.innerHTML = "This from java script";

if (none == undefined) {
    console.log("none is undefined");
}

if (number === 10) {
    console.log("10 = 10");
}

function showMsg(msg) {
    console.log("Show Msg " + msg);
}

function showMsg(msg, more) {
    if (!more) {
        console.log("!more");
    }
    console.log("More Show Msg " + msg + "  "+ more);
}

showMsg("Mahesh");

showMsg("Mahesh", "P2");

var showIt = function (msg) {
    console.log(msg);
}

showIt("Show This");

function showItThen(msg, callback) {
    showIt(msg);
    callback();
}

showItThen("show it Then called", function () {
    console.log("CallBack called");
});


var result = {
    name: "Mahesh Result",
    showName: function () {
        console.log(name);
    },
    result2:  {
        name: "Mahesh Result2"
    }
};

result.state = "OK";

console.log(result);

result.showName();


var resultArray = [{
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

console.log(resultArray.length);

console.log(resultArray[0].name);

console.log("=============================");

for (var x = 0; x < resultArray.length; x++) {
    console.log(resultArray[x].name);
}