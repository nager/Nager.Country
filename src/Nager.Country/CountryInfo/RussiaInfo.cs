namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Russia
	/// </summary>
	public class RussiaInfo : ICountryInfo
	{
		public string CommonName => "Russia";
		public string OfficialName => "Russian Federation";

		public Alpha2Code Alpha2Code => Alpha2Code.RU;
		public Alpha3Code Alpha3Code => Alpha3Code.RUS;
		public int NumericCode => 643;
		public string[] TLD => new [] { ".ru", ".su", ".рф" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.EasternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AZ,
			Alpha2Code.BY,
			Alpha2Code.CN,
			Alpha2Code.EE,
			Alpha2Code.FI,
			Alpha2Code.GE,
			Alpha2Code.KZ,
			Alpha2Code.KP,
			Alpha2Code.LV,
			Alpha2Code.LT,
			Alpha2Code.MN,
			Alpha2Code.NO,
			Alpha2Code.PL,
			Alpha2Code.UA,
		};

		public string[] Currencies => new [] { "RUB" };
		public string[] CallingCodes => new [] { "7" };
	}
}
