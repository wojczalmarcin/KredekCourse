
using System.ComponentModel;

namespace MarcinWojczalUniveristyFacultyEF.ViewModels
{
    /// <summary>
    /// Klasa reprezentująca widok z tabeli Adresses
    /// </summary>
    class AddressViewModel
    {
        public int Id { get; set; }
        [DisplayName("Kraj")]
        public string Country { get; set; }
        [DisplayName("Miasto")]
        public string City { get; set; }
        [DisplayName("Kod pocztowy")]
        public string PostCode { get; set; }
        [DisplayName("Ulica")]
        public string Street { get; set; }
        [DisplayName("Numer")]
        public int Number { get; set; }
    }
}
