using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cuba
    /// </summary>
    public class CubaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Cuba";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Cuba";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CU;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CUB;
        ///<inheritdoc/>
        public int NumericCode => 192;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".cu" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new ICurrency[] { new CucCurrency(), new CupCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "53" };
    }
}
