namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// United States
	/// </summary>
	public class UnitedStatesInfo : ICountryInfo
	{
		public string CommonName => "United States";
		public string OfficialName => "United States of America";

		public Alpha2Code Alpha2Code => Alpha2Code.US;
		public Alpha3Code Alpha3Code => Alpha3Code.USA;
		public int NumericCode => 840;
		public string[] TLD => new [] { ".us" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.NorthernAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CA,
			Alpha2Code.MX,
		};

		public string[] Currencies => new [] { "USD", "USN", "USS" };
		public string[] CallingCodes => new [] { "1" };
	}
}
