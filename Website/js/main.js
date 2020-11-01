
function CloseMenu() {
    $("#bottom-menu li.pagehandler").addClass("closed");
    setTimeout(()=>{
      $("#bottom-menu > li.menuhandler").removeClass("closed");
  },1000);
}
function OpenMenu() {
  $("#bottom-menu > li.menuhandler").addClass("closed");
  setTimeout(()=>{
    $("#bottom-menu li.pagehandler").removeClass("closed");
  },300);
}
function HideWrapperInIt(query,func){
  $("#wrapper > div *").animate({
    opacity:0
  },700,func);
}
/*
function LoadPage(page){
  $.ajax({
    url:"gp.php",
    method:"POST",
    data:{page:page}
  }).done((data)=>{
    HideWrapperInIt("#wrapper > div",()=>{
      $("#wrapper").html(data);
      InitPage();
    });
    
  }).fail((response)=>{
    HideWrapperInIt("#wrapper > div",()=>{
      $("#wrapper > div *").animate({
        opacity:1
      },500);
    });
  });
}*/
function EjectLoaded(){
  $(".loadingopenbox").addClass("open");
  $(".arrow").addClass("open");
  $("#loadingbar").addClass("closed");
  setTimeout(()=>{
    $("#loadingbar").hide();
  },4*1000);
}
  var TriggerDistance = 100;
  $(document).ready(()=>{
    setTimeout(()=>{
      EjectLoaded();
    },3000);
    $('html, body').animate({
      scrollTop: 0
  }, 0);


  var MenuHammer = new Hammer(document.querySelector("#bottom-menu"));
  var MenuHandler= new Hammer(document.querySelector("#bottom-menu > li.menuhandler"));
  MenuHammer.on('swipe',(ev)=>{
    if(ev.velocity < 0){ // Swipe Left
      OpenMenu(); 
    }
  });
  $("#bottom-menu > li.menuhandler").click((ev)=>{
    OpenMenu();
  });
  MenuHammer.on('swipe',(ev)=>{
    if(ev.velocity > 0){ // Swipe Right
      CloseMenu(); 

    }
  });
});


window.onscroll = function() {stickController()};

$(window).on('resize', function(){
  $(".FullHeight").height(window.innerHeight);
});
$(".FullHeight").height(window.innerHeight);
$('.carousel.carousel-slider').carousel({
  fullWidth: true,
  indicators: true
});
$(".GotoHome").click(function() {
  $('html, body').animate({scrollTop: 0}, 2000);

});

$(".GotoApps").click(function() {
  $('html, body').animate({scrollTop: $("#second-con").offset().top}, 2000);
});
$(".GotoDiscord").click(function() {
  $('html, body').animate({scrollTop: $("#third-con").offset().top}, 2000);
});
$(".GotoContacts").click(function() {
  $('html, body').animate({scrollTop: $("#fourth-con").offset().top}, 2000);
});


$("#GotoUp").click(function() {
$('html, body').animate({
    scrollTop: 0
}, 2000);
});

function animateCSS(element, animationName, callback) {
  const node = document.querySelector(element)
  node.classList.add('animated', animationName)

  function handleAnimationEnd() {
      node.classList.remove('animated', animationName)
      node.removeEventListener('animationend', handleAnimationEnd)

      if (typeof callback === 'function') callback()
  }

  node.addEventListener('animationend', handleAnimationEnd)
}
// Get the navbar
var navbarm =  $("#supernav");
var deltar = false;
var deltarint = 0;
var deltar_ = false;
// Get the offset position of the navbar
var ref = document.querySelector("#supernav .brand-text").offsetHeight;
// Add the sticky class to the navbar when you reach its scroll position. Remove "sticky" when you leave the scroll position
function OpenState(){
  navbarm.addClass("fixed-nav");
}
function CloseState(){
  navbarm.removeClass("fixed-nav");
}
function DeltaHide(){
  navbarm.addClass("deltahide");

}
function DeltaShow(){
  navbarm.removeClass("deltahide");
}
var mq = window.pageYOffset-deltarint;
function OpenSlideUp(){
  $("#GotoUp").removeClass("closed");
}
function CloseSlideUp(){
  $("#GotoUp").addClass("closed");
}
var m = document.getElementById("second-con").offsetTop;
function stickController() {
  //Up -
  //Down +
  /*if(mq<0){

  }else{

  }
  for (let index = 0; index < $(".magnetic").length; index++) {
    const element = $(".magnetic")[index];
    console.log(window.pageYOffset-element.offsetTop);
    if(window.pageYOffset-element.offsetTop < TriggerDistance){
      $('html, body').animate({
        scrollTop: element.offsetTop
    }, 2000);
    }
  }*/
  
  mq=window.pageYOffset-deltarint;
  if(window.pageYOffset > m){
    OpenSlideUp();
  }else{

    CloseSlideUp();
  }
  if (window.pageYOffset > ref) {
    if(!deltar){
      if(mq<0){
        deltar = true;
        OpenState();
      }
    }
    if(mq>0){
      if(deltar_){
        DeltaHide();
        deltar_=false;
      }
    }else{
      if(!deltar_){
        deltar_=true;
        DeltaShow();
      }
    }

  } else {
    if(deltar){
      deltar = false;
      CloseState();      
    }
    if(!deltar_){
      deltar_= true;
      DeltaShow();
    }
  }
  deltarint=window.pageYOffset;


} 
