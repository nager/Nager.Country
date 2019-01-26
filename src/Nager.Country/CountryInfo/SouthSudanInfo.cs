namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// South Sudan
	/// </summary>
	public class SouthSudanInfo : ICountryInfo
	{
		public string CommonName => "South Sudan";
		public string OfficialName => "Republic of South Sudan";

		public Alpha2Code Alpha2Code => Alpha2Code.SS;
		public Alpha3Code Alpha3Code => Alpha3Code.SSD;
		public int NumericCode => 728;
		public string[] TLD => new [] { ".ss" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.MiddleAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CF,
			Alpha2Code.CD,
			Alpha2Code.ET,
			Alpha2Code.KE,
			Alpha2Code.SD,
			Alpha2Code.UG,
		};

		public string[] Currencies => new [] { "SSP" };
		public string[] CallingCodes => new [] { "211" };
	}
}
