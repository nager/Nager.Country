using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Faroe Islands
    /// </summary>
    public class FaroeIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Faroe Islands";
        public string OfficialName => "Faroe Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.FO;
        public Alpha3Code Alpha3Code => Alpha3Code.FRO;
        public int NumericCode => 234;
        public string[] TLD => new [] { ".fo" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new DkkCurrency() };
        public string[] CallingCodes => new [] { "298" };
    }
}
