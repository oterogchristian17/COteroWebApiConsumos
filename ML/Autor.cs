﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Autor
    {

        public int IdAutor { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string? ApellidoMaterno { get; set; }

        public List<object> Autores { get; set; }


    }
}
