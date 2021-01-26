using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Swaziland
    /// </summary>
    public class SwazilandCountryInfo : ICountryInfo
    {
        public string CommonName => "Eswatini";
        public string OfficialName => "Kingdom of Swaziland";
        public Alpha2Code Alpha2Code => Alpha2Code.SZ;
        public Alpha3Code Alpha3Code => Alpha3Code.SWZ;
        public int NumericCode => 748;
        public string[] TLD => new [] { ".sz" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MZ,
            Alpha2Code.ZA,
        };

        public ICurrency[] Currencies => new [] { new SzlCurrency() };
        public string[] CallingCodes => new [] { "268" };
    }
}
