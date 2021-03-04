using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Belarus
    /// </summary>
    public class BelarusCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Belarus";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Belarus";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BY;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BLR;
        ///<inheritdoc/>
        public int NumericCode => 112;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".by" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.LV,
            Alpha2Code.LT,
            Alpha2Code.PL,
            Alpha2Code.RU,
            Alpha2Code.UA,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new BynCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "375" };
    }
}
