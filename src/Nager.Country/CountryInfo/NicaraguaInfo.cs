namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Nicaragua
	/// </summary>
	public class NicaraguaInfo : ICountryInfo
	{
		public string CommonName => "Nicaragua";
		public string OfficialName => "Republic of Nicaragua";

		public Alpha2Code Alpha2Code => Alpha2Code.NI;
		public Alpha3Code Alpha3Code => Alpha3Code.NIC;
		public int NumericCode => 558;
		public string[] TLD => new [] { ".ni" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.CentralAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CR,
			Alpha2Code.HN,
		};

		public string[] Currencies => new [] { "NIO" };
		public string[] CallingCodes => new [] { "505" };
	}
}
