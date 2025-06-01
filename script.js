document.addEventListener('DOMContentLoaded', function() {
    const timelineSection = document.getElementById('timeline-section');

    const observer = new IntersectionObserver(entries => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                timelineSection.classList.add('visible');
                observer.unobserve(timelineSection); // Stop observing once visible
            }
        });
    }, {
        threshold: 0.2 // Trigger when 20% of the section is visible
    });

    observer.observe(timelineSection);
});