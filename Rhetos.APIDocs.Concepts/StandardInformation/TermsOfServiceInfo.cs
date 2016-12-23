using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.StandardInformation
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("TermsOfService")]
    public class TermsOfServiceInfo : IConceptInfo
    {
        [ConceptKey]
        public APIDocsInfo APIDocs { get; set; }
        [ConceptKey]
        public string TermsOfService { get; set; }
    }
}
