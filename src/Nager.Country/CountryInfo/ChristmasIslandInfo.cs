namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Christmas Island
	/// </summary>
	public class ChristmasIslandInfo : ICountryInfo
	{
		public string CommonName => "Christmas Island";
		public string OfficialName => "Territory of Christmas Island";

		public Alpha2Code Alpha2Code => Alpha2Code.CX;
		public Alpha3Code Alpha3Code => Alpha3Code.CXR;
		public int NumericCode => 162;
		public string[] TLD => new [] { ".cx" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.AustraliaandNewZealand;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "AUD" };
		public string[] CallingCodes => new [] { "61" };
	}
}
