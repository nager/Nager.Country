using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tunisia
    /// </summary>
    public class TunisiaCountryInfo : ICountryInfo
    {
        public string CommonName => "Tunisia";
        public string OfficialName => "Tunisian Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.TN;
        public Alpha3Code Alpha3Code => Alpha3Code.TUN;
        public int NumericCode => 788;
        public string[] TLD => new [] { ".tn" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.LY,
        };

        public ICurrency[] Currencies => new [] { new TndCurrency() };
        public string[] CallingCodes => new [] { "216" };
    }
}
