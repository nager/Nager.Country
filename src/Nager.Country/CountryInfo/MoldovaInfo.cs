namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Moldova
	/// </summary>
	public class MoldovaInfo : ICountryInfo
	{
		public string CommonName => "Moldova";
		public string OfficialName => "Republic of Moldova";

		public Alpha2Code Alpha2Code => Alpha2Code.MD;
		public Alpha3Code Alpha3Code => Alpha3Code.MDA;
		public int NumericCode => 498;
		public string[] TLD => new [] { ".md" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.EasternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.RO,
			Alpha2Code.UA,
		};

		public string[] Currencies => new [] { "MDL" };
		public string[] CallingCodes => new [] { "373" };
	}
}
