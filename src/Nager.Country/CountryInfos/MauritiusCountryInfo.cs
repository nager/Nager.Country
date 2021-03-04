using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mauritius
    /// </summary>
    public class MauritiusCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Mauritius";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Mauritius";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MU;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MUS;
        ///<inheritdoc/>
        public int NumericCode => 480;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".mu" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new MurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "230" };
    }
}
