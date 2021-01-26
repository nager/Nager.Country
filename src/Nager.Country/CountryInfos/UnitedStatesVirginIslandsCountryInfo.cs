using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United States Virgin Islands
    /// </summary>
    public class UnitedStatesVirginIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "United States Virgin Islands";
        public string OfficialName => "Virgin Islands of the United States";
        public Alpha2Code Alpha2Code => Alpha2Code.VI;
        public Alpha3Code Alpha3Code => Alpha3Code.VIR;
        public int NumericCode => 850;
        public string[] TLD => new [] { ".vi" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1340" };
    }
}
