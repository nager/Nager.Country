namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Comoros
	/// </summary>
	public class ComorosInfo : ICountryInfo
	{
		public string CommonName => "Comoros";
		public string OfficialName => "Union of the Comoros";

		public Alpha2Code Alpha2Code => Alpha2Code.KM;
		public Alpha3Code Alpha3Code => Alpha3Code.COM;
		public int NumericCode => 174;
		public string[] TLD => new [] { ".km" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "KMF" };
		public string[] CallingCodes => new [] { "269" };
	}
}
