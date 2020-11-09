using Data.Layer;
using Entity.Layer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Layer
{
    public class PrestamosServicies
    {



        public static List<Prestamo> TraerPrestamos()
        {

            return PrestamosMapper.TraerPrestamos();
        }

        public static List<TipoPrestamo> TraerTipos()
        {
            string json = WebHelper.Get("/prestamotipo"); // trae un texto en formato json de una web

            return JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);

        }

        public static TransactionResult InsertPrestamo(Prestamo item)
        {
            //var ret =PrestamosMapper.TraerPrestamos();



            return PrestamosMapper.InsertPrestamo(item);

        }

        public static void CalcularComision()
        {

        }

    }
}

