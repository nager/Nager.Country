namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// New Zealand
	/// </summary>
	public class NewZealandInfo : ICountryInfo
	{
		public string CommonName => "New Zealand";
		public string OfficialName => "New Zealand";

		public Alpha2Code Alpha2Code => Alpha2Code.NZ;
		public Alpha3Code Alpha3Code => Alpha3Code.NZL;
		public int NumericCode => 554;
		public string[] TLD => new [] { ".nz" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.AustraliaandNewZealand;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "NZD" };
		public string[] CallingCodes => new [] { "64" };
	}
}
