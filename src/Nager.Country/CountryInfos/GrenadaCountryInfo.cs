using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Grenada
    /// </summary>
    public class GrenadaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Grenada";
        ///<inheritdoc/>
        public string OfficialName => "Grenada";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GD;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GRD;
        ///<inheritdoc/>
        public int NumericCode => 308;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".gd" };

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
        public string[] CallingCodes => new [] { "1473" };
    }
}
