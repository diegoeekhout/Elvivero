using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elvivero.Models
{
    public class Planta
    {
        public int PlantaId { get; set; }
        public string Nombre { get; set; }
        public ICollection<Tipo> Tipos { get; set; }

    }
}
