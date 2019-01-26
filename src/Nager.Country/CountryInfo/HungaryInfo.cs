namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Hungary
	/// </summary>
	public class HungaryInfo : ICountryInfo
	{
		public string CommonName => "Hungary";
		public string OfficialName => "Hungary";

		public Alpha2Code Alpha2Code => Alpha2Code.HU;
		public Alpha3Code Alpha3Code => Alpha3Code.HUN;
		public int NumericCode => 348;
		public string[] TLD => new [] { ".hu" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.EasternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AT,
			Alpha2Code.HR,
			Alpha2Code.RO,
			Alpha2Code.RS,
			Alpha2Code.SK,
			Alpha2Code.SI,
			Alpha2Code.UA,
		};

		public string[] Currencies => new [] { "HUF" };
		public string[] CallingCodes => new [] { "36" };
	}
}
