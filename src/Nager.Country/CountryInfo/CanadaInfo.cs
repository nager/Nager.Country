namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Canada
	/// </summary>
	public class CanadaInfo : ICountryInfo
	{
		public string CommonName => "Canada";
		public string OfficialName => "Canada";

		public Alpha2Code Alpha2Code => Alpha2Code.CA;
		public Alpha3Code Alpha3Code => Alpha3Code.CAN;
		public int NumericCode => 124;
		public string[] TLD => new [] { ".ca" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.NorthernAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.US,
		};

		public string[] Currencies => new [] { "CAD" };
		public string[] CallingCodes => new [] { "1" };
	}
}
