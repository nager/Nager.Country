namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Indonesia
	/// </summary>
	public class IndonesiaInfo : ICountryInfo
	{
		public string CommonName => "Indonesia";
		public string OfficialName => "Republic of Indonesia";

		public Alpha2Code Alpha2Code => Alpha2Code.ID;
		public Alpha3Code Alpha3Code => Alpha3Code.IDN;
		public int NumericCode => 360;
		public string[] TLD => new [] { ".id" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthEasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.TL,
			Alpha2Code.MY,
			Alpha2Code.PG,
		};

		public string[] Currencies => new [] { "IDR" };
		public string[] CallingCodes => new [] { "62" };
	}
}
