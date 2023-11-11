using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaApi.Usuario
{
    public class Usuarios
    {
        public Usuarios()
        {
            Id = Guid.NewGuid();
            Data = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; } 
    }
}