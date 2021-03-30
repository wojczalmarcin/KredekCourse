//Prędkość ulicy
let speed = 1.5;
//Prędkość samochodu
let carSpeed = 0;
//Szybkość zwiększania się poziomu:
let gameSpeed = 2;
//Pozycja ulicy
let yMove = 1024;
//Zmienna kolizji
let collision = false;
//Długość mapy
let mapSize = 1536;
//Obrazek ulicy
let street = document.getElementById("street");
//Obrazek pojazdu gracza
let carImg = document.getElementById("player-car");
//Pozycja samochodu na osi X
let carX = carImg.style.objectMarginLeft=540;
//Pozycja samochodu na osi Y
let carY = carImg.style.objectMarginTop=730;
//Tablica przycisków
let keysPressed = {};
//Interwał zwiększania się prędkości
let gameLevelInteval=0;
//Głowny interwał gry
let gameMainInterval = 0;
//Wynik gracza
let score = 0;
// Prędkości losowych samochodów
let randomCarSpeeds = [0,0,0,0,0];
// Pozycja losowych samochodów na osi Y
let randomCarPositionY = [-290,-290,-290,-290,-290];
// Pozycja losowych samochodów na osi X
let randomCarPositionX = [0,0,0,0,0];
// Kierynek jazdy losowych samochodów na osi Y
let randomCarDriveTop = [false,false,false,false,false];
// Tablica przechowująca dane czy samochód jest obrócony
let randomCarRotated = [false,false,false,false,false];

//Funkcja wykonująca jeden tick gry
function GameTick(){
    MoveStreet();
    MoveCar();
    document.getElementById("speed").innerText = "Predkosc: " + (parseInt(speed*40) + carSpeed) + " km/h";
    if(speed > 6)
        clearInterval(gameLevelInteval);
    document.getElementById("score").innerText = "Twój wynik: " + score;
    MoveRandomCars();
    DetectCollision();
    if(collision){
       clearInterval(gameMainInterval);
       setTimeout(function(){window.location.reload();});
       if(score> parseInt(localStorage.getItem("bestScore"))){
           localStorage.setItem("bestScore",score);
           document.getElementById("best-score").innerText = "Twój najlepszy wynik: " + score;
       }
       alert("Koniec gry!! \n Twój wynik to: " + score);
        
    }
}

//Start gry
function StartGame() {
    gameMainInterval = setInterval(GameTick, 1); 
    gameLevelInteval = setInterval(function(){speed+=gameSpeed*0.001; score+=1;},100);
    if (!"bestScore" in localStorage || localStorage.getItem("bestScore") == null) {
        localStorage.setItem("bestScore", 0);
    }else{
        document.getElementById("best-score").innerText = "Twój najlepszy wynik: " + localStorage.getItem("bestScore");
    }
}

//Sprawdzenie naciśniętego przycisku
document.addEventListener('keydown', (e) => {
    if(e.key=='a' || e.key=='d' || e.key=='w' || e.key=='s' || e.key == 'ArrowLeft' || e.key == 'ArrowRight' || e.key == 'ArrowUp' || e.key == 'ArrowDown')
        keysPressed[e.key] = true;
});

//Sprawdzenie puszczonego przycisku
document.addEventListener('keyup', (e) => {
    if(e.key=='a' || e.key=='d' || e.key=='w' || e.key=='s' || e.key == 'ArrowLeft' || e.key == 'ArrowRight' || e.key == 'ArrowUp' || e.key == 'ArrowDown')
        keysPressed[e.key] = false;
});

//Funkcja poruszająca ulicę
function MoveStreet() {
    yMove += speed;
    if (yMove == 2048) {
        yMove = 0;
    }
    let position = 'center ' + yMove + 'px';
    if (street && street.style) {
        street.style.backgroundPosition =  position;
    }
}

//Funkcja poruszająca samochód
function MoveCar(){
    if((keysPressed['a'] || keysPressed['ArrowLeft']) && carX>135){
        carX-=2;
        carImg.style.transform = "rotate(-5deg)";
    }
    else{
        carImg.style.transform = "rotate(0deg)";
    }
    if((keysPressed['d']|| keysPressed['ArrowRight']) && carX<750){
        carX+=2;
        carImg.style.transform = "rotate(5deg)";
    }
    if((keysPressed['w']|| keysPressed['ArrowUp']) && carY>0){
        carY-=1;
        carSpeed = 32;
    }
    else
        carSpeed = 0;    
    if((keysPressed['s']|| keysPressed['ArrowDown']) && carY<mapSize-295){
        carY+=1;
        carSpeed = -32;
    }   
    if (carImg && carImg.style) {
        carImg.style.marginLeft = carX + "px";
        carImg.style.marginTop = carY + "px";
    }
    if((keysPressed['d']|| keysPressed['ArrowRight']) && (keysPressed['a'] || keysPressed['ArrowLeft'])){
        carImg.style.transform = "rotate(0deg)";
    }
      if((keysPressed['w']|| keysPressed['ArrowUp']) && (keysPressed['s'] || keysPressed['ArrowDown'])){
       carSpeed = 0;
      }
        
}

