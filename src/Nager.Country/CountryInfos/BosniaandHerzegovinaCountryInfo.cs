using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bosnia and Herzegovina
    /// </summary>
    public class BosniaandHerzegovinaCountryInfo : ICountryInfo
    {
        public string CommonName => "Bosnia and Herzegovina";
        public string OfficialName => "Bosnia and Herzegovina";
        public Alpha2Code Alpha2Code => Alpha2Code.BA;
        public Alpha3Code Alpha3Code => Alpha3Code.BIH;
        public int NumericCode => 070;
        public string[] TLD => new [] { ".ba" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.HR,
            Alpha2Code.ME,
            Alpha2Code.RS,
        };

        public ICurrency[] Currencies => new [] { new BamCurrency() };
        public string[] CallingCodes => new [] { "387" };
    }
}
