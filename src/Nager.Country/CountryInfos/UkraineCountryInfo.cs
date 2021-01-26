using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ukraine
    /// </summary>
    public class UkraineCountryInfo : ICountryInfo
    {
        public string CommonName => "Ukraine";
        public string OfficialName => "Ukraine";
        public Alpha2Code Alpha2Code => Alpha2Code.UA;
        public Alpha3Code Alpha3Code => Alpha3Code.UKR;
        public int NumericCode => 804;
        public string[] TLD => new [] { ".ua", ".укр" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BY,
            Alpha2Code.HU,
            Alpha2Code.MD,
            Alpha2Code.PL,
            Alpha2Code.RO,
            Alpha2Code.RU,
            Alpha2Code.SK,
        };

        public ICurrency[] Currencies => new [] { new UahCurrency() };
        public string[] CallingCodes => new [] { "380" };
    }
}
