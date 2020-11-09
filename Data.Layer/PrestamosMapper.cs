
using Entity.Layer;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Runtime.Serialization;

namespace Data.Layer
{
    public class PrestamosMapper
    {

        public static List<Prestamo> TraerPrestamos()
        {
            string json = WebHelper.Get("/prestamo/" + ConfigurationSettings.AppSettings["legajo"]); // trae un texto en formato json de una web
                                                                                                     // string json2 = WebHelper.Get("/cliente"); // trae un texto en formato json de una web

            List<Prestamo> resultado = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return resultado;
        }

        public static List<TipoPrestamo> TraerTipos()
        {
            string json = WebHelper.Get("/prestamotipo"); // trae un texto en formato json de una web

            return JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);

        }

        public static TransactionResult InsertPrestamo(Prestamo item)
        {
        
            NameValueCollection obj = ReverseMap(item);
            string result = WebHelper.Post("/prestamo", obj);

            TransactionResult resultadoTransaccion = JsonConvert.DeserializeObject<TransactionResult>(result);
            return resultadoTransaccion;
        }

        private static NameValueCollection ReverseMap(Prestamo item)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Cuota", item.Cuota.ToString());
            n.Add("Linea", item.Linea);
            n.Add("TNA", item.TNA.ToString());
            n.Add("Usuario", ConfigurationSettings.AppSettings["legajo"]);
            //n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("Plazo", item.Plazo.ToString()); // STRING
            n.Add("Monto", item.Monto.ToString()); // STRING

            return n;
        }

    }
}
