using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mauritius
    /// </summary>
    public class MauritiusCountryInfo : ICountryInfo
    {
        public string CommonName => "Mauritius";
        public string OfficialName => "Republic of Mauritius";
        public Alpha2Code Alpha2Code => Alpha2Code.MU;
        public Alpha3Code Alpha3Code => Alpha3Code.MUS;
        public int NumericCode => 480;
        public string[] TLD => new [] { ".mu" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new MurCurrency() };
        public string[] CallingCodes => new [] { "230" };
    }
}
