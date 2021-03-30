//Funkcja ustawiająca pojazd gracza
function SetCar(carId) {
    let carNumber = 0;
    if (!"carNumber" in localStorage) {
        carNumber = 2;
    } 
    else {
        carNumber = parseInt(localStorage.getItem("carNumber"));
    }
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
    let carImg = document.getElementById(carId);
    let position = -xPos + 'px ' + yPos + 'px';
    if (carImg && carImg.style) {
        carImg.style.objectPosition = position;
    }
}

//Funkcja pokazująca wszystkie samochody do wyboru
function ShowCars() {
    let xPos;
    let yPos;
    let carImg;
    let position;
    for (let i = 0; i < 12; i++) {
        xPos = (i % 4) * 140;
        if (i < 4) {
            yPos = 0;
        }
        else if (i < 8) {
            yPos = -290;
        }
        else {
            yPos = -580;
        }
        carImg = document.getElementById("car" + i);
        position = -xPos + 'px ' + yPos + 'px';
        if (carImg && carImg.style) {
            carImg.style.objectPosition = position;
        }
    }
}
//Funkcja zapisująca somochód do localStorage
function ChangeCar(number) {
    localStorage.setItem("carNumber", number);
    document.location.href = "../index.html";
}
