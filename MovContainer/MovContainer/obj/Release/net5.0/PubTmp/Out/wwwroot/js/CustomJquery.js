$(document).ready(function () {
    var options = {
        translation: {
            A: { pattern: /[A-Z]/ },
            
        }
    }
    $("#cnumber").mask('AAAA000000-0', options );
})