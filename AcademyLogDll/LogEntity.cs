using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLogDll
{
    public class LogEntity
    {
        public int id { get; set; }
        public string aplicacion { get; set; }
        public string mensaje { get; set; }
        public System.DateTime fecha { get; set; }
    }
}
