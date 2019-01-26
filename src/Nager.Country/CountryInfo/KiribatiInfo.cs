namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Kiribati
	/// </summary>
	public class KiribatiInfo : ICountryInfo
	{
		public string CommonName => "Kiribati";
		public string OfficialName => "Independent and Sovereign Republic of Kiribati";

		public Alpha2Code Alpha2Code => Alpha2Code.KI;
		public Alpha3Code Alpha3Code => Alpha3Code.KIR;
		public int NumericCode => 296;
		public string[] TLD => new [] { ".ki" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Micronesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "AUD" };
		public string[] CallingCodes => new [] { "686" };
	}
}
