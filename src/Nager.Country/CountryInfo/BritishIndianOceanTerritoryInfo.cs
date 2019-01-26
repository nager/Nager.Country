namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// British Indian Ocean Territory
	/// </summary>
	public class BritishIndianOceanTerritoryInfo : ICountryInfo
	{
		public string CommonName => "British Indian Ocean Territory";
		public string OfficialName => "British Indian Ocean Territory";

		public Alpha2Code Alpha2Code => Alpha2Code.IO;
		public Alpha3Code Alpha3Code => Alpha3Code.IOT;
		public int NumericCode => 086;
		public string[] TLD => new [] { ".io" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "246" };
	}
}
