using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Morocco
    /// </summary>
    public class MoroccoCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Morocco";
        ///<inheritdoc/>
        public string OfficialName => "Kingdom of Morocco";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MA;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MAR;
        ///<inheritdoc/>
        public int NumericCode => 504;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ma", "المغرب." };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.EH,
            Alpha2Code.ES,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new MadCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "212" };
    }
}
