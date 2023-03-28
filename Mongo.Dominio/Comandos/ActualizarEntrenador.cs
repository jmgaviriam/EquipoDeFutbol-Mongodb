using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Dominio.Comandos
{
    public class ActualizarEntrenador
    {
        public string Id_Mongo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Pais { get; set; }
        public string EquipoId { get; set; }
    }
}
