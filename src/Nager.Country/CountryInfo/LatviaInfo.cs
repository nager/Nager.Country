namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Latvia
	/// </summary>
	public class LatviaInfo : ICountryInfo
	{
		public string CommonName => "Latvia";
		public string OfficialName => "Republic of Latvia";

		public Alpha2Code Alpha2Code => Alpha2Code.LV;
		public Alpha3Code Alpha3Code => Alpha3Code.LVA;
		public int NumericCode => 428;
		public string[] TLD => new [] { ".lv" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BY,
			Alpha2Code.EE,
			Alpha2Code.LT,
			Alpha2Code.RU,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "371" };
	}
}
