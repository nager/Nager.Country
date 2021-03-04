using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Niger
    /// </summary>
    public class NigerCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Niger";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Niger";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NE;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NER;
        ///<inheritdoc/>
        public int NumericCode => 562;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ne" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.BJ,
            Alpha2Code.BF,
            Alpha2Code.TD,
            Alpha2Code.LY,
            Alpha2Code.ML,
            Alpha2Code.NG,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new XofCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "227" };
    }
}
