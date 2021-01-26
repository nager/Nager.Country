using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Montenegro
    /// </summary>
    public class MontenegroCountryInfo : ICountryInfo
    {
        public string CommonName => "Montenegro";
        public string OfficialName => "Montenegro";
        public Alpha2Code Alpha2Code => Alpha2Code.ME;
        public Alpha3Code Alpha3Code => Alpha3Code.MNE;
        public int NumericCode => 499;
        public string[] TLD => new [] { ".me" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AL,
            Alpha2Code.BA,
            Alpha2Code.HR,
            Alpha2Code.RS,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "382" };
    }
}
