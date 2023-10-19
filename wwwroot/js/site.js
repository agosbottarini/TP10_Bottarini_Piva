function MostrarTemporadas(IdS)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/ObtenerTemporadas',
            data: {IdSerie: IdS},
            success:
                function (response)
                {
                    console.log(response);
                   let texto= "";
                   for(let item of response)
                   {
                        texto += (item.numeroTemporada + ". " + item.tituloTemporada + "<br>");
                   }
                   $("#Info").html(texto);  
                }
        });
}

function MostrarActores(IdS)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/ObtenerActores',
            data: {IdSerie: IdS},
            success:
                function (response)
                {
                    console.log(response);
                    let texto ="";
                    for(let item of response)
                    {
                        texto += (item.nombre + "<br>")
                    }
                    $("#Info").html(texto);
                }
        });
}

function MostrarInfoSeries(IdS)
{
    $.ajax(
        {
            type:'POST',
            dataType:'JSON',
            url:'/Home/ObtenerInfoSeries',
            data: {IdSerie: IdS},
            success:
                function(response)
                {
                    console.log(response);
                    $("#Info").html(response.sinopsis);
                }
        });
}