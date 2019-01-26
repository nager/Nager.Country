namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Australia
	/// </summary>
	public class AustraliaInfo : ICountryInfo
	{
		public string CommonName => "Australia";
		public string OfficialName => "Commonwealth of Australia";

		public Alpha2Code Alpha2Code => Alpha2Code.AU;
		public Alpha3Code Alpha3Code => Alpha3Code.AUS;
		public int NumericCode => 036;
		public string[] TLD => new [] { ".au" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.AustraliaandNewZealand;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "AUD" };
		public string[] CallingCodes => new [] { "61" };
	}
}