//Funkcja stawiający losowy pojazd
function SetRandomCar(carId) {
    let carNumber = Math.floor(Math.random() * 10);
    let xPos = (carNumber%4)*140;
    let yPos = 0;
    if (carNumber < 4) {
        yPos = 0;
    }
    else if (carNumber < 8) {
        yPos = -290;
    }
    else {
        yPos = -580;
    }
    let randomCar = document.getElementById("random-car" + carId);
    let position = -xPos + 'px ' + yPos + 'px';
    if (randomCar && randomCar.style) {
        randomCar.style.objectPosition = position;
        randomCar.style.marginTop = -290 + "px";
        randomCarPositionY[carId] = -290;
        
        let randomPos = Math.floor(Math.random() * 10);
        if(randomPos < 3){
            randomCar.style.marginLeft = 150 + "px";
            randomCarPositionX[carId] = 150;
            randomCarDriveTop[carId] = false;
        }else if(randomPos<5){
            randomCar.style.marginLeft = 350 + "px";
            randomCarPositionX[carId] = 350;
            randomCarDriveTop[carId] = false;
        }else if(randomPos<7){
            randomCar.style.marginLeft = 550 + "px";
            randomCarPositionX[carId] = 550;
            randomCarDriveTop[carId] = true;
        }
        else{
            randomCar.style.marginLeft = 750 + "px";
            randomCarPositionX[carId] = 750;
            randomCarDriveTop[carId] = true;
        }
        if(DetectSpawnedCars(carId) == true){
            randomCar.style.marginTop = (mapSize + 10) + "px";
            randomCarPositionY[carId] = (mapSize + 10);
        }
        
        if(randomCarDriveTop[carId]){
            randomCarSpeeds[carId] = speed - 0.95;
            if(randomCarRotated[carId]){
                randomCar.style.transform = "rotate(0deg)";
                randomCarRotated[carId] = false;
            }
        }
        else{
            randomCarSpeeds[carId] = speed + 1;
            if(!randomCarRotated[carId]){
                randomCar.style.transform = "rotate(180deg)";
                randomCarRotated[carId] = true;
            }
        }
        DetectSpawnedCars(carId);
    } 
}

//Ustawienie pierwszych losowych samochodów na początku gry
function SetRandomCars(){
    randomCarPositionY[1] = -1200;
    randomCarPositionY[2] = -1200;
    randomCarPositionY[3] = -1200;
    randomCarPositionY[4] = -1200;
    document.getElementById("random-car1").style.marginTop = -1200 + "px";
    document.getElementById("random-car2").style.marginTop = -1200 + "px";
    document.getElementById("random-car3").style.marginTop = -1200 + "px";
    document.getElementById("random-car4").style.marginTop = -1200 + "px";
    SetRandomCar(0);
    setTimeout(function() {SetRandomCar(1);}, 2000);
    setTimeout(function() {SetRandomCar(2);}, 10000);
    setTimeout(function() {SetRandomCar(3);}, 70000);
    setTimeout(function() {SetRandomCar(4);}, 120000);
}

//Funkcja poruszająca losowe samochody
function MoveRandomCars(){
    for(let i = 0;i<5;i++){
        let randomCar = document.getElementById("random-car" + i);
        if(randomCarPositionY[i]>-1000){
            if(randomCarDriveTop[i]){
                randomCarSpeeds[i] = speed -0.9;
            }
            else{
                randomCarSpeeds[i] = speed + 0.9;
            }
            randomCarPositionY[i]+= randomCarSpeeds[i];
            randomCar.style.marginTop = randomCarPositionY[i] + "px";
            if( randomCarPositionY[i] > mapSize){
                SetRandomCar(i);
            }
        }
    }
}

//Funkcja wykrywająca kolizje samochodu gracza z losowymi samochodami
function DetectCollision(){
    for(let i = 0; i<5;i++){
        if((carX+100>randomCarPositionX[i] && carX<randomCarPositionX[i] + 100) 
           && (carY < randomCarPositionY[i] + 245  && carY > randomCarPositionY[i] - 245))
        {
            collision = true;
        }
    }
}

//Funkcja wykrywająca kolizje pojawiających się samochodów, żeby nie pojawiały się za blisko siebie
function DetectSpawnedCars(carId){
    let xBoundry = 140;
    
    if(speed>4.5)
        xBoundry = 400;
    else if(speed>4)
        xBoundry = 140;
    else if(speed>3)
        xBoundry = 400;

    for(let i = 0; i<5;i++){
        if(i != carId){
            if(randomCarPositionY[i]>-1000)
            {
                if(randomCarPositionY[carId] + 600 > randomCarPositionY[i] &&
                  (randomCarPositionX[carId]+xBoundry>randomCarPositionX[i] && randomCarPositionX[carId]<randomCarPositionX[i] + xBoundry))
                {
                   return true;
                }
            }
        }
    }
    return false;
}
    