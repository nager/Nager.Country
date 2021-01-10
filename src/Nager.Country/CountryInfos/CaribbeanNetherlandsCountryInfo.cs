using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Caribbean Netherlands
    /// </summary>
    public class CaribbeanNetherlandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Caribbean Netherlands";
        public string OfficialName => "Caribbean Netherlands";
        public Alpha2Code Alpha2Code => Alpha2Code.BQ;
        public Alpha3Code Alpha3Code => Alpha3Code.BES;
        public int NumericCode => 535;
        public string[] TLD => new[] { ".bq", ".nl" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[0];

        public ICurrency[] Currencies => new[] { new UsdCurrency() };
        public string[] CallingCodes => new[] { "599" };
    }
}
