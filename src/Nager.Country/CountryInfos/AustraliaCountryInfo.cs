using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Australia
    /// </summary>
    public class AustraliaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Australia";
        ///<inheritdoc/>
        public string OfficialName => "Commonwealth of Australia";
        ///<inheritdoc/>
        public string NativeName => "Australia";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AU;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.AUS;
        ///<inheritdoc/>
        public int NumericCode => 036;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".au" };

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
