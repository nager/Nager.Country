using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mozambique
    /// </summary>
    public class MozambiqueCountryInfo : ICountryInfo
    {
        public string CommonName => "Mozambique";
        public string OfficialName => "Republic of Mozambique";
        public Alpha2Code Alpha2Code => Alpha2Code.MZ;
        public Alpha3Code Alpha3Code => Alpha3Code.MOZ;
        public int NumericCode => 508;
        public string[] TLD => new [] { ".mz" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MW,
            Alpha2Code.ZA,
            Alpha2Code.SZ,
            Alpha2Code.TZ,
            Alpha2Code.ZM,
            Alpha2Code.ZW,
        };

        public ICurrency[] Currencies => new [] { new MznCurrency() };
        public string[] CallingCodes => new [] { "258" };
    }
}
