document.addEventListener("DOMContentLoaded", function () {
    const avaliarBotoes = document.querySelectorAll(".btn-avaliar");
    const popup = document.getElementById("popup");
    const closeBtn = document.querySelector(".fechar-popup");
    let rating = 0;

    avaliarBotoes.forEach(botao => {
        botao.addEventListener("click", function (event) {
            event.preventDefault();
            popup.style.display = "flex";
        });
    });

    function closePopup() {
        popup.style.display = "none";
    }

    closeBtn.addEventListener("click", closePopup);

    const stars = document.querySelectorAll(".rating span");
    const ratingValue = document.getElementById("rating-value");

    function setRating(starIndex) {
        rating = starIndex;
        ratingValue.textContent = `Nota: ${rating}`;
        stars.forEach((star, index) => {
            star.classList.toggle("ativo", index < rating);
        });
    }

    stars.forEach((star, index) => {
        star.addEventListener("click", function () {
            setRating(index + 1);
        });
    });

    function submitReview() {
        const reviewText = document.getElementById("reviewText").value;
        if (rating === 0) {
            alert("Por favor, selecione uma nota antes de enviar.");
            return;
        }
        alert(`Avaliação enviada! \nNota: ${rating} \nComentário: ${reviewText}`);
        closePopup();
    }

    window.closePopup = closePopup;
    window.submitReview = submitReview;
});
