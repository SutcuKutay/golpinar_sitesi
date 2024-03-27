$(document).ready(function(){
	"use strict";
    
        /*==================================
* Author        : "ThemeSine"
* Template Name : Khanas HTML Template
* Version       : 1.0
==================================== */



/*=========== TABLE OF CONTENTS ===========
1. Scroll To Top 
2. Smooth Scroll spy
3. Progress-bar
4. owl carousel
5. welcome animation support
======================================*/

    // 1. Scroll To Top 
		$(window).on('scroll',function () {
			if ($(this).scrollTop() > 600) {
				$('.return-to-top').fadeIn();
			} else {
				$('.return-to-top').fadeOut();
			}
		});
		$('.return-to-top').on('click',function(){
				$('html, body').animate({
				scrollTop: 0
			}, 1500);
			return false;
		});
	
	
	
	// 2. Smooth Scroll spy
		
		$('.header-area').sticky({
           topSpacing:0
        });
		
		//=============

		$('li.smooth-menu a').bind("click", function(event) {
			event.preventDefault();
			var anchor = $(this);
			$('html, body').stop().animate({
				scrollTop: $(anchor.attr('href')).offset().top - 0
			}, 1200,'easeInOutExpo');
		});
		
		$('body').scrollspy({
			target:'.navbar-collapse',
			offset:0
		});

	// 3. Progress-bar
	
		var dataToggleTooTip = $('[data-toggle="tooltip"]');
		var progressBar = $(".progress-bar");
		if (progressBar.length) {
			progressBar.appear(function () {
				dataToggleTooTip.tooltip({
					trigger: 'manual'
				}).tooltip('show');
				progressBar.each(function () {
					var each_bar_width = $(this).attr('aria-valuenow');
					$(this).width(each_bar_width + '%');
				});
			});
		}
	
	// 4. owl carousel
	
		// i. client (carousel)
		
			$('#client').owlCarousel({
				items:7,
				loop:true,
				smartSpeed: 1000,
				autoplay:true,
				dots:false,
				autoplayHoverPause:true,
				responsive:{
						0:{
							items:2
						},
						415:{
							items:2
						},
						600:{
							items:4

						},
						1199:{
							items:4
						},
						1200:{
							items:7
						}
					}
				});
				
				
				$('.play').on('click',function(){
					owl.trigger('play.owl.autoplay',[1000])
				})
				$('.stop').on('click',function(){
					owl.trigger('stop.owl.autoplay')
				})


    // 5. welcome animation support

        $(window).load(function(){
        	$(".header-text h2,.header-text p").removeClass("animated fadeInUp").css({'opacity':'0'});
            $(".header-text a").removeClass("animated fadeInDown").css({'opacity':'0'});
        });

        $(window).load(function(){
        	$(".header-text h2,.header-text p").addClass("animated fadeInUp").css({'opacity':'0'});
            $(".header-text a").addClass("animated fadeInDown").css({'opacity':'0'});
        });
        
    // 6. image modal
    
    	// Get the modal
	var modal = document.getElementById("myModal");

	// Get the images that opens the modal
	var resim1 = document.getElementById("resim-1");
	var resim2 = document.getElementById("resim-2");
	var resim3 = document.getElementById("resim-3");
	var resim4 = document.getElementById("resim-4");
	var resim5 = document.getElementById("resim-5");

	// Get the <span> element that closes the modal
	var span = document.getElementsByClassName("close")[0];

	// When the user clicks the button, open the modal 
	resim1.onclick = function() {
		document.getElementById("modal-image").src = "assets/images/golpinar/golpinar-havuz-3.jpg";
	  	modal.style.display = "block";
	}
	
	resim2.onclick = function() {
		document.getElementById("modal-image").src = "assets/images/golpinar/golpinar-havuz-4.jpg";
	  	modal.style.display = "block";
	}
	
	resim3.onclick = function() {
		document.getElementById("modal-image").src = "assets/images/golpinar/golpinar-gol.jpg";
	  	modal.style.display = "block";
	}
	
	resim4.onclick = function() {
		document.getElementById("modal-image").src = "assets/images/golpinar/golpinar-kar-1.jpg";
	  	modal.style.display = "block";
	}
	
	resim5.onclick = function() {
		document.getElementById("modal-image").src = "assets/images/golpinar/golpinar-toplanti.jpg";
	  	modal.style.display = "block";
	}

	// When the user clicks on <span> (x), close the modal
	span.onclick = function() {
		document.getElementById("modal-image").src = "";
	  	modal.style.display = "none";
	}

	// When the user clicks anywhere outside of the modal, close it
	window.onclick = function(event) {
	  if (event.target == modal) {
	  	document.getElementById("modal-image").src = "";
	    	modal.style.display = "none";
	  }
	}
});	
	
