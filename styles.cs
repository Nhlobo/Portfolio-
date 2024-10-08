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
}

.home-subtitle {
    font-size: 1.8rem;
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
    margin-bottom: 20px;
    text-transform: uppercase;
}

.skills-subtitle {
    font-size: 1.2rem;
    color: #777;
}

.skills-container {
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
}

.skills-content {
    width: 45%;
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

.skills-header {
    margin-bottom: 20px;
}

.skills-name {
    font-size: 1.5rem;
    font-weight: bold;
}

.skills-bar {
    width: 100%;
    height: 8px;
    background: #de5d83;
    border-radius: 5px;
    animation: growBar 1.5s ease-in-out;
}

/* Qualifications Section */
.qualification {
    padding: 80px 20px;
    background-color: #f4f4f9;
    text-align: center;
}

.qualification-title {
    font-size: 2.5rem;
    color: #ff6f61;
    margin-bottom: 10px;
}

.qualification-subtitle {
    font-size: 1.2rem;
    color: #777;
}

.qualification-data {
    margin: 20px 0;
}

/* Services Section */
.services {
    padding: 80px 20px;
    background-color: #fff;
    text-align: center;
}

.services-title {
    font-size: 2.8rem;
    color: #ff6f61;
    margin-bottom: 20px;
}

.services-content {
    margin: 20px auto;
    width: 45%;
    position: relative;
}

.services-button {
    margin-top: 10px;
}

.services-modal {
    display: none; /* Initially hidden */
    position: absolute;
    background: #fff;
    border-radius: 10px;
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.2);
    padding: 20px;
    z-index: 10;
}

.services-content:hover .services-modal {
    display: block; /* Show on hover */
}

/* Portfolio Section */
.portfolio {
    padding: 80px 20px;
    background-color: #f4f4f9;
    text-align: center;
}

.portfolio-title {
    font-size: 2.8rem;
    color: #ff6f61;
    margin-bottom: 20px;
}

.portfolio-container {
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
}

.portfolio-content {
    width: 45%;
    margin: 20px;
    position: relative;
}

.portfolio-img {
    width: 100%;
    border-radius: 15px;
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
}

/* Testimonials Section */
.testimonial {
    padding: 80px 20px;
    background-color: #fff;
    text-align: center;
}

.testimonial-title {
    font-size: 2.8rem;
    color: #ff6f61;
    margin-bottom: 20px;
}

.testimonial-container {
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
}

.testimonial-content {
    width: 30%;
    margin: 20px;
    padding: 30px;
    background: #f9f9f9;
    border-radius: 15px;
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
}

/* Contact Section */
.contact {
    padding: 80px 20px;
    background-color: #f4f4f9;
    text-align: center;
}

.contact-title {
    font-size: 2.8rem;
    color: #ff6f61;
    margin-bottom: 20px;
}

.contact-information {
    display: flex;
    justify-content: center;
    align-items: center;
    margin: 20px 0;
}

.contact-inputs {
    display: flex;
    flex-direction: column;
    align-items: center;
}

.contact-content {
    margin: 10px 0;
    width: 80%;
    max-width: 600px;
}

/* Responsive Design */
@media (max-width: 768px) {
    .skills-content,
    .services-content,
    .portfolio-content,
    .testimonial-content {
        width: 90%;
    }

    .skills-container {
        flex-direction: column;
        align-items: center;
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

@keyframes growBar {
    from {
        width: 0;
    }
    to {
        width: 100%;
    }
}
