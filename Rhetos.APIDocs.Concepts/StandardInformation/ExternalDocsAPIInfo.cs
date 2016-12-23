using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.StandardInformation
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("ExternalDocs")]
    public class ExternalDocsAPIInfo : IConceptInfo
    {
        [ConceptKey]
        public APIDocsInfo APIDocs { get; set; }

        [ConceptKey]
        public string Description { get; set; }

        [ConceptKey]
        public string ExternalUrl { get; set; }
    }
}
