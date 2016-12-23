/*main silder js*/

$(document).ready(function () {


    $('.ws-slider').slick({
        autoplay: true,
        arrows: true,
        dots: false,
        infinite: false,
        speed: 300,
        slidesToShow: 4,
        slidesToScroll: 4,
        adaptiveHeight: true,
        responsive: [
          {
              breakpoint: 1024,
              settings: {
                  slidesToShow: 3,
                  slidesToScroll: 3,
                  infinite: true,
                  dots: true
              }
          },
          {
              breakpoint: 600,
              settings: {
                  slidesToShow: 2,
                  slidesToScroll: 2
              }
          },
          {
              breakpoint: 480,
              settings: {
                  slidesToShow: 1,
                  slidesToScroll: 1
              }
          }

        ]
    });



    $("#scroll-logos").simplyScroll();


    /**
      Modified by William
    */

    $('.offer-img, .offer-box2').mouseenter(function () {
        $(this).parents('.offer-card').addClass('rotate');
    });

    $('.offer-card').mouseleave(function () {
        $(this).removeClass('rotate');
    });


    // ----- TILE -----
    $(".card-back .offer-box2").click(function () {
        $(".added-case:not(#" + $(this).data("added-case") + ")").hide();

        $("#" + $(this).data("added-case")).toggle(500);
    });
    // ----- TILE -----

});




