namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Puerto Rico
	/// </summary>
	public class PuertoRicoInfo : ICountryInfo
	{
		public string CommonName => "Puerto Rico";
		public string OfficialName => "Commonwealth of Puerto Rico";

		public Alpha2Code Alpha2Code => Alpha2Code.PR;
		public Alpha3Code Alpha3Code => Alpha3Code.PRI;
		public int NumericCode => 630;
		public string[] TLD => new [] { ".pr" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "1787", "1939" };
	}
}
