using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.StandardInformation
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("APIDocs")]
    public class APIDocsInfo : IConceptInfo
    {
        [ConceptKey]
        public string ApplicationName { get; set; }
    }
}
