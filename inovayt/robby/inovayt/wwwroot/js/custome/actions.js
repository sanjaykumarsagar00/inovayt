
$(document).ready(function () {
    if ($('#hidevalue').val() == "0") {
        $('.partialviewusers').show();
        $('.partialviewasset').hide();

        $('.user-per').show();
        $('.asset-per').hide();
    }

    $("#btn-next").click(function () {
        var hidevalue = $('#hidevalue').val();
        if (hidevalue == "0") {
            $('.partialviewusers').hide();
            $('.partialviewasset').show();

            $('.user-per').hide();
            $('.asset-per').show();

            $('#hidevalue').val("1");
        }
        if (hidevalue == "1") {
            $('.partialviewusers').hide();
            $('.partialviewasset').show();
          
            $('.asset-per').show();
            $('.user-per').hide();
         
            $('#hidevalue').val("2");
        }
    });

    $("#btn-back").click(function () {
        var hidevalue = $('#hidevalue').val();
        if (hidevalue == "1") {
            $('.partialviewasset').hide();
            $('.partialviewusers').show();

            $('.asset-per').hide();
            $('.user-per').show();

            $('#hidevalue').val("0");
        }
        if (hidevalue == "2") {
            $('.partialviewasset').hide();
            $('.partialviewusers').show();

            $('.asset-per').hide();
            $('.user-per').show();

            $('#hidevalue').val("0");
        }
    });
});

