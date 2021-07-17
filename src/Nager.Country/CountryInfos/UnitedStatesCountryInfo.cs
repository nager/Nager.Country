using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United States
    /// </summary>
    public class UnitedStatesCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "United States";
        ///<inheritdoc/>
        public string OfficialName => "United States of America";
        ///<inheritdoc/>
        public string NativeName => "United States";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.US;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.USA;
        ///<inheritdoc/>
        public int NumericCode => 840;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".us" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CA,
            Alpha2Code.MX,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "1" };
    }
}
