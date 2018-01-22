﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientesWebApi.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public List<Cliente> Clientes { get; set; }
        
    }
}