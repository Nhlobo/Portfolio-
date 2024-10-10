// Toggle Menu Function
function toggleMenu() {
  const menu = document.querySelector(".menu-links");
  const icon = document.querySelector(".hamburger-icon");
  menu.classList.toggle("open");
  icon.classList.toggle("open");
}

// Project Slider Navigation
const slider = document.querySelector('.project-slider');
const leftArrow = document.querySelector('.slider-nav.left');
const rightArrow = document.querySelector('.slider-nav.right');

let scrollAmount = 0;

rightArrow.addEventListener('click', () => {
  scrollAmount += 300;
  slider.scroll({
    left: scrollAmount,
    behavior: 'smooth'
  });
});

leftArrow.addEventListener('click', () => {
  scrollAmount -= 300;
  slider.scroll({
    left: scrollAmount,
    behavior: 'smooth'
  });
});

// Touch/Swipe functionality for slider
let isDown = false;
let startX;
let scrollLeft;

slider.addEventListener('mousedown', (e) => {
  isDown = true;
  slider.classList.add('active');
  startX = e.pageX - slider.offsetLeft;
  scrollLeft = slider.scrollLeft;
});

slider.addEventListener('mouseleave', () => {
  isDown = false;
  slider.classList.remove('active');
});

slider.addEventListener('mouseup', () => {
  isDown = false;
  slider.classList.remove('active');
});

slider.addEventListener('mousemove', (e) => {
  if (!isDown) return;
  e.preventDefault();
  const x = e.pageX - slider.offsetLeft;
  const walk = (x - startX) * 3; // Multiply to increase scroll speed
  slider.scrollLeft = scrollLeft - walk;
});
