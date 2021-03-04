using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Caribbean Netherlands
    /// </summary>
    public class CaribbeanNetherlandsCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Caribbean Netherlands";
        ///<inheritdoc/>
        public string OfficialName => "Caribbean Netherlands";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BQ;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BES;
        ///<inheritdoc/>
        public int NumericCode => 535;
        ///<inheritdoc/>
        public string[] TLD => new[] { ".bq", ".nl" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[0];

        ///<inheritdoc/>
        public ICurrency[] Currencies => new[] { new UsdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new[] { "599" };
    }
}
