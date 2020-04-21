using GP4S.Objectlayer.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP4S.Objectlayer.Document
{
    public class CarteiraClube : IDocumentIdentifier
    {
        public int ID { get; set; }
        public string NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; } = TipoDocumento.Carteira_de_Clube;
        public string TipoSocio { get; set; }
        public string NomeTitular { get; set; }
        public DateTime DtAdmissao { get; set; }


    }
}
