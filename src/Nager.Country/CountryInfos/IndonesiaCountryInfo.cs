using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Indonesia
    /// </summary>
    public class IndonesiaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Indonesia";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Indonesia";
        ///<inheritdoc/>
        public string NativeName => "Indonesia";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ID;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.IDN;
        ///<inheritdoc/>
        public int NumericCode => 360;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".id" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.TL,
            Alpha2Code.MY,
            Alpha2Code.PG,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new IdrCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "62" };
    }
}
