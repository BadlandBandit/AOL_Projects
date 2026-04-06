/**********************************************
 ASSIGNING GLOBAL AND LOCAL VARIABLES
**********************************************/

// Global variable
var x = 10;


// Local variable function
function Add_numbers_1() {

  // Local variable
  var x = 99;

  // Using local variable
  document.write(10 + x + "<br>");
}


// Using global variable
function Add_numbers_2() {

  document.write(x + 11);

  // Debugging with console.log
  console.log(x);
}


// Call functions
Add_numbers_1();
Add_numbers_2();



/**********************************************
 FUNCTION WITH IF STATEMENT
**********************************************/

function get_Date() {

  // Check current hour
  if (new Date().getHours() < 18) {

    document.getElementById("Greeting").innerHTML =
      "It is currently before 6pm.";
  }
}



/**********************************************
 FUNCTION WITH IF / ELSE STATEMENTS
**********************************************/

function get_Reply() {

  // Get user input
  var user_input =
    document.getElementById("userInput").value;

  var reply;

  // Check if number is even or odd
  if (user_input % 2 === 0) {

    reply = "You entered an even number!";

  } else {

    reply = "You entered an odd number!";
  }

  // Display result
  document.getElementById("feedback").innerHTML = reply;
}



/**********************************************
 TIME FUNCTION (FROM PREVIOUS SLIDES)
**********************************************/

function Time_function() {

  // Get current hour
  var Time = new Date().getHours();

  var Reply;

  // Determine time of day
  if (Time < 12 && Time > 0) {

    Reply = "It is morning time!";

  } else if (Time >= 12 && Time < 18) {

    Reply = "It is afternoon.";

  } else {

    Reply = "It is evening time!";
  }

  // Display result
  document.getElementById("Time_of_day").innerHTML = Reply;
}



/**********************************************
 FUNCTION WITH INTENTIONAL ERROR (DEBUGGING)
**********************************************/

function brokenFunction(a, b) {

  console.log("a =", a);
  console.log("b =", b);

  var result = a + b;

  // Intentional error (misspelled variable)
  console.log(reslt);

  return result;
}

// Call broken function
brokenFunction(4, 6);