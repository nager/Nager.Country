namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// North Korea
	/// </summary>
	public class NorthKoreaInfo : ICountryInfo
	{
		public string CommonName => "North Korea";
		public string OfficialName => "Democratic People's Republic of Korea";

		public Alpha2Code Alpha2Code => Alpha2Code.KP;
		public Alpha3Code Alpha3Code => Alpha3Code.PRK;
		public int NumericCode => 408;
		public string[] TLD => new [] { ".kp" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.EasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CN,
			Alpha2Code.KR,
			Alpha2Code.RU,
		};

		public string[] Currencies => new [] { "KPW" };
		public string[] CallingCodes => new [] { "850" };
	}
}
