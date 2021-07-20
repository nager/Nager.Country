using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Benin
    /// </summary>
    public class BeninCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Benin";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Benin";
        ///<inheritdoc/>
        public string NativeName => "Bénin";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BJ;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BEN;
        ///<inheritdoc/>
        public int NumericCode => 204;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".bj" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BF,
            Alpha2Code.NE,
            Alpha2Code.NG,
            Alpha2Code.TG,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new XofCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "229" };
    }
}
