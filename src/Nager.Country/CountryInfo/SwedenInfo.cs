namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Sweden
	/// </summary>
	public class SwedenInfo : ICountryInfo
	{
		public string CommonName => "Sweden";
		public string OfficialName => "Kingdom of Sweden";

		public Alpha2Code Alpha2Code => Alpha2Code.SE;
		public Alpha3Code Alpha3Code => Alpha3Code.SWE;
		public int NumericCode => 752;
		public string[] TLD => new [] { ".se" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.FI,
			Alpha2Code.NO,
		};

		public string[] Currencies => new [] { "SEK" };
		public string[] CallingCodes => new [] { "46" };
	}
}
