using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Montserrat
    /// </summary>
    public class MontserratCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Montserrat";
        ///<inheritdoc/>
        public string OfficialName => "Montserrat";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MS;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MSR;
        ///<inheritdoc/>
        public int NumericCode => 500;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ms" };

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
        public string[] CallingCodes => new [] { "1664" };
    }
}
