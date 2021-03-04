using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Réunion
    /// </summary>
    public class ReunionCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Réunion";
        ///<inheritdoc/>
        public string OfficialName => "Réunion Island";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.RE;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.REU;
        ///<inheritdoc/>
        public int NumericCode => 638;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".re" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "262" };
    }
}
