$(function(){
    $("[data-toggle='tooltip']").tooltip();
    $("[data-toggle='popover']").popover();
    $('.carousel').carousel({
        interval: 2500
    });
    $('#datosReserva').on('show.bs.modal', function(e){
        console.log('el modal se está mostrando');
        $('btnReserva').removeClass('btn-primary');                
        $('btnReserva').removeClass('btn-reserva');
       /* $('btnReserva').addClass('btn-outline-success');*/
        $('btnReserva').prop('disabled',true);
    });
    $('#datosReserva').on('show.bs.modal', function(e){
        console.log('el modal se mostró');
    });
    $('#datosReserva').on('hide.bs.modal', function(e){
        console.log('el modal se oculta');
        $('btnReserva').removeClass('btn-outline-success');
        $('btnReserva').addClass('btn-primary');
        $('btnReserva').addClass('btn-reserva');
    });
    $('#datosReserva').on('hidden.bs.modal', function(e){
        console.log('el modal se ocultó');
        $('btnReserva').prop('disabled',false);
    });
})