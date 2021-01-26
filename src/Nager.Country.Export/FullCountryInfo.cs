using Nager.Country.Translation;

namespace Nager.Country.Export
{
    public class FullCountryInfo
    {
        public string CommonName { get; set; }
        public string OfficialName { get; set; }
        public Alpha2Code Alpha2Code { get; set; }
        public Alpha3Code Alpha3Code { get; set; }
        public int NumericCode { get; set; }
        public string[] TLD { get; set; }
        public Region Region { get; set; }
        public SubRegion SubRegion { get; set; }
        public Alpha2Code[] BorderCountries { get; set; }
        public ICurrency[] Currencies { get; set; }
        public string[] CallingCodes { get; set; }

        public TranslationInfo[] Translations { get; set; }
    }
}
