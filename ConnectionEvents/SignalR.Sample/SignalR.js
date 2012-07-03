    /// <reference path="../scripts/jquery-1.7.2.js" />
    /// <reference path="../scripts/jquery.signalR-0.5.2.js" />



$(function () {

    var ticker = $.connection.myHub;

    function init() {
        return ticker.getString().done(function (aString) {
            
        });
    }

    // Add client-side hub methods that the server will call
    ticker.Anyoldfunctionname = function () {


    };




    // Start the connection
    $.connection.hub.start()
            .done(function () {
                return init();
            });



});