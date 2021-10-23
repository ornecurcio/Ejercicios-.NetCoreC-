﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionFechaInvalida:Exception
    {
        public ExcepcionFechaInvalida(string mensaje, Exception innerException)
               :base(mensaje, innerException)
        { }
        public ExcepcionFechaInvalida(string mensaje)
               : this(mensaje,null)
        { }
    }
}
