namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// United States Minor Outlying Islands
	/// </summary>
	public class UnitedStatesMinorOutlyingIslandsInfo : ICountryInfo
	{
		public string CommonName => "United States Minor Outlying Islands";
		public string OfficialName => "United States Minor Outlying Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.UM;
		public Alpha3Code Alpha3Code => Alpha3Code.UMI;
		public int NumericCode => 581;
		public string[] TLD => new [] { ".us" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.NorthernAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new string[0];
	}
}
