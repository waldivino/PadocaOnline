﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PadocaWeb.Models
{
    public class Cliente
    {
        public Int32 id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
    }
}