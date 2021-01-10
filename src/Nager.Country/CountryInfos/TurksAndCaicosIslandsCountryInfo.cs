using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Turks and Caicos Islands
    /// </summary>
    public class TurksAndCaicosIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Turks and Caicos Islands";
        public string OfficialName => "Turks and Caicos Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.TC;
        public Alpha3Code Alpha3Code => Alpha3Code.TCA;
        public int NumericCode => 796;
        public string[] TLD => new [] { ".tc" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1649" };
    }
}
