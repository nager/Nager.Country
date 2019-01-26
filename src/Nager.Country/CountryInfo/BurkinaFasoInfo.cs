namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Burkina Faso
	/// </summary>
	public class BurkinaFasoInfo : ICountryInfo
	{
		public string CommonName => "Burkina Faso";
		public string OfficialName => "Burkina Faso";

		public Alpha2Code Alpha2Code => Alpha2Code.BF;
		public Alpha3Code Alpha3Code => Alpha3Code.BFA;
		public int NumericCode => 854;
		public string[] TLD => new [] { ".bf" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BJ,
			Alpha2Code.CI,
			Alpha2Code.GH,
			Alpha2Code.ML,
			Alpha2Code.NE,
			Alpha2Code.TG,
		};

		public string[] Currencies => new [] { "XOF" };
		public string[] CallingCodes => new [] { "226" };
	}
}
