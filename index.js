const dino = document.getElementById ("player");
function usreh () {
    if (dino.classList != "jump"){
        dino.classList.add ("jump");
        setTimeout (function(){
            dino.classList.remove("jump");
        }, 500);
    }
}
document.addEventListener ("keydown", function(event){
    if (event.keyCode == 32){
        usreh();
    }
});
const game = document.getElementById ("game")
const cactus = document.getElementById ("cactus");
let isAlive = setInterval (function(){
    let dinoTop = parseInt(window.getComputedStyle(dino).getPropertyValue ("top"));
    let cactusLeft = parseInt (window.getComputedStyle(cactus).getPropertyValue ("left"));
    if (cactusLeft < 50 && cactusLeft > 0 && dinoTop >= 140){
        isAlive = false;
        if (confirm("Do you want to start?")){
            location.reload ();
            isAlive = true;
        }else{
            game.remove();
        }
    }
}, 10);