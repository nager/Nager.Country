namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Republic of the Congo
	/// </summary>
	public class RepublicoftheCongoInfo : ICountryInfo
	{
		public string CommonName => "Republic of the Congo";
		public string OfficialName => "Republic of the Congo";

		public Alpha2Code Alpha2Code => Alpha2Code.CG;
		public Alpha3Code Alpha3Code => Alpha3Code.COG;
		public int NumericCode => 178;
		public string[] TLD => new [] { ".cg" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.MiddleAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AO,
			Alpha2Code.CM,
			Alpha2Code.CF,
			Alpha2Code.CD,
			Alpha2Code.GA,
		};

		public string[] Currencies => new [] { "XAF" };
		public string[] CallingCodes => new [] { "242" };
	}
}
