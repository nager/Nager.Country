namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// China
	/// </summary>
	public class ChinaInfo : ICountryInfo
	{
		public string CommonName => "China";
		public string OfficialName => "People's Republic of China";

		public Alpha2Code Alpha2Code => Alpha2Code.CN;
		public Alpha3Code Alpha3Code => Alpha3Code.CHN;
		public int NumericCode => 156;
		public string[] TLD => new [] { ".cn", ".中国", ".中國", ".公司", ".网络" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.EasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AF,
			Alpha2Code.BT,
			Alpha2Code.MM,
			Alpha2Code.HK,
			Alpha2Code.IN,
			Alpha2Code.KZ,
			Alpha2Code.KP,
			Alpha2Code.KG,
			Alpha2Code.LA,
			Alpha2Code.MO,
			Alpha2Code.MN,
			Alpha2Code.PK,
			Alpha2Code.RU,
			Alpha2Code.TJ,
			Alpha2Code.VN,
		};

		public string[] Currencies => new [] { "CNY" };
		public string[] CallingCodes => new [] { "86" };
	}
}
