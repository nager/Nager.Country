namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Sudan
	/// </summary>
	public class SudanInfo : ICountryInfo
	{
		public string CommonName => "Sudan";
		public string OfficialName => "Republic of the Sudan";

		public Alpha2Code Alpha2Code => Alpha2Code.SD;
		public Alpha3Code Alpha3Code => Alpha3Code.SDN;
		public int NumericCode => 729;
		public string[] TLD => new [] { ".sd" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.NorthernAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CF,
			Alpha2Code.TD,
			Alpha2Code.EG,
			Alpha2Code.ER,
			Alpha2Code.ET,
			Alpha2Code.LY,
			Alpha2Code.SS,
		};

		public string[] Currencies => new [] { "SDG" };
		public string[] CallingCodes => new [] { "249" };
	}
}
