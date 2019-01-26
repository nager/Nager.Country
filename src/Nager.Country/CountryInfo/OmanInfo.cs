namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Oman
	/// </summary>
	public class OmanInfo : ICountryInfo
	{
		public string CommonName => "Oman";
		public string OfficialName => "Sultanate of Oman";

		public Alpha2Code Alpha2Code => Alpha2Code.OM;
		public Alpha3Code Alpha3Code => Alpha3Code.OMN;
		public int NumericCode => 512;
		public string[] TLD => new [] { ".om" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.SA,
			Alpha2Code.AE,
			Alpha2Code.YE,
		};

		public string[] Currencies => new [] { "OMR" };
		public string[] CallingCodes => new [] { "968" };
	}
}
