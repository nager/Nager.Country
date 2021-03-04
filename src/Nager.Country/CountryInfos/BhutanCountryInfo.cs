using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bhutan
    /// </summary>
    public class BhutanCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Bhutan";
        ///<inheritdoc/>
        public string OfficialName => "Kingdom of Bhutan";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BT;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BTN;
        ///<inheritdoc/>
        public int NumericCode => 064;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".bt" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.IN,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new ICurrency[] { new BtnCurrency(), new InrCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "975" };
    }
}
