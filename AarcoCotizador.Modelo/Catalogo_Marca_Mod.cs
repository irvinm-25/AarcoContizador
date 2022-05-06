using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AarcoCotizador.Modelo
{
    public class Catalogo_Marca_Mod: Operacion_Mod
    {
        public List<Marca_Mod> Lista_Marcas { get; set; }
        public Catalogo_Marca_Mod()
        {          
        }
    }
    public class Catalogo_Submarca_Mod : Operacion_Mod
    {
        public List<SubMarca_Mod> Lista_Submarca { get; set; }
        public Catalogo_Submarca_Mod()
        {
        }
    }
    public class Catalogo_Modelo_Mod : Operacion_Mod
    {
        public List<Modelo_Mod> Lista_Modelo { get; set; }
        public Catalogo_Modelo_Mod()
        {
        }
    }

    public class Catalogo_DescripcionModelo_Mod : Operacion_Mod
    {
        public List<DescripcionModelo_Mod> Lista_DescripcionModelo { get; set; }
        public Catalogo_DescripcionModelo_Mod()
        {
        }
    }
}