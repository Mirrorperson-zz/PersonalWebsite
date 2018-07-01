jQuery(document).ready(function ($) {

    // OwlCarousel
    $(".owl-carousel").owlCarousel({
        navigation: true, // Show next and prev buttons
        slideSpeed: 300,
        paginationSpeed: 400,
        singleItem: true
    });

    var windowXArray = [],
        windowYArray = [];

    for (var width = 0; width < $(window).innerWidth(); width++) {
        windowXArray.push(width);
    }

    for (var height = 0; height < $(window).innerHeight(); height++) {
        windowYArray.push(height);
    }

    function randomPlacement(array) {
        var placement = array[Math.floor(Math.random() * array.length)];
        return placement;
    }


    var canvas = oCanvas.create({
        canvas: '#canvas',
        background: '#A2B9D2',
        fps: 60
    });

    setInterval(function () {

        var rectangle = canvas.display.ellipse({
            x: randomPlacement(windowXArray),
            y: randomPlacement(windowYArray),
            origin: { x: 'center', y: 'center' },
            radius: 0,
            fill: '#27ae60',
            opacity: 1
        });

        canvas.addChild(rectangle);

        rectangle.animate({
            radius: 10,
            opacity: 0
        }, {
            duration: '1000',
            easing: 'linear',
            callback: function () {
                this.remove();
            }
        });

    }, 100);

    $(window).resize(function () {
        canvas.width = $(window).innerWidth();
        canvas.height = $(window).innerHeight();
    });

    $(window).resize();

});