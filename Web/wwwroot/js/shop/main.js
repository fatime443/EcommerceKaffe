'use strict'
var preloader = document.getElementById('loading');
function myFunction(){
  preloader.style.display = 'none';
}
/*serch*/
$('.search-btn').click(function(){
  $('.searchbox').toggleClass('d-none')
})
$('.close').click(function(){
  $('.searchbox').toggleClass('d-none')
})
/*side-bar start*/
$(document).ready(function(){
  $('.open-btn').click(function(){
    $('.side-bar').toggleClass('active-bar')
  })
  $('.close-btn').click(function(){
    $('.side-bar').toggleClass('active-bar')
  })
})
$(document).ready(function(){
  var open=document.querySelectorAll('.open-btn')
  if(open.length+1){
    $(".open-btn").click(function(){
      $(".bg-color").css({"position":"fixed","z-index":"9999"})
    })
  }
});
$(document).ready(function(){
  var close=document.querySelectorAll('.close-btn')
  if(close.length+1){
    $(".close-btn").click(function(){
      $(".bg-color").css({"position":"absolute","z-index":"0"})
    })
  }
})
/*side-bar end*/
/*SideMenu*/
/* Open when someone clicks on the span element */
function openNav() {
    document.getElementById("myNav").style.width = "100%";
  }
  /* Close when someone clicks on the "x" symbol inside the overlay */
  function closeNav() {
    document.getElementById("myNav").style.width = "0%";
  }
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
/*ui slider*/
//$( function() {
//  $( "#slider-range" ).slider({
//    range: true,
//    min: 0,
//    max: 100,
//    values: [ 0, 100 ],
//    slide: function( event, ui ) {
//      $( "#amount" ).val( "$" + ui.values[ 0 ] + " - $" + ui.values[ 1 ] );
//    }
//  });
//  $( "#amount" ).val( "$" + $( "#slider-range" ).slider( "values", 0 ) +
//    " - $" + $( "#slider-range" ).slider( "values", 1 ) );
//} );

