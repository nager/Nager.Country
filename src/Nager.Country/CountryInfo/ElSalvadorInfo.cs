namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// El Salvador
	/// </summary>
	public class ElSalvadorInfo : ICountryInfo
	{
		public string CommonName => "El Salvador";
		public string OfficialName => "Republic of El Salvador";

		public Alpha2Code Alpha2Code => Alpha2Code.SV;
		public Alpha3Code Alpha3Code => Alpha3Code.SLV;
		public int NumericCode => 222;
		public string[] TLD => new [] { ".sv" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.CentralAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.GT,
			Alpha2Code.HN,
		};

		public string[] Currencies => new [] { "SVC", "USD" };
		public string[] CallingCodes => new [] { "503" };
	}
}
