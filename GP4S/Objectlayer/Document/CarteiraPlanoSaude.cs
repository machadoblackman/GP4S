using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP4S.Objectlayer.Document
{
    public class CarteiraPlanoSaude : IDocumentIdentifier
    {
        public int ID { get; set; }
        public string NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NomeTitular { get; set; }
        public string NomeBeneficiario { get; set; }
        public DateTime DataValidade { get; set; }

    }
}
