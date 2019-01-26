namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Taiwan
	/// </summary>
	public class TaiwanInfo : ICountryInfo
	{
		public string CommonName => "Taiwan";
		public string OfficialName => "Republic of China";

		public Alpha2Code Alpha2Code => Alpha2Code.TW;
		public Alpha3Code Alpha3Code => Alpha3Code.TWN;
		public int NumericCode => 158;
		public string[] TLD => new [] { ".tw", ".台湾", ".台灣" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.EasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "TWD" };
		public string[] CallingCodes => new [] { "886" };
	}
}
