using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Sint Maarten
    /// </summary>
    public class SintMaartenCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Sint Maarten";
        ///<inheritdoc/>
        public string OfficialName => "Sint Maarten";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SX;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SXM;
        ///<inheritdoc/>
        public int NumericCode => 534;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".sx" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MF,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new AngCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "1721" };
    }
}
