namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Faroe Islands
	/// </summary>
	public class FaroeIslandsInfo : ICountryInfo
	{
		public string CommonName => "Faroe Islands";
		public string OfficialName => "Faroe Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.FO;
		public Alpha3Code Alpha3Code => Alpha3Code.FRO;
		public int NumericCode => 234;
		public string[] TLD => new [] { ".fo" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "DKK" };
		public string[] CallingCodes => new [] { "298" };
	}
}
