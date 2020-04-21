using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP4S.Objectlayer.Document
{
    public class CarteiraProfissional : IDocumentIdentifier
    {
        public int ID { get; set; }
        public string NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; } = TipoDocumento.Carteira_Profissional;
        public string NumSerie { get; set; }
        public DateTime DataEmissao { get; set; }

    }
}
