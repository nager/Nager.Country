using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Jersey
    /// </summary>
    public class JerseyCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Jersey";
        ///<inheritdoc/>
        public string OfficialName => "Bailiwick of Jersey";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.JE;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.JEY;
        ///<inheritdoc/>
        public int NumericCode => 832;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".je" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new GbpCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "44" };
    }
}
