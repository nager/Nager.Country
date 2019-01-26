namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Saint Lucia
	/// </summary>
	public class SaintLuciaInfo : ICountryInfo
	{
		public string CommonName => "Saint Lucia";
		public string OfficialName => "Saint Lucia";

		public Alpha2Code Alpha2Code => Alpha2Code.LC;
		public Alpha3Code Alpha3Code => Alpha3Code.LCA;
		public int NumericCode => 662;
		public string[] TLD => new [] { ".lc" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XCD" };
		public string[] CallingCodes => new [] { "1758" };
	}
}
