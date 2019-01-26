namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Suriname
	/// </summary>
	public class SurinameInfo : ICountryInfo
	{
		public string CommonName => "Suriname";
		public string OfficialName => "Republic of Suriname";

		public Alpha2Code Alpha2Code => Alpha2Code.SR;
		public Alpha3Code Alpha3Code => Alpha3Code.SUR;
		public int NumericCode => 740;
		public string[] TLD => new [] { ".sr" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BR,
			Alpha2Code.GF,
			Alpha2Code.GY,
		};

		public string[] Currencies => new [] { "SRD" };
		public string[] CallingCodes => new [] { "597" };
	}
}
