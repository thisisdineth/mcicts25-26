@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&family=Oswald:wght@400;700&display=swap');

:root {
    --primary-bg: #1a0a33; /* Dark purple */
    --secondary-bg: #2b114d; /* Slightly lighter purple */
    --accent-yellow: #ffd700;
    --text-light: #ffffff;
    --text-dark: #cccccc;
}

body {
    margin: 0;
    font-family: 'Montserrat', sans-serif;
    color: var(--text-light);
    background-color: var(--primary-bg);
    overflow-x: hidden;
    scroll-behavior: smooth;
}

/* Hero Section */
.hero-section {
    position: relative;
    width: 100%;
    height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
    text-align: center;
    background: linear-gradient(to bottom, var(--primary-bg), var(--secondary-bg));
    overflow: hidden;
}

.hero-content {
    z-index: 1;
    position: relative;
    padding: 20px;
    box-sizing: border-box;
}

.main-logo {
    width: 80%; /* Adjust based on your image dimensions */
    max-width: 600px; /* Max width for the main image */
    height: auto;
    margin-bottom: 20px;
    box-shadow: 0 0 30px rgba(255, 215, 0, 0.5); /* Subtle glow */
    border-radius: 10px; /* Slightly rounded corners */
}

.hero-content h1 {
    font-family: 'Oswald', sans-serif;
    font-size: 3.5em;
    margin: 0.2em 0;
    color: var(--accent-yellow);
    text-shadow: 0 0 10px rgba(255, 215, 0, 0.7);
    letter-spacing: 2px;
}

.hero-content h2 {
    font-family: 'Oswald', sans-serif;
    font-size: 5em;
    margin: 0.1em 0;
    color: var(--accent-yellow);
    text-shadow: 0 0 15px rgba(255, 215, 0, 0.9);
    letter-spacing: 5px;
}

.hero-content h3 {
    font-family: 'Montserrat', sans-serif;
    font-size: 3em;
    margin: 0.5em 0 0.8em;
    color: var(--text-light);
    letter-spacing: 3px;
    text-transform: uppercase;
}

.hero-content p {
    font-size: 1.5em;
    color: var(--text-dark);
    margin-bottom: 30px;
}

.apply-button {
    display: inline-block;
    background: linear-gradient(to right, #ffd700, #ffae00);
    color: var(--primary-bg);
    padding: 18px 45px;
    border-radius: 50px;
    text-decoration: none;
    font-size: 1.8em;
    font-weight: bold;
    letter-spacing: 1.5px;
    transition: all 0.3s ease;
    box-shadow: 0 5px 20px rgba(255, 215, 0, 0.5);
    text-transform: uppercase;
}

.apply-button:hover {
    transform: translateY(-5px) scale(1.05);
    box-shadow: 0 8px 30px rgba(255, 215, 0, 0.7);
    background: linear-gradient(to right, #ffae00, #ffd700);
}

.logos-bottom {
    margin-top: 50px;
    display: flex;
    justify-content: center;
    gap: 30px;
}

.small-logo {
    width: 80px; /* Adjust size for smaller logos */
    height: auto;
    filter: drop-shadow(0 0 5px rgba(255, 255, 255, 0.3));
}

.website-link {
    font-size: 1.2em;
    margin-top: 20px;
    color: var(--text-dark);
    text-decoration: none;
}

/* Timeline Section */
.timeline-section {
    padding: 100px 20px;
    background-color: var(--secondary-bg);
    text-align: center;
    opacity: 0; /* Initially hidden */
    transform: translateY(50px); /* Initially moved down */
    transition: opacity 1s ease-out, transform 1s ease-out;
}

.timeline-section.visible {
    opacity: 1;
    transform: translateY(0);
}

.timeline-section h2 {
    font-family: 'Oswald', sans-serif;
    font-size: 3.5em;
    color: var(--accent-yellow);
    margin-bottom: 60px;
    text-shadow: 0 0 8px rgba(255, 215, 0, 0.5);
}

.timeline {
    position: relative;
    max-width: 900px;
    margin: 0 auto;
    padding: 20px 0;
}

.timeline::before {
    content: '';
    position: absolute;
    width: 4px;
    background-color: var(--accent-yellow);
    top: 0;
    bottom: 0;
    left: 50%;
    margin-left: -2px;
}

.timeline-item {
    padding: 10px 40px;
    position: relative;
    background-color: inherit;
    width: 50%;
    box-sizing: border-box;
}

.timeline-item::after {
    content: '';
    position: absolute;
    width: 25px;
    height: 25px;
    right: -17px;
    background-color: var(--primary-bg);
    border: 4px solid var(--accent-yellow);
    top: 15px;
    border-radius: 50%;
    z-index: 1;
}

.timeline-item:nth-child(even) {
    left: 50%;
}

.timeline-item:nth-child(even)::after {
    left: -16px;
}

.timeline-content {
    padding: 20px 30px;
    background-color: var(--primary-bg);
    border-radius: 8px;
    box-shadow: 0 0 20px rgba(0, 0, 0, 0.5);
    transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.timeline-content:hover {
    transform: translateY(-5px);
    box-shadow: 0 5px 25px rgba(255, 215, 0, 0.3);
}

.timeline-date {
    font-size: 1.8em;
    font-weight: bold;
    color: var(--accent-yellow);
    margin-bottom: 10px;
    text-shadow: 0 0 5px rgba(255, 215, 0, 0.5);
}

.timeline-content {
    font-size: 1.2em;
    color: var(--text-light);
}

/* Responsive adjustments */
@media screen and (max-width: 768px) {
    .hero-content h1 {
        font-size: 2.5em;
    }
    .hero-content h2 {
        font-size: 3.5em;
    }
    .hero-content h3 {
        font-size: 2em;
    }
    .apply-button {
        padding: 15px 30px;
        font-size: 1.5em;
    }
    .small-logo {
        width: 60px;
    }

    .timeline::before {
        left: 20px;
    }
    .timeline-item {
        width: 100%;
        padding-left: 60px;
        padding-right: 10px;
    }
    .timeline-item::after {
        left: 13px;
    }
    .timeline-item:nth-child(even) {
        left: 0%;
    }
    .timeline-item:nth-child(even)::after {
        left: 13px;
    }
}

@media screen and (max-width: 480px) {
    .hero-content h1 {
        font-size: 2em;
    }
    .hero-content h2 {
        font-size: 3em;
    }
    .hero-content h3 {
        font-size: 1.5em;
    }
    .main-logo {
        width: 90%;
    }
    .apply-button {
        padding: 12px 25px;
        font-size: 1.2em;
    }
    .logos-bottom {
        flex-direction: column;
        gap: 15px;
    }
    .small-logo {
        width: 50px;
    }

    .timeline-section h2 {
        font-size: 2.5em;
    }
    .timeline-date {
        font-size: 1.5em;
    }
    .timeline-content {
        font-size: 1em;
    }
}