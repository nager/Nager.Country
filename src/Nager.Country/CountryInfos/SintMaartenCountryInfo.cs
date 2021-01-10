using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Sint Maarten
    /// </summary>
    public class SintMaartenCountryInfo : ICountryInfo
    {
        public string CommonName => "Sint Maarten";
        public string OfficialName => "Sint Maarten";
        public Alpha2Code Alpha2Code => Alpha2Code.SX;
        public Alpha3Code Alpha3Code => Alpha3Code.SXM;
        public int NumericCode => 534;
        public string[] TLD => new [] { ".sx" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MF,
        };

        public ICurrency[] Currencies => new [] { new AngCurrency() };
        public string[] CallingCodes => new [] { "1721" };
    }
}
