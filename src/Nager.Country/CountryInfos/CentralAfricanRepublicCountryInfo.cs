using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Central African Republic
    /// </summary>
    public class CentralAfricanRepublicCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Central African Republic";
        ///<inheritdoc/>
        public string OfficialName => "Central African Republic";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CF;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CAF;
        ///<inheritdoc/>
        public int NumericCode => 140;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".cf" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CM,
            Alpha2Code.TD,
            Alpha2Code.CD,
            Alpha2Code.CG,
            Alpha2Code.SS,
            Alpha2Code.SD,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new XafCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "236" };
    }
}
