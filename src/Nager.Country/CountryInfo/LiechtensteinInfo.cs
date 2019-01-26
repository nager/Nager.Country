namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Liechtenstein
	/// </summary>
	public class LiechtensteinInfo : ICountryInfo
	{
		public string CommonName => "Liechtenstein";
		public string OfficialName => "Principality of Liechtenstein";

		public Alpha2Code Alpha2Code => Alpha2Code.LI;
		public Alpha3Code Alpha3Code => Alpha3Code.LIE;
		public int NumericCode => 438;
		public string[] TLD => new [] { ".li" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.WesternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AT,
			Alpha2Code.CH,
		};

		public string[] Currencies => new [] { "CHF" };
		public string[] CallingCodes => new [] { "423" };
	}
}
