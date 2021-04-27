console.log("Index.js Working!");

$(function() {

    //Active State Nav Link by URL
    $('nav a[href^="/' + location.pathname.split("/")[1] + '"]').addClass('active');
});