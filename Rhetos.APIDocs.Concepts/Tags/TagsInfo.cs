using Rhetos.APIDocs.Concepts.StandardInformation;
using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.Tags
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Tags")]
    public class TagsInfo : IConceptInfo
    {
        [ConceptKey]
        public APIDocsInfo APIDocs { get; set; }
    }
}
