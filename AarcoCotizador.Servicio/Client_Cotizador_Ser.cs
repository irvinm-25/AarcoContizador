using AarcoCotizador.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AarcoCotizador.Servicio
{
    public class Client_Cotizador_Ser
    {
        private readonly string _UrlBase = System.Configuration.ConfigurationManager.AppSettings["UrlServicioAarco"];
        private readonly string OBTENER_CATALOGOS = "api/catalogos";

        //private readonly string OBTENER_GRABACIONES = "api/Llamada/Obtener_Grabaciones";
        public async Task<Catalogo_Marca_Mod> Obtener_Marcas(Catalogo_Request_Mod oParametros)
        {
            var cadenaIn = "AarcoCotizador.Servicio.Client_Cotizador_Ser.Obtener_Marcas() " + oParametros.ToString();
            var oResult = new Catalogo_Marca_Mod();
            try
            {
                var oResponse = await new Utileria_Ser().HttpClienteExec(oParametros, _UrlBase, OBTENER_CATALOGOS);
                if (oResponse.OperacionId == OperacionEnum.EXITO)
                {
                    var oResp = Newtonsoft.Json.JsonConvert.DeserializeObject<Catalogo_Response_Mod>(oResponse.Response);
                    oResult.Lista_Marcas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Marca_Mod>>(oResp.CatalogoJsonString);
                    if (oResp.Error != null)
                    {
                        oResult.OperacionId = OperacionEnum.ERROR;
                        oResult.OperacionDes = oResp.Error.iNumero + ": " + oResp.Error.sDescripcion;
                    }
                }
                else
                {
                    oResult.OperacionId = oResponse.OperacionId;
                    oResult.OperacionDes = oResponse.OperacionDes;
                }
            }
            catch (Exception ex)
            {
                //TODO: Guardar en Log
                oResult.OperacionId = OperacionEnum.ERROR;
                oResult.OperacionDes = "ERROR: AL INVOCAR EL SERVICIO";
            }
            return oResult;
        }
        public async Task<Catalogo_Submarca_Mod> Obtener_Submarcas(Catalogo_Request_Mod oParametros)
        {
            var cadenaIn = "AarcoCotizador.Servicio.Client_Cotizador_Ser.Obtener_Submarcas() " + oParametros.ToString();
            var oResult = new Catalogo_Submarca_Mod();
            try
            {
                var oResponse = await new Utileria_Ser().HttpClienteExec(oParametros, _UrlBase, OBTENER_CATALOGOS);
                if (oResponse.OperacionId == OperacionEnum.EXITO)
                {
                    var oResp = Newtonsoft.Json.JsonConvert.DeserializeObject<Catalogo_Response_Mod>(oResponse.Response);
                    oResult.Lista_Submarca = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SubMarca_Mod>>(oResp.CatalogoJsonString);
                    if (oResp.Error != null)
                    {
                        oResult.OperacionId = OperacionEnum.ERROR;
                        oResult.OperacionDes = oResp.Error.iNumero + ": " + oResp.Error.sDescripcion;
                    }
                }
                else
                {
                    oResult.OperacionId = oResponse.OperacionId;
                    oResult.OperacionDes = oResponse.OperacionDes;
                }
            }
            catch (Exception ex)
            {
                //TODO: Guardar en Log
                oResult.OperacionId = OperacionEnum.ERROR;
                oResult.OperacionDes = "ERROR: AL INVOCAR EL SERVICIO";
            }
            return oResult;
        }
        public async Task<Catalogo_Modelo_Mod> Obtener_Modelos(Catalogo_Request_Mod oParametros)
        {
            var cadenaIn = "AarcoCotizador.Servicio.Client_Cotizador_Ser.Obtener_Modelos() " + oParametros.ToString();
            var oResult = new Catalogo_Modelo_Mod();
            try
            {
                var oResponse = await new Utileria_Ser().HttpClienteExec(oParametros, _UrlBase, OBTENER_CATALOGOS);
                if (oResponse.OperacionId == OperacionEnum.EXITO)
                {
                    var oResp = Newtonsoft.Json.JsonConvert.DeserializeObject<Catalogo_Response_Mod>(oResponse.Response);
                    oResult.Lista_Modelo = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelo_Mod>>(oResp.CatalogoJsonString);
                    if (oResp.Error != null)
                    {
                        oResult.OperacionId = OperacionEnum.ERROR;
                        oResult.OperacionDes = oResp.Error.iNumero + ": " + oResp.Error.sDescripcion;
                    }
                }
                else
                {
                    oResult.OperacionId = oResponse.OperacionId;
                    oResult.OperacionDes = oResponse.OperacionDes;
                }
            }
            catch (Exception ex)
            {
                //TODO: Guardar en Log
                oResult.OperacionId = OperacionEnum.ERROR;
                oResult.OperacionDes = "ERROR: AL INVOCAR EL SERVICIO";
            }
            return oResult;
        }
        public async Task<Catalogo_DescripcionModelo_Mod> Obtener_DescripcionModelos(Catalogo_Request_Mod oParametros)
        {
            var cadenaIn = "AarcoCotizador.Servicio.Client_Cotizador_Ser.Obtener_DescripcionModelos() " + oParametros.ToString();
            var oResult = new Catalogo_DescripcionModelo_Mod();
            try
            {
                var oResponse = await new Utileria_Ser().HttpClienteExec(oParametros, _UrlBase, OBTENER_CATALOGOS);
                if (oResponse.OperacionId == OperacionEnum.EXITO)
                {
                    var oResp = Newtonsoft.Json.JsonConvert.DeserializeObject<Catalogo_Response_Mod>(oResponse.Response);
                    oResult.Lista_DescripcionModelo = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DescripcionModelo_Mod>>(oResp.CatalogoJsonString);
                    if (oResp.Error != null)
                    {
                        oResult.OperacionId = OperacionEnum.ERROR;
                        oResult.OperacionDes = oResp.Error.iNumero + ": " + oResp.Error.sDescripcion;
                    }
                }
                else
                {
                    oResult.OperacionId = oResponse.OperacionId;
                    oResult.OperacionDes = oResponse.OperacionDes;
                }
            }
            catch (Exception ex)
            {
                //TODO: Guardar en Log
                oResult.OperacionId = OperacionEnum.ERROR;
                oResult.OperacionDes = "ERROR: AL INVOCAR EL SERVICIO";
            }
            return oResult;
        }
        public async Task<Domicilio_Mod> Obtener_Domicilio(Catalogo_Request_Mod oParametros)
        {
            var cadenaIn = "AarcoCotizador.Servicio.Client_Cotizador_Ser.Obtener_Marcas() " + oParametros.ToString();
            var oResult = new Domicilio_Mod();
            try
            {
                var oResponse = await new Utileria_Ser().HttpClienteExec(oParametros, _UrlBase, OBTENER_CATALOGOS);
                if (oResponse.OperacionId == OperacionEnum.EXITO)
                {
                    var oResp = Newtonsoft.Json.JsonConvert.DeserializeObject<Catalogo_Response_Mod>(oResponse.Response);
                    if (!string.IsNullOrEmpty(oResp.CatalogoJsonString))
                    {
                        oResp.CatalogoJsonString = oResp.CatalogoJsonString.Substring(1, oResp.CatalogoJsonString.Length - 2);
                        oResult = Newtonsoft.Json.JsonConvert.DeserializeObject<Domicilio_Mod>(oResp.CatalogoJsonString);
                    }                    
                    if (oResp.Error != null)
                    {
                        oResult.OperacionId = OperacionEnum.ERROR;
                        oResult.OperacionDes = oResp.Error.iNumero + ": " + oResp.Error.sDescripcion;
                    }
                }
                else
                {
                    oResult.OperacionId = oResponse.OperacionId;
                    oResult.OperacionDes = oResponse.OperacionDes;
                }
            }
            catch (Exception ex)
            {
                //TODO: Guardar en Log
                oResult.OperacionId = OperacionEnum.ERROR;
                oResult.OperacionDes = "ERROR: AL INVOCAR EL SERVICIO";
            }
            return oResult;
        }
    }
}
