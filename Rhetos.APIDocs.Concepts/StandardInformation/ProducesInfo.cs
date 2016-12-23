using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.StandardInformation
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Produces")]
    public class ProducesInfo : IConceptInfo
    {
        [ConceptKey]
        public APIDocsInfo APIDocs { get; set; }

        [ConceptKey]
        public string Produces { get; set; }
    }
}
