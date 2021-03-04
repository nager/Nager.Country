using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Gambia
    /// </summary>
    public class GambiaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Gambia";
        ///<inheritdoc/>
        public string OfficialName => "Republic of the Gambia";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GM;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GMB;
        ///<inheritdoc/>
        public int NumericCode => 270;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".gm" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.SN,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new GmdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "220" };
    }
}
