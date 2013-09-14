using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            //return "Data Source=.\\SQLEXPRESS;Initial Catalog=BD_Asesores;Integrated Security=SSPI;";
            return "Data Source=036e9822-d8d1-4590-ab70-a2390059d746.sqlserver.sequelizer.com;Initial Catalog=db036e9822d8d14590ab70a2390059d746;User Id=fvqihuivygnjycpk;Password=H4fyZ6MZcu8nuAoXy5AdTx5akif7tECDDCJr3wLqmUr6XhEFcQ5aNGMj7foQYPEE";
        }

    }
}