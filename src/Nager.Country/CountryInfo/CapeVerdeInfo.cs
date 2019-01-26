namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Cape Verde
	/// </summary>
	public class CapeVerdeInfo : ICountryInfo
	{
		public string CommonName => "Cape Verde";
		public string OfficialName => "Republic of Cabo Verde";

		public Alpha2Code Alpha2Code => Alpha2Code.CV;
		public Alpha3Code Alpha3Code => Alpha3Code.CPV;
		public int NumericCode => 132;
		public string[] TLD => new [] { ".cv" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "CVE" };
		public string[] CallingCodes => new [] { "238" };
	}
}
