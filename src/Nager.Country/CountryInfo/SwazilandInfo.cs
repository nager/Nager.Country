namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Swaziland
	/// </summary>
	public class SwazilandInfo : ICountryInfo
	{
		public string CommonName => "Swaziland";
		public string OfficialName => "Kingdom of Swaziland";

		public Alpha2Code Alpha2Code => Alpha2Code.SZ;
		public Alpha3Code Alpha3Code => Alpha3Code.SWZ;
		public int NumericCode => 748;
		public string[] TLD => new [] { ".sz" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.SouthernAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.MZ,
			Alpha2Code.ZA,
		};

		public string[] Currencies => new [] { "SZL" };
		public string[] CallingCodes => new [] { "268" };
	}
}
