using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mauritania
    /// </summary>
    public class MauritaniaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Mauritania";
        ///<inheritdoc/>
        public string OfficialName => "Islamic Republic of Mauritania";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MR;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MRT;
        ///<inheritdoc/>
        public int NumericCode => 478;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".mr" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.ML,
            Alpha2Code.SN,
            Alpha2Code.EH,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new MroCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "222" };
    }
}
