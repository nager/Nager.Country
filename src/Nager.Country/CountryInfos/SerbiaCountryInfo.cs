using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Serbia
    /// </summary>
    public class SerbiaCountryInfo : ICountryInfo
    {
        public string CommonName => "Serbia";
        public string OfficialName => "Republic of Serbia";
        public Alpha2Code Alpha2Code => Alpha2Code.RS;
        public Alpha3Code Alpha3Code => Alpha3Code.SRB;
        public int NumericCode => 688;
        public string[] TLD => new [] { ".rs", ".срб" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BA,
            Alpha2Code.BG,
            Alpha2Code.HR,
            Alpha2Code.HU,
            Alpha2Code.MK,
            Alpha2Code.ME,
            Alpha2Code.RO,
        };

        public ICurrency[] Currencies => new [] { new RsdCurrency() };
        public string[] CallingCodes => new [] { "381" };
    }
}
