namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Mali
	/// </summary>
	public class MaliInfo : ICountryInfo
	{
		public string CommonName => "Mali";
		public string OfficialName => "Republic of Mali";

		public Alpha2Code Alpha2Code => Alpha2Code.ML;
		public Alpha3Code Alpha3Code => Alpha3Code.MLI;
		public int NumericCode => 466;
		public string[] TLD => new [] { ".ml" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DZ,
			Alpha2Code.BF,
			Alpha2Code.GN,
			Alpha2Code.CI,
			Alpha2Code.MR,
			Alpha2Code.NE,
			Alpha2Code.SN,
		};

		public string[] Currencies => new [] { "XOF" };
		public string[] CallingCodes => new [] { "223" };
	}
}
