﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Dominio.Comandos
{
    public class AgregarJugador
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Posicion { get; set; }
        public int NumeroCamiseta { get; set; }
        public int EquipoId { get; set; }
    }
}
