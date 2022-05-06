using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AarcoCotizador.Modelo
{
    public class Catalogo_Request_Mod
    {        
        public int IdAplication { get; set; }
        public string NombreCatalogo { get; set; }
        public int Filtro { get; set; }
    }

    public class Error_Response_Mod
    {
        public int iNumero { get; set; }
        public string sDescripcion { get; set; }
    }
    public class Catalogo_Response_Mod
    {
        public string CatalogoJsonString { get; set; }
        public Error_Response_Mod Error { get; set; }
        public Catalogo_Response_Mod()
        {        
        }
    }
}
