namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Cocos (Keeling) Islands
	/// </summary>
	public class CocosIslandsInfo : ICountryInfo
	{
		public string CommonName => "Cocos (Keeling) Islands";
		public string OfficialName => "Territory of the Cocos (Keeling) Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.CC;
		public Alpha3Code Alpha3Code => Alpha3Code.CCK;
		public int NumericCode => 166;
		public string[] TLD => new [] { ".cc" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.AustraliaandNewZealand;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "AUD" };
		public string[] CallingCodes => new [] { "61" };
	}
}
