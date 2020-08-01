$('.pagination li a').on('click', function (e) {
    e.preventDefault();
    var a = $(this).html();
    console.log(a);
    $.ajax({
        type: 'POST',
        contentType: 'application/json',
        cache: false,
        url: '@Url.Action("TatCaDonHang", "Soonnoc")',
        data: JSON.stringify({ 'page': $(this).html() }),

        beforeSend: function (xhr) {

        },
        //success: function (result) {
        //    console.log(result);
        //    $('.tbody').empty();
        //    $('tbody').html(result);
        //    //location.reload(result);
        //    //renderMySubordinateJobTable();
        //},
        error: function (xhr) {
        },
        complete: function (xhr) {
        }
    });
});