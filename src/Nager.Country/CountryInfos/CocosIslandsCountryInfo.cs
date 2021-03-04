using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cocos (Keeling) Islands
    /// </summary>
    public class CocosIslandsCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Cocos (Keeling) Islands";
        ///<inheritdoc/>
        public string OfficialName => "Territory of the Cocos (Keeling) Islands";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CC;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CCK;
        ///<inheritdoc/>
        public int NumericCode => 166;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".cc" };

        ///<inheritdoc/>
        public Region Region => Region.Oceania;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new AudCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "61" };
    }
}
