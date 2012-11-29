/// <reference path="jquery-1.6.4-vsdoc.js" />
/// <reference path="jquery.signalR-1.0.0-alpha2.js" />

$(function() {

    var hub = $.connection.sendHub,
        $textBox = $("#myText"),
        $button = $("#send");

    $button.click(function() {

        hub.server.sendMessage($textBox.val());
        $textBox.val("").focus();

    });

    $.connection.hub.start();

});