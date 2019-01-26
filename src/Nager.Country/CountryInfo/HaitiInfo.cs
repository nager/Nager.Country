namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Haiti
	/// </summary>
	public class HaitiInfo : ICountryInfo
	{
		public string CommonName => "Haiti";
		public string OfficialName => "Republic of Haiti";

		public Alpha2Code Alpha2Code => Alpha2Code.HT;
		public Alpha3Code Alpha3Code => Alpha3Code.HTI;
		public int NumericCode => 332;
		public string[] TLD => new [] { ".ht" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DO,
		};

		public string[] Currencies => new [] { "HTG", "USD" };
		public string[] CallingCodes => new [] { "509" };
	}
}
