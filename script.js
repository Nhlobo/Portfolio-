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
