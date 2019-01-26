namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Micronesia
	/// </summary>
	public class MicronesiaInfo : ICountryInfo
	{
		public string CommonName => "Micronesia";
		public string OfficialName => "Federated States of Micronesia";

		public Alpha2Code Alpha2Code => Alpha2Code.FM;
		public Alpha3Code Alpha3Code => Alpha3Code.FSM;
		public int NumericCode => 583;
		public string[] TLD => new [] { ".fm" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Micronesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "691" };
	}
}
