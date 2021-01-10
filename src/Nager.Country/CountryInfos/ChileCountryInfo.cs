using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Chile
    /// </summary>
    public class ChileCountryInfo : ICountryInfo
    {
        public string CommonName => "Chile";
        public string OfficialName => "Republic of Chile";
        public Alpha2Code Alpha2Code => Alpha2Code.CL;
        public Alpha3Code Alpha3Code => Alpha3Code.CHL;
        public int NumericCode => 152;
        public string[] TLD => new [] { ".cl" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BO,
            Alpha2Code.PE,
        };

        public ICurrency[] Currencies => new [] { new ClpCurrency() };
        public string[] CallingCodes => new [] { "56" };
    }
}
