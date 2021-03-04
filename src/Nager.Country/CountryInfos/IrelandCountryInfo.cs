using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ireland
    /// </summary>
    public class IrelandCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Ireland";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Ireland";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.IE;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.IRL;
        ///<inheritdoc/>
        public int NumericCode => 372;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ie" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GB,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "353" };
    }
}
