namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Marshall Islands
	/// </summary>
	public class MarshallIslandsInfo : ICountryInfo
	{
		public string CommonName => "Marshall Islands";
		public string OfficialName => "Republic of the Marshall Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.MH;
		public Alpha3Code Alpha3Code => Alpha3Code.MHL;
		public int NumericCode => 584;
		public string[] TLD => new [] { ".mh" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Micronesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "692" };
	}
}
