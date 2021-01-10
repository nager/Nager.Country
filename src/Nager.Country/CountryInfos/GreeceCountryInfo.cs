using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Greece
    /// </summary>
    public class GreeceCountryInfo : ICountryInfo
    {
        public string CommonName => "Greece";
        public string OfficialName => "Hellenic Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.GR;
        public Alpha3Code Alpha3Code => Alpha3Code.GRC;
        public int NumericCode => 300;
        public string[] TLD => new [] { ".gr" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AL,
            Alpha2Code.BG,
            Alpha2Code.TR,
            Alpha2Code.MK,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "30" };
    }
}
