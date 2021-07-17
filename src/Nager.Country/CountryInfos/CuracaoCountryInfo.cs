using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Curaçao
    /// </summary>
    public class CuracaoCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Curaçao";
        ///<inheritdoc/>
        public string OfficialName => "Country of Curaçao";
        ///<inheritdoc/>
        public string NativeName => "Curaçao";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CW;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CUW;
        ///<inheritdoc/>
        public int NumericCode => 531;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".cw" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new AngCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "5999" };
    }
}
