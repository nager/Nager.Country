namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Uganda
	/// </summary>
	public class UgandaInfo : ICountryInfo
	{
		public string CommonName => "Uganda";
		public string OfficialName => "Republic of Uganda";

		public Alpha2Code Alpha2Code => Alpha2Code.UG;
		public Alpha3Code Alpha3Code => Alpha3Code.UGA;
		public int NumericCode => 800;
		public string[] TLD => new [] { ".ug" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CD,
			Alpha2Code.KE,
			Alpha2Code.RW,
			Alpha2Code.SS,
			Alpha2Code.TZ,
		};

		public string[] Currencies => new [] { "UGX" };
		public string[] CallingCodes => new [] { "256" };
	}
}
