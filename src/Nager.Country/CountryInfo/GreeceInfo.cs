namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Greece
	/// </summary>
	public class GreeceInfo : ICountryInfo
	{
		public string CommonName => "Greece";
		public string OfficialName => "Hellenic Republic";

		public Alpha2Code Alpha2Code => Alpha2Code.GR;
		public Alpha3Code Alpha3Code => Alpha3Code.GRC;
		public int NumericCode => 300;
		public string[] TLD => new [] { ".gr" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AL,
			Alpha2Code.BG,
			Alpha2Code.TR,
			Alpha2Code.MK,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "30" };
	}
}
