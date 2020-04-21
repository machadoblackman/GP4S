using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP4S.Objectlayer.Document
{
    public class Passaporte : IDocumentIdentifier
    {
        public int ID { get; set; }
        public string NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; } = TipoDocumento.Passaporte;
        public string PaisEmissor { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataEmissao { get; set; }
        public string OrgaoEmissor { get; set; }
        public string LocalEmissao { get; set; }
        public DateTime DataValidade { get; set; }

    }
}
