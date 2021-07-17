using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Dominica
    /// </summary>
    public class DominicaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Dominica";
        ///<inheritdoc/>
        public string OfficialName => "Commonwealth of Dominica";
        ///<inheritdoc/>
        public string NativeName => "Dominica";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.DM;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.DMA;
        ///<inheritdoc/>
        public int NumericCode => 212;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".dm" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "1767" };
    }
}
