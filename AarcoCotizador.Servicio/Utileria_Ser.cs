using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using AarcoCotizador.Modelo;

namespace AarcoCotizador.Servicio
{
    public class Utileria_Ser
    {
        public async Task<Operacion_Response_Mod> HttpClienteExec<T>(T requestDatos, string requestUrlBase, string requestUrlAccion)
        {
            var oResult = new Operacion_Response_Mod();
            try
            {
                using (var _Client = new HttpClient())
                {
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                    //Configuracion
                    _Client.BaseAddress = new Uri(requestUrlBase);
                    _Client.DefaultRequestHeaders.Accept.Clear();
                    _Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    _Client.Timeout = new TimeSpan(0, 0, 35);
                    HttpResponseMessage response = await _Client.PostAsJsonAsync(requestUrlAccion, requestDatos);

                    if (response.IsSuccessStatusCode)
                    {
                        oResult.Response = await response.Content.ReadAsStringAsync();
                        oResult.OperacionId = OperacionEnum.EXITO;
                    }
                    else
                    {
                        oResult.OperacionId = OperacionEnum.ERROR;
                        oResult.OperacionDes = "ERROR: 500 AL INVOCAR EL SERVICIO";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("AarcoCotizador.Servicio.Utileria_Ser.HttpClienteExec() |Error:" + ex.ToString());
            }          
            return oResult;
        }
    }
}
