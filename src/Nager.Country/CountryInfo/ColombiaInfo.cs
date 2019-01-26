namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Colombia
	/// </summary>
	public class ColombiaInfo : ICountryInfo
	{
		public string CommonName => "Colombia";
		public string OfficialName => "Republic of Colombia";

		public Alpha2Code Alpha2Code => Alpha2Code.CO;
		public Alpha3Code Alpha3Code => Alpha3Code.COL;
		public int NumericCode => 170;
		public string[] TLD => new [] { ".co" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BR,
			Alpha2Code.EC,
			Alpha2Code.PA,
			Alpha2Code.PE,
			Alpha2Code.VE,
		};

		public string[] Currencies => new [] { "COP" };
		public string[] CallingCodes => new [] { "57" };
	}
}
