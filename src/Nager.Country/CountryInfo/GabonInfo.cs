namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Gabon
	/// </summary>
	public class GabonInfo : ICountryInfo
	{
		public string CommonName => "Gabon";
		public string OfficialName => "Gabonese Republic";

		public Alpha2Code Alpha2Code => Alpha2Code.GA;
		public Alpha3Code Alpha3Code => Alpha3Code.GAB;
		public int NumericCode => 266;
		public string[] TLD => new [] { ".ga" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.MiddleAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CM,
			Alpha2Code.CG,
			Alpha2Code.GQ,
		};

		public string[] Currencies => new [] { "XAF" };
		public string[] CallingCodes => new [] { "241" };
	}
}
