namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// British Virgin Islands
	/// </summary>
	public class BritishVirginIslandsInfo : ICountryInfo
	{
		public string CommonName => "British Virgin Islands";
		public string OfficialName => "Virgin Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.VG;
		public Alpha3Code Alpha3Code => Alpha3Code.VGB;
		public int NumericCode => 092;
		public string[] TLD => new [] { ".vg" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "1284" };
	}
}
