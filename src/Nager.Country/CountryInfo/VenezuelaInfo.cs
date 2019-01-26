namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Venezuela
	/// </summary>
	public class VenezuelaInfo : ICountryInfo
	{
		public string CommonName => "Venezuela";
		public string OfficialName => "Bolivarian Republic of Venezuela";

		public Alpha2Code Alpha2Code => Alpha2Code.VE;
		public Alpha3Code Alpha3Code => Alpha3Code.VEN;
		public int NumericCode => 862;
		public string[] TLD => new [] { ".ve" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BR,
			Alpha2Code.CO,
			Alpha2Code.GY,
		};

		public string[] Currencies => new [] { "VEF" };
		public string[] CallingCodes => new [] { "58" };
	}
}
