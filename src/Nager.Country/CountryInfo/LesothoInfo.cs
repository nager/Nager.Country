namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Lesotho
	/// </summary>
	public class LesothoInfo : ICountryInfo
	{
		public string CommonName => "Lesotho";
		public string OfficialName => "Kingdom of Lesotho";

		public Alpha2Code Alpha2Code => Alpha2Code.LS;
		public Alpha3Code Alpha3Code => Alpha3Code.LSO;
		public int NumericCode => 426;
		public string[] TLD => new [] { ".ls" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.SouthernAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.ZA,
		};

		public string[] Currencies => new [] { "LSL", "ZAR" };
		public string[] CallingCodes => new [] { "266" };
	}
}
