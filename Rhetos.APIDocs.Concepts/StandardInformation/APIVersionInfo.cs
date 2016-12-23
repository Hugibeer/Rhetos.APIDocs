using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.StandardInformation
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Version")]
    public class APIVersionInfo : IConceptInfo
    {
        [ConceptKey]
        public APIDocsInfo Application { get; set; }

        [ConceptKey]
        public string Version { get; set; }
    }
}
