using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Falkland Islands
    /// </summary>
    public class FalklandIslandsCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Falkland Islands";
        ///<inheritdoc/>
        public string OfficialName => "Falkland Islands";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.FK;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.FLK;
        ///<inheritdoc/>
        public int NumericCode => 238;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".fk" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new FkpCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "500" };
    }
}
