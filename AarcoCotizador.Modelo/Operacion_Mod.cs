using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AarcoCotizador.Modelo
{
    public enum OperacionEnum { ERROR = 0, EXITO, NOEJECUTADO }
    public class Operacion_Mod
    {
        private string _operacionDes;
        public OperacionEnum OperacionId { get; set; }
        public string OperacionDes
        {
            get { return _operacionDes; }
            set { _operacionDes = (value == null) ? string.Empty : value.ToString().ToUpper(); }
        }
        
        public Operacion_Mod()
        {
            OperacionId = OperacionEnum.NOEJECUTADO;
        }

        public override string ToString()
        {
            return "|OperacionId:" + OperacionId + "|OperacionDes:" + OperacionDes;
        }
    }
}