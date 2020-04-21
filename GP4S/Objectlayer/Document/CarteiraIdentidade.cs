using GP4S.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP4S.Objectlayer.Document
{
    public class CarteiraIdentidade : IDocumentIdentifier
    {
        public int ID { get; set; }
        public string NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; } = TipoDocumento.Carteira_de_Identidade;
        DateTime DataEmissao { get; set; }
        public EnumEstados EstadoEmissor { get; set; }
        public string OrgaoEmissor { get; set; }
        
    }
}
