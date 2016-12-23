using Rhetos.APIDocs.Concepts.StandardInformation;
using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.ContactInformation
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Contact")]
    public class ContactInfo : IConceptInfo
    {
        [ConceptKey]
        public APIDocsInfo APIDocs { get; set; }
    }
}
