namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Gibraltar
	/// </summary>
	public class GibraltarInfo : ICountryInfo
	{
		public string CommonName => "Gibraltar";
		public string OfficialName => "Gibraltar";

		public Alpha2Code Alpha2Code => Alpha2Code.GI;
		public Alpha3Code Alpha3Code => Alpha3Code.GIB;
		public int NumericCode => 292;
		public string[] TLD => new [] { ".gi" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.ES,
		};

		public string[] Currencies => new [] { "GIP" };
		public string[] CallingCodes => new [] { "350" };
	}
}
