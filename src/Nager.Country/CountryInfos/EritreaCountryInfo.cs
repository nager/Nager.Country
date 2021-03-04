using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Eritrea
    /// </summary>
    public class EritreaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Eritrea";
        ///<inheritdoc/>
        public string OfficialName => "State of Eritrea";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ER;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ERI;
        ///<inheritdoc/>
        public int NumericCode => 232;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".er" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DJ,
            Alpha2Code.ET,
            Alpha2Code.SD,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new ErnCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "291" };
    }
}
