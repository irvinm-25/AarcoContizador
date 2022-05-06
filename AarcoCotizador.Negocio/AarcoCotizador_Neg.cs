using AarcoCotizador.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AarcoCotizador.Negocio
{
    public class AarcoCotizador_Neg
    {
        public async Task<Catalogo_Marca_Mod> Obtener_Marcas()
        {
            return await new Servicio.Client_Cotizador_Ser().Obtener_Marcas(new Catalogo_Request_Mod()
            {
                NombreCatalogo = "Marca",
                Filtro = 1,
                IdAplication = 2
            });            

        }
        public async Task<Catalogo_Submarca_Mod> Obtener_Submarcas(int Filtro)
        {
            return await new Servicio.Client_Cotizador_Ser().Obtener_Submarcas(new Catalogo_Request_Mod()
            {
                NombreCatalogo = "Submarca",
                Filtro = Filtro,
                IdAplication = 2
            });
        }
        public async Task<Catalogo_Modelo_Mod> Obtener_Modelo(int Filtro)
        {
            return await new Servicio.Client_Cotizador_Ser().Obtener_Modelos(new Catalogo_Request_Mod()
            {
                NombreCatalogo = "Modelo",
                Filtro = Filtro,
                IdAplication = 2
            });
        }
        public async Task<Catalogo_DescripcionModelo_Mod> Obtener_DescripcionModelo(int Filtro)
        {
            return await new Servicio.Client_Cotizador_Ser().Obtener_DescripcionModelos(new Catalogo_Request_Mod()
            {
                NombreCatalogo = "DescripcionModelo",
                Filtro = Filtro,
                IdAplication = 2
            });
        }

        public async Task<Domicio_ViewModel_Mod> Obtener_Domicilio(int Filtro)
        {
            var oResult = new Domicio_ViewModel_Mod();
            var domicilio = await new Servicio.Client_Cotizador_Ser().Obtener_Domicilio(new Catalogo_Request_Mod()
            {
                NombreCatalogo = "Sepomex",
                Filtro = Filtro,
                IdAplication = 2
            });

            if (domicilio != null && domicilio.Municipio != null && domicilio.Ubicacion != null)
            {
                oResult.Estado = domicilio.Municipio.Estado.sEstado;
                oResult.Municipio = domicilio.Municipio.sMunicipio;
                oResult.Colonia = domicilio.Ubicacion.FirstOrDefault().sUbicacion;
            }
            return oResult;
        }
    }
}