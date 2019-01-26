namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Rwanda
	/// </summary>
	public class RwandaInfo : ICountryInfo
	{
		public string CommonName => "Rwanda";
		public string OfficialName => "Republic of Rwanda";

		public Alpha2Code Alpha2Code => Alpha2Code.RW;
		public Alpha3Code Alpha3Code => Alpha3Code.RWA;
		public int NumericCode => 646;
		public string[] TLD => new [] { ".rw" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BI,
			Alpha2Code.CD,
			Alpha2Code.TZ,
			Alpha2Code.UG,
		};

		public string[] Currencies => new [] { "RWF" };
		public string[] CallingCodes => new [] { "250" };
	}
}
