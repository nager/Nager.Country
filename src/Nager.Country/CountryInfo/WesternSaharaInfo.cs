namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Western Sahara
	/// </summary>
	public class WesternSaharaInfo : ICountryInfo
	{
		public string CommonName => "Western Sahara";
		public string OfficialName => "Sahrawi Arab Democratic Republic";

		public Alpha2Code Alpha2Code => Alpha2Code.EH;
		public Alpha3Code Alpha3Code => Alpha3Code.ESH;
		public int NumericCode => 732;
		public string[] TLD => new [] { ".eh" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.NorthernAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DZ,
			Alpha2Code.MR,
			Alpha2Code.MA,
		};

		public string[] Currencies => new [] { "MAD", "DZD", "MRO" };
		public string[] CallingCodes => new [] { "212" };
	}
}
