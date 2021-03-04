using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Denmark
    /// </summary>
    public class DenmarkCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Denmark";
        ///<inheritdoc/>
        public string OfficialName => "Kingdom of Denmark";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.DK;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.DNK;
        ///<inheritdoc/>
        public int NumericCode => 208;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".dk" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DE,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new DkkCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "45" };
    }
}
