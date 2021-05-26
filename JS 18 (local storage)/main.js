// localStorage.setItem('pirmas', 'kitkas');
// localStorage.removeItem('pirmas');
// pavercia i teksta
// var duomenys = JSON.stringify(duomenys);
// pavercia atgal i masyva
// duomenys = JSON.parse(duomenys);

// SITAS PIRMAM KARTUI ATSIKOMENTUOT
// var duomenys = [
//     {reiksme: 'pirmas'}
// ];
// localStorage.setItem('cardai', JSON.stringify(duomenys));
let h1 = document.querySelector('h1');
let cardHolder = document.querySelector('.card-holder');
const button = document.getElementById('button');
const input = document.getElementById('text');
// Pasiemam duomenis is localstorage
var duomenys = localStorage.getItem('cardai');
// Pasiverciam duomenis is teksto i masyva
duomenys = JSON.parse(duomenys);

// Spausdinam duomenis i html
duomenys.forEach(duomuo => {
    var card = `
    <div class="card">
        ${duomuo.reiksme}
    </div>`;
    cardHolder.innerHTML += card;
});

button.addEventListener('click', function () {
    var card = `
    <div class="card">
        ${input.value}
    </div>`;
    cardHolder.innerHTML += card;
    // Atnaujiman duomenu masyva
    duomenys.push({reiksme: input.value});
    // paverciam masyva i teksta ir idedam i localstorage
    localStorage.setItem('cardai', JSON.stringify(duomenys));
    // localStorage.removeItem('cardai');
console.log(duomenys);
localStorage.setItem('pirmas', 'kitkas');
console.log('pirmas');
});

