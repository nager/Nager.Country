namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Tunisia
	/// </summary>
	public class TunisiaInfo : ICountryInfo
	{
		public string CommonName => "Tunisia";
		public string OfficialName => "Tunisian Republic";

		public Alpha2Code Alpha2Code => Alpha2Code.TN;
		public Alpha3Code Alpha3Code => Alpha3Code.TUN;
		public int NumericCode => 788;
		public string[] TLD => new [] { ".tn" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.NorthernAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DZ,
			Alpha2Code.LY,
		};

		public string[] Currencies => new [] { "TND" };
		public string[] CallingCodes => new [] { "216" };
	}
}
