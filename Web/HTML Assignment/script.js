// script.js
document.addEventListener('DOMContentLoaded', () => 
{
    // Get the list of navigation links
    const navLinks = document.querySelectorAll('#nav-links li a');
  
    // Add event listeners to each link
    navLinks.forEach(link => 
    {
      // When the mouse enters the link, change its color
      link.addEventListener('mouseenter', () => 
      {
        link.style.color = '#fff';
        link.style.backgroundColor = '#796f6f';
      });
  
      // When the mouse leaves the link, revert to the original color
      link.addEventListener('mouseleave', () => 
      {
        link.style.color = '#766363';
        link.style.backgroundColor = 'transparent';
      });
    });
});
document.addEventListener('DOMContentLoaded', () => 
{
    const images = document.querySelectorAll('.switchable-image');
    const prevButton = document.getElementById('prev-btn');
    const nextButton = document.getElementById('next-btn');
    let currentImageIndex = 0;
  
    // Function to show the current image and hide others
    function showCurrentImage() 
    {
      images.forEach((image, index) => 
      {
        if (index === currentImageIndex) 
        {
          image.style.display = 'block';
        } 
        else 
        {
          image.style.display = 'none';
        }
      });
    }
  
    // Function to switch to the previous image
    function showPrevImage() 
    {
      currentImageIndex = (currentImageIndex - 1 + images.length) % images.length;
      showCurrentImage();
    }
  
    // Function to switch to the next image
    function showNextImage() 
    {
      currentImageIndex = (currentImageIndex + 1) % images.length;
      showCurrentImage();
    }
  
    // Add event listeners to the previous and next buttons
    prevButton.addEventListener('click', showPrevImage);
    nextButton.addEventListener('click', showNextImage);
  
    // Show the initial image (first image)
    showCurrentImage();
  });
  document.addEventListener('DOMContentLoaded', () => 
  {
    const form = document.getElementById('newsletter-form');
  
    form.addEventListener('submit', (event) => 
    {
      event.preventDefault(); // Prevent the form from submitting by default
  
      // Call the validateForm function to perform form validation
      if (validateForm()) 
      {
        form.submit(); // Manually submit the form if validation passes
      }
    });
  });
  function validateForm() 
  {
    const emailInput = document.getElementById('email');
    const nameInput = document.getElementById('name');
    const phoneInput = document.getElementById('phone');
  
    // Regular expression to validate email format
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    const phoneRegex = /^92\d{10}$/;
  
    // Validate email format using the regular expression
    if (!emailRegex.test(emailInput.value))
    {
      alert('Please enter a valid email address.');
      return false; // Prevent form submission
    }
  
    // Validate other required fields
    if (nameInput.value.trim() === '') 
    {
      alert('Please enter your name.');
      return false; // Prevent form submission
    }
  
    if (!phoneRegex.test(phoneInput.value.trim()))
    {
        alert('Please enter a valid phone number starting with "92" and having 10 digits after it.');
        return false; // Prevent form submission
    }
  
    // Form is valid, allow form submission
    return true;
  }
  