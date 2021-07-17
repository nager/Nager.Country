using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bahamas
    /// </summary>
    public class BahamasCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Bahamas";
        ///<inheritdoc/>
        public string OfficialName => "Commonwealth of the Bahamas";
        ///<inheritdoc/>
        public string NativeName => "Bahamas";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BS;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BHS;
        ///<inheritdoc/>
        public int NumericCode => 044;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".bs" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new BsdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "1242" };
    }
}
