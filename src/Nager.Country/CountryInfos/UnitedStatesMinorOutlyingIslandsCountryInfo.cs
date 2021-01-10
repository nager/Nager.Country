using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United States Minor Outlying Islands
    /// </summary>
    public class UnitedStatesMinorOutlyingIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "United States Minor Outlying Islands";
        public string OfficialName => "United States Minor Outlying Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.UM;
        public Alpha3Code Alpha3Code => Alpha3Code.UMI;
        public int NumericCode => 581;
        public string[] TLD => new [] { ".us" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new string[0];
    }
}
