document.addEventListener('DOMContentLoaded', () => {

    // --- Language Toggle Logic ---
    const langToggleButton = document.getElementById('lang-toggle-btn');
    const elementsEn = document.querySelectorAll('.lang-en');
    const elementsSi = document.querySelectorAll('.lang-si');
    let currentLang = 'en'; // 'en' for English, 'si' for Sinhala

    langToggleButton.addEventListener('click', () => {
        if (currentLang === 'en') {
            // Switch to Sinhala
            elementsEn.forEach(el => el.classList.add('hidden'));
            elementsSi.forEach(el => el.classList.remove('hidden'));
            langToggleButton.textContent = 'English';
            currentLang = 'si';
        } else {
            // Switch to English
            elementsSi.forEach(el => el.classList.add('hidden'));
            elementsEn.forEach(el => el.classList.remove('hidden'));
            langToggleButton.textContent = 'සිංහල';
            currentLang = 'en';
        }
    });

    // --- Lightbox Modal Logic ---
    const lightboxOverlay = document.getElementById('lightbox-overlay');
    const lightboxModal = document.getElementById('lightbox-modal');
    const closeLightboxBtn = document.getElementById('close-lightbox-btn');
    const registerNavBtn = document.getElementById('register-nav-link');
    const registerHeroBtn = document.getElementById('register-hero-btn');

    function openLightbox() {
        lightboxOverlay.classList.remove('hidden');
        lightboxModal.classList.remove('hidden');
    }

    function closeLightbox() {
        lightboxOverlay.classList.add('hidden');
        lightboxModal.classList.add('hidden');
    }

    registerNavBtn.addEventListener('click', (e) => {
        e.preventDefault();
        openLightbox();
    });
    registerHeroBtn.addEventListener('click', openLightbox);

    closeLightboxBtn.addEventListener('click', closeLightbox);
    lightboxOverlay.addEventListener('click', closeLightbox);

    // --- Smooth Scrolling for Anchor Links ---
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            if (this.id !== 'register-nav-link') {
                e.preventDefault();
                document.querySelector(this.getAttribute('href')).scrollIntoView({
                    behavior: 'smooth'
                });
            }
        });
    });

    // --- Intersection Observer for Scroll Animations ---
    const animatedElements = document.querySelectorAll('.animate-on-scroll');
    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('is-visible');
            }
        });
    }, {
        threshold: 0.1
    });

    animatedElements.forEach(el => {
        observer.observe(el);
    });

});