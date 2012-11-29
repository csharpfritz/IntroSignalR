/// <reference path="jquery-1.8.2.intellisense.js" />
/// <reference path="jquery-ui-1.9.0.js" />
/// <reference path="jquery.signalR-1.0.0-alpha2.js" />

$(function() {

    var hub = $.connection.moveShape,
        $shape = $("#shape");

    hub.client.shapeMoved = function(cid, x, y) {
        if (cid !== $.connection.hub.id) {
            $shape.css({ left: x, top: y });
        }
    };
    

    $.connection.hub.start().done(function() {

        $shape.draggable({
            drag: function() {
                hub.server.moveShape(this.offsetLeft, this.offsetTop || 0);
            }
        });

    });

});