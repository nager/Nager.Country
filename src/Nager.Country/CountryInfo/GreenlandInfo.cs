namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Greenland
	/// </summary>
	public class GreenlandInfo : ICountryInfo
	{
		public string CommonName => "Greenland";
		public string OfficialName => "Greenland";

		public Alpha2Code Alpha2Code => Alpha2Code.GL;
		public Alpha3Code Alpha3Code => Alpha3Code.GRL;
		public int NumericCode => 304;
		public string[] TLD => new [] { ".gl" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.NorthernAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "DKK" };
		public string[] CallingCodes => new [] { "299" };
	}
}
