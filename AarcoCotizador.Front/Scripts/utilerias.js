
function requestAjax(url, type, data, funcionRespuestaExito, funcionRespuestaError) {
    $.ajax({
        url: url,
        type: type,
        data: JSON.stringify(data),
        contentType: "application/json",
        dataType: 'json',
        success: funcionRespuestaExito,        
        error: funcionRespuestaError
    });
}