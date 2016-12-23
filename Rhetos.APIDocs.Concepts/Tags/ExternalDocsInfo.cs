using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.Tags
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("ExternalDocs")]
    public class ExternalDocsInfo : IConceptInfo
    {
        [ConceptKey]
        public TagInfo Tag { get; set; }

        [ConceptKey]
        public string Description { get; set; }

        [ConceptKey]
        public string ExternalUrl { get; set; }
    }
}
