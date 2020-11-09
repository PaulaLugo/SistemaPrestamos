using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Entity.Layer
{
    [DataContract]
    public class Operador
    {
        [DataMember]
        public List<Prestamo> Prestamos { get; set; }
       
        [DataMember]
        public double Comision { get => CalcularComisionTotal(); }
        
        [DataMember]
        public double PorcentajeComision { get; set; }

        double  CalcularComisionTotal()
        {
      
            var pp = Prestamos.Select(o => o.Monto * (o.TNA / 12 / 100)  );

            return pp.Sum() * PorcentajeComision;


        }
    }
}
