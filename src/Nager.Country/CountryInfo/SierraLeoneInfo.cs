namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Sierra Leone
	/// </summary>
	public class SierraLeoneInfo : ICountryInfo
	{
		public string CommonName => "Sierra Leone";
		public string OfficialName => "Republic of Sierra Leone";

		public Alpha2Code Alpha2Code => Alpha2Code.SL;
		public Alpha3Code Alpha3Code => Alpha3Code.SLE;
		public int NumericCode => 694;
		public string[] TLD => new [] { ".sl" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.GN,
			Alpha2Code.LR,
		};

		public string[] Currencies => new [] { "SLL" };
		public string[] CallingCodes => new [] { "232" };
	}
}
