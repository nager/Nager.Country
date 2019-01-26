namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Costa Rica
	/// </summary>
	public class CostaRicaInfo : ICountryInfo
	{
		public string CommonName => "Costa Rica";
		public string OfficialName => "Republic of Costa Rica";

		public Alpha2Code Alpha2Code => Alpha2Code.CR;
		public Alpha3Code Alpha3Code => Alpha3Code.CRI;
		public int NumericCode => 188;
		public string[] TLD => new [] { ".cr" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.CentralAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.NI,
			Alpha2Code.PA,
		};

		public string[] Currencies => new [] { "CRC" };
		public string[] CallingCodes => new [] { "506" };
	}
}
