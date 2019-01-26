namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Cambodia
	/// </summary>
	public class CambodiaInfo : ICountryInfo
	{
		public string CommonName => "Cambodia";
		public string OfficialName => "Kingdom of Cambodia";

		public Alpha2Code Alpha2Code => Alpha2Code.KH;
		public Alpha3Code Alpha3Code => Alpha3Code.KHM;
		public int NumericCode => 116;
		public string[] TLD => new [] { ".kh" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthEasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.LA,
			Alpha2Code.TH,
			Alpha2Code.VN,
		};

		public string[] Currencies => new [] { "KHR" };
		public string[] CallingCodes => new [] { "855" };
	}
}
