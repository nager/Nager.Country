using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kenya
    /// </summary>
    public class KenyaCountryInfo : ICountryInfo
    {
        public string CommonName => "Kenya";
        public string OfficialName => "Republic of Kenya";
        public Alpha2Code Alpha2Code => Alpha2Code.KE;
        public Alpha3Code Alpha3Code => Alpha3Code.KEN;
        public int NumericCode => 404;
        public string[] TLD => new [] { ".ke" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ET,
            Alpha2Code.SO,
            Alpha2Code.SS,
            Alpha2Code.TZ,
            Alpha2Code.UG,
        };

        public ICurrency[] Currencies => new [] { new KesCurrency() };
        public string[] CallingCodes => new [] { "254" };
    }
}
