function checkBrand() {
  var Brand_Output;
  var Brands = document.getElementById("Brand_Input").value;
  var Brand_String = " is a great brand!";

  switch (Brands) {
    case "Toyota":
      Brand_Output = "Toyota" + Brand_String;
      break;
      case "Honda":
      Brand_Output = "Honda" + Brand_String;
      break;
      case "Ford":
      Brand_Output = "Ford" + Brand_String;
      break;
      case "Chevrolet":
      Brand_Output = "Chevrolet" + Brand_String;
      break;
      case "BMW":
      Brand_Output = "BMW" + Brand_String;
      break;
    default:
      Brand_Output = "Please enter a brand exactly as written on the above list.";
  }

var c = document.getElementById("myCanvas");
var ctx = c.getContext("2d");

// Create gradient
var grd = ctx.createRadialGradient(75, 50, 5, 90, 60, 100);
grd.addColorStop(0, "red");
grd.addColorStop(1, "white");

// Fill with gradient
ctx.fillStyle = grd;
ctx.fillRect(10, 10, 150, 80);


  document.getElementById("Output").innerHTML = Brand_Output;
}