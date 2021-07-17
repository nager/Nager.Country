using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Christmas Island
    /// </summary>
    public class ChristmasIslandCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Christmas Island";
        ///<inheritdoc/>
        public string OfficialName => "Territory of Christmas Island";
        ///<inheritdoc/>
        public string NativeName => "Christmas Island";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CX;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CXR;
        ///<inheritdoc/>
        public int NumericCode => 162;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".cx" };

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
