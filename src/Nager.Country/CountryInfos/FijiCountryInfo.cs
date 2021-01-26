using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Fiji
    /// </summary>
    public class FijiCountryInfo : ICountryInfo
    {
        public string CommonName => "Fiji";
        public string OfficialName => "Republic of Fiji";
        public Alpha2Code Alpha2Code => Alpha2Code.FJ;
        public Alpha3Code Alpha3Code => Alpha3Code.FJI;
        public int NumericCode => 242;
        public string[] TLD => new [] { ".fj" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Melanesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new FjdCurrency() };
        public string[] CallingCodes => new [] { "679" };
    }
}
