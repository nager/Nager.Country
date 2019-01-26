namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Turkey
	/// </summary>
	public class TurkeyInfo : ICountryInfo
	{
		public string CommonName => "Turkey";
		public string OfficialName => "Republic of Turkey";

		public Alpha2Code Alpha2Code => Alpha2Code.TR;
		public Alpha3Code Alpha3Code => Alpha3Code.TUR;
		public int NumericCode => 792;
		public string[] TLD => new [] { ".tr" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AM,
			Alpha2Code.AZ,
			Alpha2Code.BG,
			Alpha2Code.GE,
			Alpha2Code.GR,
			Alpha2Code.IR,
			Alpha2Code.IQ,
			Alpha2Code.SY,
		};

		public string[] Currencies => new [] { "TRY" };
		public string[] CallingCodes => new [] { "90" };
	}
}
