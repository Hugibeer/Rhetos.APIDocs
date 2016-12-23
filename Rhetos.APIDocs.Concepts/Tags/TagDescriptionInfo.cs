using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.Tags
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Description")]
    public class TagDescriptionInfo : IConceptInfo
    {
        [ConceptKey]
        public TagInfo Tag { get; set; }

        [ConceptKey]
        public string Description { get; set; }
    }
}
