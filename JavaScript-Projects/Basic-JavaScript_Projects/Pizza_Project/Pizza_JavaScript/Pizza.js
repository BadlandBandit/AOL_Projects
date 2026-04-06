// Main function to start the order process and calculate pizza size price
function getReceipt() {
    // Initialize order summary and totals
    var text1 = "<h3>You Ordered:</h3>";
    var runningTotal = 0;
    var sizeTotal = 0;
    // Get all size radio buttons
    var sizeArray = document.getElementsByClassName("size");
    // Loop through size options to find the selected one
    for (var i = 0; i < sizeArray.length; i++) {
        if (sizeArray[i].checked) {
            var selectedSize = sizeArray[i].value;
            text1 += selectedSize + "<br>";
        }
    }
    // Set price based on selected pizza size
    if (selectedSize === "Personal Pizza") {
        sizeTotal = 6;
    } else if (selectedSize === "Medium Pizza") {
        sizeTotal = 10;
    } else if (selectedSize === "Large Pizza") {
        sizeTotal = 14;
    } else if (selectedSize === "Extra Large Pizza") {
        sizeTotal = 16;
    } else if (selectedSize === "Party Pizza") {
        sizeTotal = 18;
    }
    // Add size price to running total
    runningTotal += sizeTotal;
    // Log size and subtotal for debugging
    console.log(selectedSize + " = $" + sizeTotal + ".00");
    console.log("size text1: " + text1);
    console.log("Subtotal: $" + runningTotal + ".00");
    // Proceed to calculate toppings
    getToppings(runningTotal, text1);
};

// Function to calculate toppings price and update order summary
function getToppings(runningTotal, text1) {
    var toppingTotal = 0;
    var selectedToppings = [];
    // Get all topping checkboxes
    var toppingArray = document.getElementsByClassName("toppings");
    // Loop through toppings and add checked ones to the list
    for (var j = 0; j < toppingArray.length; j++) {
        if (toppingArray[j].checked) {
            selectedToppings.push(toppingArray[j].value);
            // Log each selected topping
            console.log("Topping: " + toppingArray[j].value);
            text1 += toppingArray[j].value + "<br>";
        }
    }
    // First topping is free, each additional topping costs $1
    var toppingCount = selectedToppings.length;
    if (toppingCount > 1) {
        toppingTotal = toppingCount - 1;
    } else {
        toppingTotal = 0;
    }
    runningTotal += (runningTotal + toppingTotal);
    console.log("total selected topping items: " + toppingCount);
    console.log(toppingCount + " topping - 1 free topping = $" + toppingTotal + ".00");
    console.log("topping text1: " + text1);
    console.log("Purchase Total: $" + runningTotal + ".00");

    // Update the HTML to show the order and total price
    document.getElementById("showText").innerHTML = text1;
    document.getElementById("totalPrice").innerHTML = "<h3>Total: <strong>$" + runningTotal + ".00" + "</strong></h3>";
};
