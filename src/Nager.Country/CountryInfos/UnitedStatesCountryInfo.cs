using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United States
    /// </summary>
    public class UnitedStatesCountryInfo : ICountryInfo
    {
        public string CommonName => "United States";
        public string OfficialName => "United States of America";
        public Alpha2Code Alpha2Code => Alpha2Code.US;
        public Alpha3Code Alpha3Code => Alpha3Code.USA;
        public int NumericCode => 840;
        public string[] TLD => new [] { ".us" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CA,
            Alpha2Code.MX,
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1" };
    }
}
