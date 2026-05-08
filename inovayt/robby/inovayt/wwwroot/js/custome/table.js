
function showAsset(element)
{
    $(".asset-class").hide();
    var id = $(element).data().id;
    $("." + id).show();
}
$(document).ready(function ()
{
    $(".asset-class").hide();
    $('.table-link-asset').on('click', function () { showAsset(this); });
});

