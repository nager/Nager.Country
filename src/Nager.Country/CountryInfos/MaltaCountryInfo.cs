using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Malta
    /// </summary>
    public class MaltaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Malta";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Malta";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MT;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MLT;
        ///<inheritdoc/>
        public int NumericCode => 470;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".mt" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "356" };
    }
}
