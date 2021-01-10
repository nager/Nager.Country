using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Gibraltar
    /// </summary>
    public class GibraltarCountryInfo : ICountryInfo
    {
        public string CommonName => "Gibraltar";
        public string OfficialName => "Gibraltar";
        public Alpha2Code Alpha2Code => Alpha2Code.GI;
        public Alpha3Code Alpha3Code => Alpha3Code.GIB;
        public int NumericCode => 292;
        public string[] TLD => new [] { ".gi" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ES,
        };

        public ICurrency[] Currencies => new [] { new GipCurrency() };
        public string[] CallingCodes => new [] { "350" };
    }
}
