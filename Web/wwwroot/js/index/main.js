'use strict'
/*search-btn*/
$('.search-btn').click(function(){
  $('.searchbox').toggleClass('d-none')
})
$('.close-btn').click(function(){
  $('.searchbox').toggleClass('d-none')
})
/*search-btn*/

const slides=document.querySelector(".slider").children;
const prev=document.querySelector(".prev");
const next=document.querySelector(".next");
let index=0;
prev.addEventListener("click",function(){
    prevSlide();
})
next.addEventListener("click",function(){
    nextSlide();
})
function prevSlide(){
    if(index==0){
        index=slides.length-1;
    }
    else{
        index--;
    }
    changeSlide();
}
function nextSlide(){
    if(index==slides.length-1){
        index=0;
    }
    else{
        index++;
    }
    changeSlide();
}
function changeSlide(){
    for(let i=0; i<slides.length; i++){
        slides[i].classList.remove("active-slide")
    }
    slides[index].classList.add("active-slide");
}
setInterval(function(){
    nextSlide();
},7500);

/*SideMenu*/
/* Open when someone clicks on the span element */
function openNav() {
    document.getElementById("myNav").style.width = "100%";
  }
  
  /* Close when someone clicks on the "x" symbol inside the overlay */
  function closeNav() {
    document.getElementById("myNav").style.width = "0%";
  }
  /* accordion*/
  var accordion = function(){
    var data=$(".accordion").attr(".data-accordion");
    $(".accordion-header").on("click",function(){
        if(data === "close"){
            $(".accordion-body").slideUp();
            if($(this).hasClass("active")){
                $(this).toggleClass("active");
            }
            else{
                $(".accordion-header").removeClass("active");
                $(this).toggleClass("active");
            }
        }
        else{
            $(this).toggleClass("active");
        }
        $(this).next(".accordion-body").not(":animated").slideToggle();
    })
}
accordion();
/*go top*/
$(document).ready(function(){
  $(window).scroll(function(){
    if($(this).scrollTop() > 40){
      $('#top-btn').fadeIn();
    }else{
      $('#top-btn').fadeOut();
    }
  });
  $("#top-btn").click(function(){
    $('html ,body').animate({scrollTop : 0},800);
  });
});
  /*slick slider*/
$('.products').slick({
    dots: true,
    infinite: false,
    speed: 300,
    slidesToShow: 4,
    slidesToScroll: 4,
    responsive: [
      {
        breakpoint: 992,
        settings: {
          slidesToShow: 3,
          slidesToScroll: 3,
          infinite: true,
          dots: true
        }
      },
      {
        breakpoint: 762,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 2,
          infinite: true,
          dots: true
        }
      },
      {
        breakpoint: 540,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1,
          infinite: true,
          dots: true
        }
      }
      // You can unslick at a given breakpoint now by adding:
      // settings: "unslick"
      // instead of a settings object
    ]
});
/*tabmenu*/
$('.menu-btns button').click(function(){
  $('.menu-btns button').removeClass("active-btn");
  $(this).addClass("active-btn");
  let index=$(this).index();
  $(".tabs").stop().slideUp();
  $(".tabs").eq(index).stop().slideDown();
})
/*testimonial slider*/
$('.testimonial').slick({
  dots: true
});