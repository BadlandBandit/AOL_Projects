function addition() { // Defining and naming the addition function
    var add = 10 + 15;
    document.getElementById("Add").innerHTML = "10 + 15 = " + add;
}

function subtraction() { // Defining and naming the subtraction function
    var sub = 5 - 2;
    document.getElementById("Sub").innerHTML = "5 - 2 = " + sub;
}

function multiplication() { // Defining and naming the multiplication function
    var mult = 17 * 6;
    document.getElementById("Mlt").innerHTML = "17 * 6 = " + mult;
}

function division() { // Defining and naming the division function
    var divide = 25 / 5;
    document.getElementById("Div").innerHTML = "25 / 5 = " + divide;
}

function random() { // Defining and naming the random function
    document.getElementById("Ran").innerHTML = Math.random() * 10;
}

function modulus_operator() { // Defining and naming the modulus operator function
    var modulus = 54 % 7;
    document.getElementById("Mod").innerHTML =
        "When you divide 54 by 7 you have a remainder of: " + modulus;
}

function Increment() { // Defining and naming the increment function
    var value = document.getElementById("IncrementText").innerHTML;
    value++;
    document.getElementById("IncrementText").innerHTML = value;
}

function Decrement() { // Defining and naming the decrement function
    var value = document.getElementById("DecrementText").innerHTML;
    value--;
    document.getElementById("DecrementText").innerHTML = value;
}