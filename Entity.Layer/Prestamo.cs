using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Entity.Layer
{
    [DataContract]
    public class Prestamo
    {

        public Prestamo()
        {
            _tipo = new TipoPrestamo();
        }
        private TipoPrestamo _tipo;


        [DataMember]
        public string Linea
        {
            get { return _tipo.Linea;}
            set { _tipo.Linea = value; }
           
        }

        [DataMember]
        public double TNA { get => _tipo.TNA; set => _tipo.TNA = value; }


        [DataMember]
        public double Monto { get; set; }
        [DataMember]
        public int Plazo { get; set; }
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string Usuario { get; set; }
        

        public TipoPrestamo tipoPrestamo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }


        public double CuotaCapital
        {
            get { return Monto/Plazo; }
        }

        public double CuotaInteres
        {
            get { return CuotaCapital * (TNA / 12 / 100); }
        }

        public double Cuota
        {
            get { return CuotaCapital + CuotaInteres; }
        }

        public override string ToString()
        {
            return string.Format($"linea: {Linea}  Monto:{Monto}  Plazo: {Plazo}" ) ;
        }
    }
}
