namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Bahamas
	/// </summary>
	public class BahamasInfo : ICountryInfo
	{
		public string CommonName => "Bahamas";
		public string OfficialName => "Commonwealth of the Bahamas";

		public Alpha2Code Alpha2Code => Alpha2Code.BS;
		public Alpha3Code Alpha3Code => Alpha3Code.BHS;
		public int NumericCode => 044;
		public string[] TLD => new [] { ".bs" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "BSD" };
		public string[] CallingCodes => new [] { "1242" };
	}
}
