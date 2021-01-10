using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mayotte
    /// </summary>
    public class MayotteCountryInfo : ICountryInfo
    {
        public string CommonName => "Mayotte";
        public string OfficialName => "Department of Mayotte";
        public Alpha2Code Alpha2Code => Alpha2Code.YT;
        public Alpha3Code Alpha3Code => Alpha3Code.MYT;
        public int NumericCode => 175;
        public string[] TLD => new [] { ".yt" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "262" };
    }
}
