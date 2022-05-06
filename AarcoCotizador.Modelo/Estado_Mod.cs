using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AarcoCotizador.Modelo
{
    public class Estado_Mod
    {
        public int iIdEstado { get; set; }
        public object Pais { get; set; }
        public int iEstadoPais { get; set; }
        public int iClaveEstadoCepomex { get; set; }
        public string sEstado { get; set; }
    }
    public class Municipio
    {
        public int iIdMunicipio { get; set; }
        public Estado_Mod Estado { get; set; }
        public int iMunicipioEstado { get; set; }
        public int iClaveMunicipioCepomex { get; set; }
        public string sMunicipio { get; set; }
    }

    public class Ubicacion
    {
        public int iIdUbicacion { get; set; }
        public object CodigoPostal { get; set; }
        public int iUbicacionCodigoPostal { get; set; }
        public object TipoUbicacion { get; set; }
        public int iClaveUbicacionCepomex { get; set; }
        public object Ciudad { get; set; }
        public string sUbicacion { get; set; }
    }

    public class CatalogoJsonString : Operacion_Mod
    {
        public Municipio Municipio { get; set; }
        public List<Ubicacion> Ubicacion { get; set; }
    }
    
    public class Domicilio_Mod: Operacion_Mod
    {
        public Municipio Municipio { get; set; }
        public List<Ubicacion> Ubicacion { get; set; }
    }
    public class Domicio_ViewModel_Mod
    {
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }
    }
}