namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Pitcairn Islands
	/// </summary>
	public class PitcairnIslandsInfo : ICountryInfo
	{
		public string CommonName => "Pitcairn Islands";
		public string OfficialName => "Pitcairn Group of Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.PN;
		public Alpha3Code Alpha3Code => Alpha3Code.PCN;
		public int NumericCode => 612;
		public string[] TLD => new [] { ".pn" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Polynesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "NZD" };
		public string[] CallingCodes => new [] { "64" };
	}
}
