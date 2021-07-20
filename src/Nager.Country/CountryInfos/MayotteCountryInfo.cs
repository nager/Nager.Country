using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mayotte
    /// </summary>
    public class MayotteCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Mayotte";
        ///<inheritdoc/>
        public string OfficialName => "Department of Mayotte";
        ///<inheritdoc/>
        public string NativeName => "Mayotte";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.YT;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MYT;
        ///<inheritdoc/>
        public int NumericCode => 175;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".yt" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "262" };
    }
}
