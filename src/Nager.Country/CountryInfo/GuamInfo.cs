namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Guam
	/// </summary>
	public class GuamInfo : ICountryInfo
	{
		public string CommonName => "Guam";
		public string OfficialName => "Guam";

		public Alpha2Code Alpha2Code => Alpha2Code.GU;
		public Alpha3Code Alpha3Code => Alpha3Code.GUM;
		public int NumericCode => 316;
		public string[] TLD => new [] { ".gu" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Micronesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "1671" };
	}
}
