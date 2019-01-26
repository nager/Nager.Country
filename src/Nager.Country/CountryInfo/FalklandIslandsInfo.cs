namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Falkland Islands
	/// </summary>
	public class FalklandIslandsInfo : ICountryInfo
	{
		public string CommonName => "Falkland Islands";
		public string OfficialName => "Falkland Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.FK;
		public Alpha3Code Alpha3Code => Alpha3Code.FLK;
		public int NumericCode => 238;
		public string[] TLD => new [] { ".fk" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "FKP" };
		public string[] CallingCodes => new [] { "500" };
	}
}
