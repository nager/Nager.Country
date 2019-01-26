namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Burundi
	/// </summary>
	public class BurundiInfo : ICountryInfo
	{
		public string CommonName => "Burundi";
		public string OfficialName => "Republic of Burundi";

		public Alpha2Code Alpha2Code => Alpha2Code.BI;
		public Alpha3Code Alpha3Code => Alpha3Code.BDI;
		public int NumericCode => 108;
		public string[] TLD => new [] { ".bi" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CD,
			Alpha2Code.RW,
			Alpha2Code.TZ,
		};

		public string[] Currencies => new [] { "BIF" };
		public string[] CallingCodes => new [] { "257" };
	}
}
