namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Vietnam
	/// </summary>
	public class VietnamInfo : ICountryInfo
	{
		public string CommonName => "Vietnam";
		public string OfficialName => "Socialist Republic of Vietnam";

		public Alpha2Code Alpha2Code => Alpha2Code.VN;
		public Alpha3Code Alpha3Code => Alpha3Code.VNM;
		public int NumericCode => 704;
		public string[] TLD => new [] { ".vn" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthEasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.KH,
			Alpha2Code.CN,
			Alpha2Code.LA,
		};

		public string[] Currencies => new [] { "VND" };
		public string[] CallingCodes => new [] { "84" };
	}
}
