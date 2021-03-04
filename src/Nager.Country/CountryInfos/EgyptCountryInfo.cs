using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Egypt
    /// </summary>
    public class EgyptCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Egypt";
        ///<inheritdoc/>
        public string OfficialName => "Arab Republic of Egypt";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.EG;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.EGY;
        ///<inheritdoc/>
        public int NumericCode => 818;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".eg", ".مصر" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IL,
            Alpha2Code.LY,
            Alpha2Code.SD,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EgpCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "20" };
    }
}
