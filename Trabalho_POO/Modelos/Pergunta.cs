using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO.Modelos
{
    public class Pergunta
    {
        public int Id { get; set; }
        public string PerguntaTexto { get; set; }
        public string RespostaCerta { get; set; }
        public string RespostaErrada1 { get; set; }
        public string RespostaErrada2 { get; set; }
        public string RespostaErrada3 { get; set; }
        public string RespostaErrada4 { get; set; }
    }
}
