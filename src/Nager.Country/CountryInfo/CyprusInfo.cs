namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Cyprus
	/// </summary>
	public class CyprusInfo : ICountryInfo
	{
		public string CommonName => "Cyprus";
		public string OfficialName => "Republic of Cyprus";

		public Alpha2Code Alpha2Code => Alpha2Code.CY;
		public Alpha3Code Alpha3Code => Alpha3Code.CYP;
		public int NumericCode => 196;
		public string[] TLD => new [] { ".cy" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.EasternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.GB,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "357" };
	}
}
