using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kuwait
    /// </summary>
    public class KuwaitCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Kuwait";
        ///<inheritdoc/>
        public string OfficialName => "State of Kuwait";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KW;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.KWT;
        ///<inheritdoc/>
        public int NumericCode => 414;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".kw" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IQ,
            Alpha2Code.SA,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new KwdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "965" };
    }
}
