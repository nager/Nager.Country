using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cook Islands
    /// </summary>
    public class CookIslandsCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Cook Islands";
        ///<inheritdoc/>
        public string OfficialName => "Cook Islands";
        ///<inheritdoc/>
        public string NativeName => "Cook Islands";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CK;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.COK;
        ///<inheritdoc/>
        public int NumericCode => 184;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ck" };

        ///<inheritdoc/>
        public Region Region => Region.Oceania;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new NzdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "682" };
    }
}
