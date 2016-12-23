using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.Tags
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Tag")]
    public class TagInfo : IConceptInfo
    {
        [ConceptKey]
        public TagsInfo Tags { get; set; }
        [ConceptKey]
        public string Name { get; set; }
    }
}
