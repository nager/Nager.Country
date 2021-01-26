using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Panama
    /// </summary>
    public class PanamaCountryInfo : ICountryInfo
    {
        public string CommonName => "Panama";
        public string OfficialName => "Republic of Panama";
        public Alpha2Code Alpha2Code => Alpha2Code.PA;
        public Alpha3Code Alpha3Code => Alpha3Code.PAN;
        public int NumericCode => 591;
        public string[] TLD => new [] { ".pa" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CO,
            Alpha2Code.CR,
        };

        public ICurrency[] Currencies => new ICurrency[] { new PabCurrency(), new UsdCurrency() };
        public string[] CallingCodes => new [] { "507" };
    }
}
