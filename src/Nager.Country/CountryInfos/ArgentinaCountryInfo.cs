using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Argentina
    /// </summary>
    public class ArgentinaCountryInfo : ICountryInfo
    {
        public string CommonName => "Argentina";
        public string OfficialName => "Argentine Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.AR;
        public Alpha3Code Alpha3Code => Alpha3Code.ARG;
        public int NumericCode => 032;
        public string[] TLD => new [] { ".ar" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BO,
            Alpha2Code.BR,
            Alpha2Code.CL,
            Alpha2Code.PY,
            Alpha2Code.UY,
        };

        public ICurrency[] Currencies => new [] { new ArsCurrency() };
        public string[] CallingCodes => new [] { "54" };
    }
}
