const button = document.getElementById("animateBtn");
const musicNote = document.getElementById("musicNote");

if (button && musicNote) {
    let position = 0;
    let direction = 1;
    let animationRunning = false;
    let animationId;

    function animateNote() {
        position += 3 * direction;
        musicNote.style.left = position + "px";

        if (position > window.innerWidth - 120 || position < 0) {
            direction *= -1;
        }

        animationId = requestAnimationFrame(animateNote);
    }

    button.addEventListener("click", function () {
        if (!animationRunning) {
            animateNote();
            button.textContent = "Stop Animation";
            animationRunning = true;
        } else {
            cancelAnimationFrame(animationId);
            button.textContent = "Start Animation";
            animationRunning = false;
        }
    });
}