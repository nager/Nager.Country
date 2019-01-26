namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Palau
	/// </summary>
	public class PalauInfo : ICountryInfo
	{
		public string CommonName => "Palau";
		public string OfficialName => "Republic of Palau";

		public Alpha2Code Alpha2Code => Alpha2Code.PW;
		public Alpha3Code Alpha3Code => Alpha3Code.PLW;
		public int NumericCode => 585;
		public string[] TLD => new [] { ".pw" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Micronesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "680" };
	}
}
