using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.StandardInformation
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("License")]
    public class LicenseInfo : IConceptInfo
    {
        [ConceptKey]
        public APIDocsInfo APIDocs { get; set; }
        [ConceptKey]
        public string Name { get; set; }
        [ConceptKey]
        public string Url { get; set; }
    }
}
