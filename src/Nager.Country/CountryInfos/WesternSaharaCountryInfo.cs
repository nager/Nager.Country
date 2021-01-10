using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Western Sahara
    /// </summary>
    public class WesternSaharaCountryInfo : ICountryInfo
    {
        public string CommonName => "Western Sahara";
        public string OfficialName => "Sahrawi Arab Democratic Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.EH;
        public Alpha3Code Alpha3Code => Alpha3Code.ESH;
        public int NumericCode => 732;
        public string[] TLD => new [] { ".eh" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.MR,
            Alpha2Code.MA,
        };

        public ICurrency[] Currencies => new ICurrency[] { new MadCurrency(), new DzdCurrency(), new MroCurrency() };
        public string[] CallingCodes => new [] { "212" };
    }
}
