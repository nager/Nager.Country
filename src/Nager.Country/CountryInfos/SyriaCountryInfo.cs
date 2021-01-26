using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Syria
    /// </summary>
    public class SyriaCountryInfo : ICountryInfo
    {
        public string CommonName => "Syria";
        public string OfficialName => "Syrian Arab Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.SY;
        public Alpha3Code Alpha3Code => Alpha3Code.SYR;
        public int NumericCode => 760;
        public string[] TLD => new [] { ".sy", "سوريا." };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IQ,
            Alpha2Code.IL,
            Alpha2Code.JO,
            Alpha2Code.LB,
            Alpha2Code.TR,
        };

        public ICurrency[] Currencies => new [] { new SypCurrency() };
        public string[] CallingCodes => new [] { "963" };
    }
}
