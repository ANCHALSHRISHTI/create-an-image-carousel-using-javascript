var prevbtn = 
document.querySelector(".prev");
var nextbtn = 
document.querySelector(".next");
var imag = document.querySelector(".car-
container").children;
totalImg = imag.length;
var i = 0;
prevbtn.addEventListener("click", () => {
  nextIm("prev");
});
nextbtn.addEventListener("click", () => {
  nextIm("next");
});
window.addEventListener("load",()=>{
    setInterval(() => {
      nextIm("next");
    }, 3000);
  });
function nextIm(d) {
  if (d === "next") {
    i++;
    if (i === totalImg) {
      i = 0;
    }
  } else {
    if (i == 0) {
      i = totalImg - 1;
    } else {
      i--;
    }
  }
  for (let i = 0; i < totalImg; i++) {
imag[i].classList.remove("show");
  }
imag[i].classList.add("show");
}
