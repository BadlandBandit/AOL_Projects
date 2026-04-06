// Example showing how concat() works

function useConcat() {



    // Create variables for first and last name

    var firstName = "John";

    var lastName = "Doe";



    // Combine the names into one string

    var fullName = firstName.concat(" ", lastName);



    // Display the result on the page

    var outputElem = document.getElementById("outputText");
    if (outputElem) {
        outputElem.innerHTML = "concat() result: " + fullName;
    }

}





// Example showing how slice() works

function useSlice() {



    // Create a message string

    var message = "JavaScript is fun!";



    // Take a part of the message

    var result = message.slice(0, 10);



    // Display the result on the page

    var outputElem = document.getElementById("outputText");
    if (outputElem) {
        outputElem.innerHTML = "slice() result: " + result;
    }

}





// Example showing how toString() works

function useToString() {



    // Create a number variable

    var number = 123;



    // Change the number to a string

    var result = number.toString();



    // Display the result on the page

    var outputElem = document.getElementById("outputText");
    if (outputElem) {
        outputElem.innerHTML = "toString() result: " + result;
    }

}





// Example showing how toPrecision() works

function useToPrecision() {



    // Create a number variable

    var num = 3.1415926535;



    // Format the number to a set length

    var result = num.toPrecision(4);



    // Display the result on the page

    var outputElem = document.getElementById("outputText");
    if (outputElem) {
        outputElem.innerHTML = "toPrecision() result: " + result;
    }

}

