document.getElementById("printText").addEventListener("click", function () {
    document.getElementById("mainText").innerText = "Hello World";
})
document.getElementById("boldText").addEventListener("click", function () {
    document.getElementById("mainText").style.fontWeight = "bold";
})
document.getElementById("italicText").addEventListener("click", function () {
    document.getElementById("mainText").style.fontStyle = "italic";
})
document.getElementById("underLineText").addEventListener("click", function () {
    document.getElementById("mainText").style.textDecoration = "underline";
})
document.getElementById("resetValues").addEventListener("click", function () {
    document.getElementById("mainText").style = "none";
})