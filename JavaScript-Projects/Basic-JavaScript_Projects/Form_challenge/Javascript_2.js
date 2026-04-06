function validateForm() {
  let x = document.forms["myForm"]["fname"].value;
  if (x == "") {
    alert("Name must be filled out");
    return false;
  }
  let y = document.forms["myForm"]["email"].value;
  if (y == "") {
    alert("Email must be filled out");
    return false;
  }
  let z = document.forms["myForm"]["message"].value;
  if (z == "") {
    alert("Message must be filled out");
    return false;
  }
}