// Smooth scrolling for anchor links
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        const target = document.querySelector(this.getAttribute('href'));
        if (target) {
            target.scrollIntoView({ behavior: 'smooth' });
        }
    });
});

// Function to open the image popup modal
function openModal(imagePath) {
    const modal = document.getElementById("imageModal");
    const modalImg = document.getElementById("modalImg");
    
    if (modal && modalImg) {
        modal.style.display = "flex";
        modalImg.src = imagePath;
    } else {
        console.error("Modal elements (imageModal or modalImg) were not found in the HTML.");
    }
}

// Function to close the modal popup
function closeModal() {
    const modal = document.getElementById("imageModal");
    if (modal) {
        modal.style.display = "none";
    }
}

// Placeholder for your custom character animation logic
const spriteContainer = document.getElementById('animation-container');