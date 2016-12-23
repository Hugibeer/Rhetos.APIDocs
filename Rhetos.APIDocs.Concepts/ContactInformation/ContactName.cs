using Rhetos.Dsl;
using System.ComponentModel.Composition;

namespace Rhetos.APIDocs.Concepts.ContactInformation
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Name")]
    public class ContactName : IConceptInfo
    {
        [ConceptKey]
        public ContactInfo Contact { get; set; }

        [ConceptKey]
        public string Name { get; set; }
    }
}
