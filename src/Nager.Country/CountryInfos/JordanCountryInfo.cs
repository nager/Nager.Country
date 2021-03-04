using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Jordan
    /// </summary>
    public class JordanCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Jordan";
        ///<inheritdoc/>
        public string OfficialName => "Hashemite Kingdom of Jordan";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.JO;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.JOR;
        ///<inheritdoc/>
        public int NumericCode => 400;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".jo", "الاردن." };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IQ,
            Alpha2Code.IL,
            Alpha2Code.SA,
            Alpha2Code.SY,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new JodCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "962" };
    }
}
