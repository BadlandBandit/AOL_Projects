// JavaScript Object (Dictionary)
function showCar() {
var sportsCars = {
    Ferrari: "F8 Tributo",
    Lamborghini: "Huracan",
    Porsche: "911 Turbo",
    McLaren: "720S",
    Bugatti: "Chiron"
};


delete sportsCars.Ferrari; // Remove Ferrari from the dictionary

    // Display it in HTML
    document.getElementById("Dictionary").innerHTML =
        "Porsche Model: " + sportsCars.Porsche;
}
