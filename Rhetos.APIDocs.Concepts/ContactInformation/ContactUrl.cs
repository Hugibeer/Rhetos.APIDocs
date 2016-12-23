using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.ContactInformation
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Url")]
    public class ContactUrl : IConceptInfo
    {
        [ConceptKey]
        public ContactInfo Contact { get; set; }
        [ConceptKey]
        public string Url { get; set; }
    }
}
