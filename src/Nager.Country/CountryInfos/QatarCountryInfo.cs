using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Qatar
    /// </summary>
    public class QatarCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Qatar";
        ///<inheritdoc/>
        public string OfficialName => "State of Qatar";
        ///<inheritdoc/>
        public string NativeName => "قطر";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.QA;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.QAT;
        ///<inheritdoc/>
        public int NumericCode => 634;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".qa", "قطر." };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.SA,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new QarCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "974" };
    }
}
