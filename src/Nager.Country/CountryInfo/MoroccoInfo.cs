namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Morocco
	/// </summary>
	public class MoroccoInfo : ICountryInfo
	{
		public string CommonName => "Morocco";
		public string OfficialName => "Kingdom of Morocco";

		public Alpha2Code Alpha2Code => Alpha2Code.MA;
		public Alpha3Code Alpha3Code => Alpha3Code.MAR;
		public int NumericCode => 504;
		public string[] TLD => new [] { ".ma", "المغرب." };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.NorthernAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DZ,
			Alpha2Code.EH,
			Alpha2Code.ES,
		};

		public string[] Currencies => new [] { "MAD" };
		public string[] CallingCodes => new [] { "212" };
	}
}
