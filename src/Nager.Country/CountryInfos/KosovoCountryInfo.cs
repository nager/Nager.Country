using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kosovo (partially recognized; not a UN member state)
    /// </summary>
    public class KosovoCountryInfo : ICountryInfo
	{
        /// <inheritdoc/>
        public string CommonName => "Kosovo";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Kosovo";
        /// <inheritdoc/>
        public string NativeName => "Republika e Kosovës";
        /// <inheritdoc/>
        /// <remarks>User-assigned placeholder</remarks>
        public Alpha2Code Alpha2Code => Alpha2Code.XK;
        /// <inheritdoc/>
        /// <remarks>Common unofficial convention</remarks>
        public Alpha3Code Alpha3Code => Alpha3Code.XKX;
        /// <inheritdoc/>
        /// <remarks>No ISO numeric code yet</remarks>
        public int NumericCode => 0;
        /// <inheritdoc/>
        /// <remarks>Reserved, unofficial</remarks>
		public string[] TLD => new[] { ".xk" };
        /// <inheritdoc/>
		public Region Region => Region.Europe;
        /// <inheritdoc/>
		public SubRegion SubRegion => SubRegion.SouthernEurope;
        /// <inheritdoc/>
		public Alpha2Code[] BorderCountries => new[]
		{
			Alpha2Code.AL,
			Alpha2Code.ME,
			Alpha2Code.MK,
			Alpha2Code.RS
		};
        /// <inheritdoc/>
        /// <remarks>Euro used unilaterally</remarks>
		public ICurrency[] Currencies => new[] { new EurCurrency() };
        /// <inheritdoc/>
		public string[] CallingCodes => new[] { "383" };
	}
}
