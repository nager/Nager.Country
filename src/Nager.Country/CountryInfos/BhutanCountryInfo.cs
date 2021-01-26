using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bhutan
    /// </summary>
    public class BhutanCountryInfo : ICountryInfo
    {
        public string CommonName => "Bhutan";
        public string OfficialName => "Kingdom of Bhutan";
        public Alpha2Code Alpha2Code => Alpha2Code.BT;
        public Alpha3Code Alpha3Code => Alpha3Code.BTN;
        public int NumericCode => 064;
        public string[] TLD => new [] { ".bt" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.IN,
        };

        public ICurrency[] Currencies => new ICurrency[] { new BtnCurrency(), new InrCurrency() };
        public string[] CallingCodes => new [] { "975" };
    }
}
