$(document).ready(function(){
    var $currentAlgorithm;

    var events = {
    	initialize : function() {}
    };

    $("#workarea").nextAll().not("script").css("display", "none");

    //$("li.start").siblings().css({"color": "red", "border": "2px solid red"});

    events.initialize = (function(){
    	$("#btnGroupDekker>button, #btnGroupPeterson>button").each(function(){
    		var $this = $(this);

    		console.log($this);
    	});

    })();

});