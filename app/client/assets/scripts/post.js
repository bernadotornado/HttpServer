var url = "http://localhost:8081/";
var params = "lorem=ipsum&name=alpha";
var xhr = new XMLHttpRequest();
xhr.open("POST", url, true);

//Send the proper header information along with the request
xhr.setRequestHeader("Content-type", "application/json");

var x = 0;
var b = "Hello";
var _1 = true;
var element = document.getElementById("counter-btn");

var elementProps = {
    innerHTML : element.innerHTML,
    innerText : element.innerText,
}

xhr.send(JSON.stringify(elementProps));