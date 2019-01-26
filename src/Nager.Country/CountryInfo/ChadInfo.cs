namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Chad
	/// </summary>
	public class ChadInfo : ICountryInfo
	{
		public string CommonName => "Chad";
		public string OfficialName => "Republic of Chad";

		public Alpha2Code Alpha2Code => Alpha2Code.TD;
		public Alpha3Code Alpha3Code => Alpha3Code.TCD;
		public int NumericCode => 148;
		public string[] TLD => new [] { ".td" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.MiddleAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CM,
			Alpha2Code.CF,
			Alpha2Code.LY,
			Alpha2Code.NE,
			Alpha2Code.NG,
			Alpha2Code.SS,
		};

		public string[] Currencies => new [] { "XAF" };
		public string[] CallingCodes => new [] { "235" };
	}
}
