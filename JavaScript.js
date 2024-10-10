document.getElementById('contactForm').addEventListener('submit', function(event) {
    event.preventDefault(); // Prevent default form submission

    // Validate inputs
    const name = document.getElementById('name').value;
    const email = document.getElementById('email').value;
    const message = document.getElementById('message').value;

    // Validate email pattern
    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!emailPattern.test(email)) {
        showResponse('Please enter a valid email address.', 'error');
        return;
    }

    if (!name || !email || !message) {
        showResponse('Please fill in all required fields.', 'error');
        return;
    }

    // Check if the user is online
    if (!navigator.onLine) {
        showResponse('It seems there’s an issue with your internet connection. Please check your connection and try again.', 'error');
        return;
    }

    // Submit the form via Fetch API
    const formData = new FormData(this);

    fetch(this.action, {
        method: 'POST',
        body: formData,
        headers: {
            Accept: 'application/json'
        }
    })
    .then(response => {
        if (response.ok) {
            showResponse('Thank you! Your message has been successfully sent.', 'success');
            this.reset(); // Reset the form after successful submission
        } else {
            showResponse('Oops! There was an issue with your submission. Please try again later.', 'error');
        }
    })
    .catch(error => {
        // Catch network errors
        if (!navigator.onLine) {
            showResponse('It seems there’s an issue with your internet connection. Please check your connection and try again.', 'error');
        } else {
            showResponse('There was a problem with your submission. Please try again later.', 'error');
        }
    });
});

// Function to show messages dynamically
function showResponse(message, type) {
    const responseDiv = document.getElementById('response');
    responseDiv.style.display = 'block';
    responseDiv.textContent = message;
    responseDiv.className = type === 'success' ? 'success-message' : 'error-message';

    // Optionally hide the message after a few seconds for a better user experience
    setTimeout(() => {
        responseDiv.style.display = 'none';
    }, 5000);
}
