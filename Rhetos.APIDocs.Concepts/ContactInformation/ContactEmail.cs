using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.ContactInformation
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Email")]
    public class ContactEmail : IConceptInfo
    {
        [ConceptKey]
        public ContactInfo Contact { get; set; }
        [ConceptKey]
        public string Email { get; set; }
    }
}
