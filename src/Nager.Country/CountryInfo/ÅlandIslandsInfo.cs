namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Åland Islands
	/// </summary>
	public class ÅlandIslandsInfo : ICountryInfo
	{
		public string CommonName => "Åland Islands";
		public string OfficialName => "Åland Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.AX;
		public Alpha3Code Alpha3Code => Alpha3Code.ALA;
		public int NumericCode => 248;
		public string[] TLD => new [] { ".ax" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "358" };
	}
}
