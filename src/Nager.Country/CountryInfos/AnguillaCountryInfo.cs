using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Anguilla
    /// </summary>
    public class AnguillaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Anguilla";
        ///<inheritdoc/>
        public string OfficialName => "Anguilla";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AI;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.AIA;
        ///<inheritdoc/>
        public int NumericCode => 660;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ai" };

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
        public string[] CallingCodes => new [] { "1264" };
    }
}
