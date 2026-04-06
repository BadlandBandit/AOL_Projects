// Calculator.js
// This script handles the logic for a basic calculator web app.
// It manages user input, performs calculations, and updates the display.
// Stores the calculator state
const Calculator = {
    Display_Value: '0',
    First_Operand: null,
    Wait_Second_Operand: false,
    operator: null,
}

function Input_Digit(digit) {
    // Destructure values from the Calculator object
    const { Display_Value, Wait_Second_Operand } = Calculator;
    if (Wait_Second_Operand === true) {
        Calculator.Display_Value = digit;
        Calculator.Wait_Second_Operand = false;
    } else {
        Calculator.Display_Value = Display_Value === '0' ? digit : Display_Value + digit;
    }
}

function Input_Decimal(dot) {
    if (Calculator.Wait_Second_Operand === true) return;
    // If the decimal point is not already present, add it
    if (!Calculator.Display_Value.includes(dot)) {
        Calculator.Display_Value += dot;
    }
}

function Handle_Operator(Next_Operator) {
    // Destructure values from the Calculator object
    const { First_Operand, Display_Value, operator } = Calculator
    const Value_of_Input = parseFloat(Display_Value);
    if (operator && Calculator.Wait_Second_Operand) {
        Calculator.operator = Next_Operator;
        return;
    }
    // If no first operand exists, set it
    if (First_Operand == null) {
        Calculator.First_Operand = Value_of_Input;
    } else if (operator) {
        const Value_Now = First_Operand || 0;
        // Perform the calculation based on the operator
        let result = Perform_Calculation[operator](Value_Now, Value_of_Input);
        result = Number(result).toFixed(9)
        result = (result * 1).toString()
        Calculator.Display_Value = parseFloat(result);
        Calculator.First_Operand = parseFloat(result);
    }
    // Indicate that we are waiting for the second operand
    Calculator.Wait_Second_Operand = true;
    Calculator.operator = Next_Operator;
}

const Perform_Calculation = {
    // Define the operations for the calculator
    '/': (First_Operand, Second_Operand) => First_Operand / Second_Operand,
    '*': (First_Operand, Second_Operand) => First_Operand * Second_Operand,
    '+': (First_Operand, Second_Operand) => First_Operand + Second_Operand,
    '-': (First_Operand, Second_Operand) => First_Operand - Second_Operand,
    '=': (First_Operand, Second_Operand) => Second_Operand
};

function Calculator_Reset() {
    // Reset the calculator to its initial state
    Calculator.Display_Value = '0';
    Calculator.First_Operand = null;
    Calculator.Wait_Second_Operand = false;
    Calculator.operator = null;
}

function Update_Display() {
    // Update the display with the current value
    const display = document.querySelector('.calculator-screen');
    display.value = Calculator.Display_Value;
}

Update_Display();

const keys = document.querySelector('.calculator-keys');
keys.addEventListener('click', (event) => {
    // Get the target of the click event
    const { target } = event;
    if (!target.matches('button')) {
        return;
    }
    if (target.classList.contains('operator')) {
        // Handle operator button clicks
        Handle_Operator(target.value);
        Update_Display();
        return;
    }
    if (target.classList.contains('decimal')) {
        // Handle decimal button clicks
        Input_Decimal(target.value);
        Update_Display();
        return;
    }
    if (target.classList.contains('all-clear')) {
        // Reset the calculator when the clear button is clicked
        Calculator_Reset();
        Update_Display();
        return;
    }
    // Handle digit button clicks
    Input_Digit(target.value);
    Update_Display();
});