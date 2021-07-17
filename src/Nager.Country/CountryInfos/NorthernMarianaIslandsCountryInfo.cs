using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Northern Mariana Islands
    /// </summary>
    public class NorthernMarianaIslandsCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Northern Mariana Islands";
        ///<inheritdoc/>
        public string OfficialName => "Commonwealth of the Northern Mariana Islands";
        ///<inheritdoc/>
        public string NativeName => "Northern Mariana Islands";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MP;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MNP;
        ///<inheritdoc/>
        public int NumericCode => 580;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".mp" };

        ///<inheritdoc/>
        public Region Region => Region.Oceania;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Micronesia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "1670" };
    }
}
