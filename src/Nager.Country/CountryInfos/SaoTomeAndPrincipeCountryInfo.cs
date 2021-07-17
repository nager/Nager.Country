using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// São Tomé and Príncipe
    /// </summary>
    public class SaoTomeAndPrincipeCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "São Tomé and Príncipe";
        ///<inheritdoc/>
        public string OfficialName => "Democratic Republic of São Tomé and Príncipe";
        ///<inheritdoc/>
        public string NativeName => "São Tomé e Príncipe";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ST;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.STP;
        ///<inheritdoc/>
        public int NumericCode => 678;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".st" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] {new StdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "239" };
    }
}
