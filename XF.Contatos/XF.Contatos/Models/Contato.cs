using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.Contatos.Models
{
    public class Contato
    {
        public Uri Imagem { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }

        public static List<Contato> GetAll()
        {
            return new List<Contato>();
        }
    }
}
