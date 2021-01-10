using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Barthélemy
    /// </summary>
    public class SaintBarthelemyCountryInfo : ICountryInfo
    {
        public string CommonName => "Saint Barthélemy";
        public string OfficialName => "Collectivity of Saint BarthélemySaint Barthélemy";
        public Alpha2Code Alpha2Code => Alpha2Code.BL;
        public Alpha3Code Alpha3Code => Alpha3Code.BLM;
        public int NumericCode => 652;
        public string[] TLD => new [] { ".bl" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "590" };
    }
}
