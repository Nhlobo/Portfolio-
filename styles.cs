/* Global styles */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: 'Poppins', sans-serif;
    background-color: #f4f4f9;
    color: #333;
    line-height: 1.6;
}

/* Container class */
.container {
    width: 90%;
    max-width: 1200px;
    margin: 0 auto;
    padding: 20px;
}

/* Home Section */
.home {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    height: 100vh;
    background: linear-gradient(45deg, #ff6f61, #de5d83);
    color: #fff;
    text-shadow: 1px 1px 5px rgba(0, 0, 0, 0.3);
}

.home-container {
    text-align: center;
    animation: fadeInUp 2s;
}

.home-title {
    font-size: 3rem;
    margin-bottom: 10px;
}

.home-subtitle {
    font-size: 1.8rem;
    margin-bottom: 20px;
}

.home-description {
    max-width: 600px;
    margin-bottom: 30px;
    line-height: 1.8;
}

.home img {
    width: 300px;
    height: 300px;
    object-fit: cover;
    border-radius: 50%;
    margin-bottom: 20px;
    box-shadow: 0px 0px 30px rgba(0, 0, 0, 0.1);
    animation: zoomIn 1.5s;
}

.button {
    padding: 12px 30px;
    background-color: #fff;
    color: #333;
    border-radius: 30px;
    transition: 0.3s ease-in-out;
    display: inline-flex;
    align-items: center;
    justify-content: center;
    text-decoration: none;
    font-size: 1.1rem;
}

.button:hover {
    transform: scale(1.1);
    background-color: #de5d83;
    color: #fff;
}

.home-social-icon {
    font-size: 1.8rem;
    color: #fff;
    margin: 0 10px;
    transition: transform 0.3s ease-in-out;
}

.home-social-icon:hover {
    transform: scale(1.2);
}

.home-scroll {
    margin-top: 40px;
}

/* Skills Section */
.skills {
    padding: 80px 20px;
    background-color: #fff;
    text-align: center;
}

.skills-title {
    font-size: 2.8rem;
    color: #ff6f61;
    margin-bottom: 40px;
    text-transform: uppercase;
    animation: fadeIn 1s ease-in-out;
}

.skills-container {
    display: flex;
    justify-content: center;
    align-items: flex-start;
    flex-wrap: wrap;
    animation: slideUp 1.2s ease-in-out;
}

.skills-content {
    width: 30%;
    margin: 20px;
    padding: 30px;
    background: #f9f9f9;
    border-radius: 20px;
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
    transition: transform 0.4s, box-shadow 0.3s;
}

.skills-content:hover {
    transform: translateY(-5px);
    box-shadow: 0 6px 25px rgba(0, 0, 0, 0.15);
}

.skills-icon {
    font-size: 3rem;
    color: #ff6f61;
    margin-bottom: 20px;
    animation: bounceIn 1s ease-in-out;
}

.skills-header {
    margin-bottom: 20px;
    color: #333;
}

.skills-name {
    font-size: 1.5rem;
    font-weight: bold;
    margin-bottom: 10px;
}

.skills-bar {
    height: 8px;
    background: #de5d83;
    border-radius: 5px;
    animation: growBar 1.5s ease-in-out;
}

.skills-level {
    font-size: 0.9rem;
    color: #777;
    margin-top: 5px;
}

/* Qualifications Section */
.qualifications {
    padding: 80px 20px;
    background-color: #f4f4f9;
    text-align: center;
}

.qualifications-title {
    font-size: 2.8rem;
    color: #ff6f61;
    margin-bottom: 40px;
    text-transform: uppercase;
    animation: fadeIn 1s ease-in-out;
}

.qualifications-list {
    list-style-type: none;
    padding: 0;
    animation: slideUp 1.2s ease-in-out;
}

.qualifications-item {
    font-size: 1.3rem;
    margin: 20px 0;
    position: relative;
    padding-left: 40px;
    animation: fadeInUp 1s ease-in-out;
}

.qualifications-item::before {
    content: "✔";
    position: absolute;
    left: 0;
    color: #ff6f61;
    font-size: 1.8rem;
}

/* Testimonials Section */
.testimonials {
    padding: 80px 20px;
    background-color: #fff;
    text-align: center;
}

.testimonials-title {
    font-size: 2.8rem;
    color: #ff6f61;
    margin-bottom: 40px;
    text-transform: uppercase;
    animation: fadeIn 1s ease-in-out;
}

.testimonials-container {
    display: flex;
    justify-content: center;
    align-items: center;
    flex-wrap: wrap;
}

.testimonial {
    width: 30%;
    margin: 20px;
    padding: 30px;
    background: #f9f9f9;
    border-radius: 20px;
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
    animation: slideUp 1.2s ease-in-out;
    transition: transform 0.4s, box-shadow 0.3s;
}

.testimonial:hover {
    transform: translateY(-5px);
    box-shadow: 0 6px 25px rgba(0, 0, 0, 0.15);
}

.testimonial p {
    font-style: italic;
    color: #555;
}

.testimonial-author {
    font-weight: bold;
    color: #333;
    margin-top: 20px;
}

/* Contact Form Section */
.contact {
    padding: 80px 20px;
    background-color: #f4f4f9;
    text-align: center;
}

.contact-title {
    font-size: 2.8rem;
    color: #ff6f61;
    margin-bottom: 40px;
    text-transform: uppercase;
    animation: fadeIn 1s ease-in-out;
}

.contact-form {
    display: flex;
    flex-direction: column;
    align-items: center;
    animation: fadeInUp 1.2s ease-in-out;
}

.contact-form input,
.contact-form textarea {
    width: 80%;
    max-width: 600px;
    padding: 15px;
    margin: 10px 0;
    border: 1px solid #ccc;
    border-radius: 10px;
    font-size: 1rem;
    transition: border-color 0.3s;
}

.contact-form input:focus,
.contact-form textarea:focus {
    border-color: #ff6f61;
    outline: none;
}

.contact-form button {
    padding: 15px 30px;
    background-color: #ff6f61;
    color: #fff;
    border: none;
    border-radius: 5px;
    font-size: 1rem;
    cursor: pointer;
    transition: background-color 0.3s;
}

.contact-form button:hover {
    background-color: #de5d83;
}

/* Responsive Design */
@media (max-width: 768px) {
    .skills-content,
    .testimonial {
        width: 90%;
    }

    .qualifications-item {
        font-size: 1rem;
    }
}

/* Animations */
@keyframes fadeIn {
    from {
        opacity: 0;
    }
    to {
        opacity: 1;
    }
}

@keyframes fadeInUp {
    from {
        opacity: 0;
        transform: translateY(30px);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
}

@keyframes slideUp {
    from {
        opacity: 0;
        transform: translateY(50px);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
}

@keyframes bounceIn {
    0% {
        opacity: 0;
        transform: scale(0.3);
    }
    50% {
        opacity: 1;
        transform: scale(1.05);
    }
    70% {
        transform: scale(0.9);
    }
    100% {
        transform: scale(1);
    }
}

@keyframes growBar {
    from {
        width: 0;
    }
    to {
        width: 100%;
    }
}

