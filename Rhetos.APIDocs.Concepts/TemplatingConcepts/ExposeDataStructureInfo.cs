using Rhetos.APIDocs.Concepts.StandardInformation;
using Rhetos.Dsl;
using Rhetos.Dsl.DefaultConcepts;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.TemplatingConcepts
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Expose")]
    public class ExposeDataStructureInfo : IConceptInfo
    {
        [ConceptKey]
        public APIDocsInfo APIDocs { get; set; }

        [ConceptKey]
        public DataStructureInfo Structure { get; set; }
    }
}
