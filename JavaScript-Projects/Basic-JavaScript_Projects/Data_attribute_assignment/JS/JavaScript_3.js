function displayType(character) {
    var characterType = character.getAttribute("data-character-type");
    alert(character.innerHTML + " " + characterType + " " + "is a great car!");
}