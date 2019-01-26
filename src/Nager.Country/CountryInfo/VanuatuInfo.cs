namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Vanuatu
	/// </summary>
	public class VanuatuInfo : ICountryInfo
	{
		public string CommonName => "Vanuatu";
		public string OfficialName => "Republic of Vanuatu";

		public Alpha2Code Alpha2Code => Alpha2Code.VU;
		public Alpha3Code Alpha3Code => Alpha3Code.VUT;
		public int NumericCode => 548;
		public string[] TLD => new [] { ".vu" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Melanesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "VUV" };
		public string[] CallingCodes => new [] { "678" };
	}
}
