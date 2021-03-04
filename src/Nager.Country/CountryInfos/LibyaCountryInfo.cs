using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Libya
    /// </summary>
    public class LibyaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Libya";
        ///<inheritdoc/>
        public string OfficialName => "State of Libya";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LY;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LBY;
        ///<inheritdoc/>
        public int NumericCode => 434;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ly" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.TD,
            Alpha2Code.EG,
            Alpha2Code.NE,
            Alpha2Code.SD,
            Alpha2Code.TN,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new LydCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "218" };
    }
}
