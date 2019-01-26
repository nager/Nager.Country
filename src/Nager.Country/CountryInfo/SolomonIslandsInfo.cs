namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Solomon Islands
	/// </summary>
	public class SolomonIslandsInfo : ICountryInfo
	{
		public string CommonName => "Solomon Islands";
		public string OfficialName => "Solomon Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.SB;
		public Alpha3Code Alpha3Code => Alpha3Code.SLB;
		public int NumericCode => 090;
		public string[] TLD => new [] { ".sb" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Melanesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "SDB" };
		public string[] CallingCodes => new [] { "677" };
	}
}
