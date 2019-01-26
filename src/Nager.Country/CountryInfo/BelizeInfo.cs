namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Belize
	/// </summary>
	public class BelizeInfo : ICountryInfo
	{
		public string CommonName => "Belize";
		public string OfficialName => "Belize";

		public Alpha2Code Alpha2Code => Alpha2Code.BZ;
		public Alpha3Code Alpha3Code => Alpha3Code.BLZ;
		public int NumericCode => 084;
		public string[] TLD => new [] { ".bz" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.CentralAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.GT,
			Alpha2Code.MX,
		};

		public string[] Currencies => new [] { "BZD" };
		public string[] CallingCodes => new [] { "501" };
	}
}
