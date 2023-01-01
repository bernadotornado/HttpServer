
let x = 1;

function handleButtonClick(){
    let btn = document.getElementById("counter-btn");
    btn.innerText = "Clicked "+ x++ +" times!";
}