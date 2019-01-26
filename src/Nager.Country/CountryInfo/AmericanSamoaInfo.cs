namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// American Samoa
	/// </summary>
	public class AmericanSamoaInfo : ICountryInfo
	{
		public string CommonName => "American Samoa";
		public string OfficialName => "American Samoa";

		public Alpha2Code Alpha2Code => Alpha2Code.AS;
		public Alpha3Code Alpha3Code => Alpha3Code.ASM;
		public int NumericCode => 016;
		public string[] TLD => new [] { ".as" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Polynesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "1684" };
	}
}
