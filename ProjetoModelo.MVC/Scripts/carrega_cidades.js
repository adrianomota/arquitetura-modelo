$(document).ready(function () {
       $("#CidadeId :gt(0)").remove();

        $("#EstadoId").change(function() {
            listaCidadePorUf($(this).val());
        });
    });

function listaCidadePorUf(uf) {
    var url = $('#urlCidade').data('request-url') + '/' + uf;
    $.ajax({
        url: url,
        dataType: 'json',
        success: function (retorno) {

            $("#CidadeId :gt(0)").remove();

            $.each(retorno, function() {
                var cidade = this;
                $("#CidadeId").append("<option value='" + cidade.CidadeId + "'>" + cidade.Nome + "</option>");

            });
        }
    });
}

