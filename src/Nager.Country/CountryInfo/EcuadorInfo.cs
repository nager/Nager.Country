namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Ecuador
	/// </summary>
	public class EcuadorInfo : ICountryInfo
	{
		public string CommonName => "Ecuador";
		public string OfficialName => "Republic of Ecuador";

		public Alpha2Code Alpha2Code => Alpha2Code.EC;
		public Alpha3Code Alpha3Code => Alpha3Code.ECU;
		public int NumericCode => 218;
		public string[] TLD => new [] { ".ec" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CO,
			Alpha2Code.PE,
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "593" };
	}
}
