using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Timor-Leste
    /// </summary>
    public class TimorLesteCountryInfo : ICountryInfo
    {
        public string CommonName => "Timor-Leste";
        public string OfficialName => "Democratic Republic of Timor-Leste";
        public Alpha2Code Alpha2Code => Alpha2Code.TL;
        public Alpha3Code Alpha3Code => Alpha3Code.TLS;
        public int NumericCode => 626;
        public string[] TLD => new [] { ".tl" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ID,
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "670" };
    }
}
