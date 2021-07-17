using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// El Salvador
    /// </summary>
    public class ElSalvadorCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "El Salvador";
        ///<inheritdoc/>
        public string OfficialName => "Republic of El Salvador";
        ///<inheritdoc/>
        public string NativeName => "El Salvador";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SV;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SLV;
        ///<inheritdoc/>
        public int NumericCode => 222;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".sv" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GT,
            Alpha2Code.HN,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new ICurrency[] { new SvcCurrency(), new UsdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "503" };
    }
}
