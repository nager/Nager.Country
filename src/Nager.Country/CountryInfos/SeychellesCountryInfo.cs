using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Seychelles
    /// </summary>
    public class SeychellesCountryInfo : ICountryInfo
    {
        public string CommonName => "Seychelles";
        public string OfficialName => "Republic of Seychelles";
        public Alpha2Code Alpha2Code => Alpha2Code.SC;
        public Alpha3Code Alpha3Code => Alpha3Code.SYC;
        public int NumericCode => 690;
        public string[] TLD => new [] { ".sc" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new ScrCurrency() };
        public string[] CallingCodes => new [] { "248" };
    }
}
