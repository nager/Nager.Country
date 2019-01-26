namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Bouvet Island
	/// </summary>
	public class BouvetIslandInfo : ICountryInfo
	{
		public string CommonName => "Bouvet Island";
		public string OfficialName => "Bouvet Island";

		public Alpha2Code Alpha2Code => Alpha2Code.BV;
		public Alpha3Code Alpha3Code => Alpha3Code.BVT;
		public int NumericCode => 074;
		public string[] TLD => new [] { ".bv" };

		public Region Region => Region.None;
		public SubRegion SubRegion => SubRegion.None;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "NOK" };
		public string[] CallingCodes => new string[0];
	}
}
