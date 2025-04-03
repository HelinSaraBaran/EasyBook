document.addEventListener("DOMContentLoaded", function() {
    const reserverBtn = document.getElementById("reserverBtn");
    const annullerBtn = document.getElementById("annullerBtn");
    const statusText = document.getElementById("statusText");

    function checkReservation() {
        let erReserveret = localStorage.getItem("mødelokale6");
        if (erReserveret === "true") {
            statusText.innerText = "❌ Mødelokale 6 er reserveret!";
            statusText.classList.remove("text-danger");
            statusText.classList.add("text-success");
            reserverBtn.disabled = true; // Deaktiver "Reserver" knappen
            annullerBtn.style.display = "block"; // Vis "Annuller" knappen
        } else {
            statusText.innerText = "✅ Mødelokale 6 er ledigt!";
            statusText.classList.remove("text-danger");
            statusText.classList.add("text-success");
            reserverBtn.disabled = false; // Gør "Reserver" aktiv igen
            annullerBtn.style.display = "none"; // Skjul "Annuller" knappen
        }
    }

    checkReservation(); // Kør funktionen ved start

    reserverBtn.addEventListener("click", function() {
        var modal = new bootstrap.Modal(document.getElementById("bekraeftModal"));
        modal.show();
    });

    document.getElementById("bekraeftKnap").addEventListener("click", function() {
        localStorage.setItem("mødelokale6", "true"); // Gem reservationen i localStorage
        checkReservation(); // Opdater UI
        var modal = bootstrap.Modal.getInstance(document.getElementById("bekraeftModal"));
        modal.hide();
    });

    annullerBtn.addEventListener("click", function() {
        localStorage.removeItem("mødelokale6"); // Fjern reservationen
        checkReservation(); // Opdater UI
    });
});

function toggleAvailability(roomId, button) {
    fetch(`/Index?handler=ToggleAvailability&id=${roomId}`, { method: 'POST' })
        .then(response => response.json())
        .then(data => {
            if (data.success) {
                button.classList.toggle("available", data.isAvailable);
                button.classList.toggle("booked", !data.isAvailable);
                button.innerText = data.isAvailable ? "Ledig" : "Optaget";
            }
        });
}