namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// São Tomé and Príncipe
	/// </summary>
	public class SãoToméandPríncipeInfo : ICountryInfo
	{
		public string CommonName => "São Tomé and Príncipe";
		public string OfficialName => "Democratic Republic of São Tomé and Príncipe";

		public Alpha2Code Alpha2Code => Alpha2Code.ST;
		public Alpha3Code Alpha3Code => Alpha3Code.STP;
		public int NumericCode => 678;
		public string[] TLD => new [] { ".st" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.MiddleAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "STD" };
		public string[] CallingCodes => new [] { "239" };
	}
}
