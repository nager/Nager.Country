namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Bulgaria
	/// </summary>
	public class BulgariaInfo : ICountryInfo
	{
		public string CommonName => "Bulgaria";
		public string OfficialName => "Republic of Bulgaria";

		public Alpha2Code Alpha2Code => Alpha2Code.BG;
		public Alpha3Code Alpha3Code => Alpha3Code.BGR;
		public int NumericCode => 100;
		public string[] TLD => new [] { ".bg" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.EasternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.GR,
			Alpha2Code.MK,
			Alpha2Code.RO,
			Alpha2Code.RS,
			Alpha2Code.TR,
		};

		public string[] Currencies => new [] { "BGN" };
		public string[] CallingCodes => new [] { "359" };
	}
}
