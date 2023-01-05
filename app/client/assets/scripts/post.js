var url = "http://localhost:8081/";
var params = "lorem=ipsum&name=alpha";
var xhr = new XMLHttpRequest();
xhr.open("POST", url, true);

//Send the proper header information along with the request
xhr.setRequestHeader("Content-type", "application/json");

xhr.send(JSON.stringify({name: "John", age: 18}));