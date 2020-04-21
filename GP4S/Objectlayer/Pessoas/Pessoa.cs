using GP4S.Objectlayer.Document;
using GP4S.Objectlayer.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace GP4S.Objectlayer.Pessoas
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string NomePessoa { get; set; }
        public List<Papel> Papeis { get; set; }
        public List<IDocumentIdentifier> Documentos { get; set; }
        public EnumNaturezaJuridica NaturezaJuridica { get; set; }
    }
}
