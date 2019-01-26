namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Norfolk Island
	/// </summary>
	public class NorfolkIslandInfo : ICountryInfo
	{
		public string CommonName => "Norfolk Island";
		public string OfficialName => "Territory of Norfolk Island";

		public Alpha2Code Alpha2Code => Alpha2Code.NF;
		public Alpha3Code Alpha3Code => Alpha3Code.NFK;
		public int NumericCode => 574;
		public string[] TLD => new [] { ".nf" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.AustraliaandNewZealand;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "AUD" };
		public string[] CallingCodes => new [] { "672" };
	}
}
