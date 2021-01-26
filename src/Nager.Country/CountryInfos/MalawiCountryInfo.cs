using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Malawi
    /// </summary>
    public class MalawiCountryInfo : ICountryInfo
    {
        public string CommonName => "Malawi";
        public string OfficialName => "Republic of Malawi";
        public Alpha2Code Alpha2Code => Alpha2Code.MW;
        public Alpha3Code Alpha3Code => Alpha3Code.MWI;
        public int NumericCode => 454;
        public string[] TLD => new [] { ".mw" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MZ,
            Alpha2Code.TZ,
            Alpha2Code.ZM,
        };

        public ICurrency[] Currencies => new [] { new MwkCurrency() };
        public string[] CallingCodes => new [] { "265" };
    }
}
