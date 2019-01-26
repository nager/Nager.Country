namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Madagascar
	/// </summary>
	public class MadagascarInfo : ICountryInfo
	{
		public string CommonName => "Madagascar";
		public string OfficialName => "Republic of Madagascar";

		public Alpha2Code Alpha2Code => Alpha2Code.MG;
		public Alpha3Code Alpha3Code => Alpha3Code.MDG;
		public int NumericCode => 450;
		public string[] TLD => new [] { ".mg" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "MGA" };
		public string[] CallingCodes => new [] { "261" };
	}
}
