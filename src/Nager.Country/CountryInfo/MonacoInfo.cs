namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Monaco
	/// </summary>
	public class MonacoInfo : ICountryInfo
	{
		public string CommonName => "Monaco";
		public string OfficialName => "Principality of Monaco";

		public Alpha2Code Alpha2Code => Alpha2Code.MC;
		public Alpha3Code Alpha3Code => Alpha3Code.MCO;
		public int NumericCode => 492;
		public string[] TLD => new [] { ".mc" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.WesternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.FR,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "377" };
	}
}
