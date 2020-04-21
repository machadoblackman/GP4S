using GP4S.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP4S.Objectlayer.Document
{
    public class TituloEleitor : IDocumentIdentifier
    {
        public int ID { get; set; }
        public string NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; } = TipoDocumento.Título_de_Eleitor;
        public string Secao { get; set; }
        public string ZonaEleitoral { get; set; }
        public EnumEstados EstadoEmissor { get; set; }
    }
}
