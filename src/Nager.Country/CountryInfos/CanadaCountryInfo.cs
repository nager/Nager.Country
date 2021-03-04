using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Canada
    /// </summary>
    public class CanadaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Canada";
        ///<inheritdoc/>
        public string OfficialName => "Canada";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CA;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CAN;
        ///<inheritdoc/>
        public int NumericCode => 124;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ca" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.US,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new CadCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "1" };
    }
}
