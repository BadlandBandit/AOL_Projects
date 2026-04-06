// Check if rider is tall enough
function Ride_Function() {
    var Height = document.getElementById("Height").value;

    var Can_ride = Height < 52
        ? "Sorry, you are too short"
        : "Great! You are tall enough";

    document.getElementById("Ride").innerHTML =
        Can_ride + " to ride the Roller Coaster";
}


// Ride Constructor
function Ride(name, minHeight, speed, color) {
    this.Ride_Name = name;
    this.Ride_MinHeight = minHeight;
    this.Ride_Speed = speed;
    this.Ride_Color = color;
}


// Creating Ride Objects
var coaster = new Ride("Thunder Coaster", 52, "90 km/h", "Red");
var ferris = new Ride("Sky Wheel", 0, "10 km/h", "Blue");
var dropTower = new Ride("Mega Drop", 55, "120 km/h", "Black");


// Display Ride Info
function showRide() {
    document.getElementById("Ride_Info").innerHTML =
        coaster.Ride_Name + " goes up to " +
        coaster.Ride_Speed + " and is " +
        coaster.Ride_Color + " in color.";
}


// Nested Function for Message
function rideMessage() {
    var message = "Welcome to the park,";

    function addRide() {
        message = message + " enjoy the Thunder Coaster!";
    }

    addRide();

    document.getElementById("Nested_Function").innerHTML = message;
}
