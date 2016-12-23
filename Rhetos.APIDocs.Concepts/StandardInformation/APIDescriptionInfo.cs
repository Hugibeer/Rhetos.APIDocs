using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.StandardInformation
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Description")]
    public class APIDescriptionInfo : IConceptInfo
    {
        [ConceptKey]
        public APIDocsInfo Application { get; set; }

        [ConceptKey]
        public string Description { get; set; }
    }
}
