using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Antarctica
    /// </summary>
    public class AntarcticaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Antarctica";
        ///<inheritdoc/>
        public string OfficialName => "Antarctica";
        ///<inheritdoc/>
        public string NativeName => "Antarctica";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AQ;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ATA;
        ///<inheritdoc/>
        public int NumericCode => 010;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".aq" };

        ///<inheritdoc/>
        public Region Region => Region.Antarctic;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.None;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new ICurrency[0];
        ///<inheritdoc/>
        public string[] CallingCodes => new string[0];
    }
}
