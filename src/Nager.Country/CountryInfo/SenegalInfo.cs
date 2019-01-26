namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Senegal
	/// </summary>
	public class SenegalInfo : ICountryInfo
	{
		public string CommonName => "Senegal";
		public string OfficialName => "Republic of Senegal";

		public Alpha2Code Alpha2Code => Alpha2Code.SN;
		public Alpha3Code Alpha3Code => Alpha3Code.SEN;
		public int NumericCode => 686;
		public string[] TLD => new [] { ".sn" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.GM,
			Alpha2Code.GN,
			Alpha2Code.GW,
			Alpha2Code.ML,
			Alpha2Code.MR,
		};

		public string[] Currencies => new [] { "XOF" };
		public string[] CallingCodes => new [] { "221" };
	}
}
