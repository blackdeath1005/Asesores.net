﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAPServices
{
    public class Logo : ILogo
    {
        public string ObtenerLogo()
        {
            return "Universidad de Ciencias Aplicadas";
        }

    }
}
