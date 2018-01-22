﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientesWebApi.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public int Edad { get; set; }

        public string Rut { get; set; }

        public int? CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        public List<Gusto> Gustos { get; set; }

        
    }
}