namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// South Korea
	/// </summary>
	public class SouthKoreaInfo : ICountryInfo
	{
		public string CommonName => "South Korea";
		public string OfficialName => "Republic of Korea";

		public Alpha2Code Alpha2Code => Alpha2Code.KR;
		public Alpha3Code Alpha3Code => Alpha3Code.KOR;
		public int NumericCode => 410;
		public string[] TLD => new [] { ".kr", ".한국" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.EasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.KP,
		};

		public string[] Currencies => new [] { "KRW" };
		public string[] CallingCodes => new [] { "82" };
	}
}
