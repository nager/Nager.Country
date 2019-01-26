namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Papua New Guinea
	/// </summary>
	public class PapuaNewGuineaInfo : ICountryInfo
	{
		public string CommonName => "Papua New Guinea";
		public string OfficialName => "Independent State of Papua New Guinea";

		public Alpha2Code Alpha2Code => Alpha2Code.PG;
		public Alpha3Code Alpha3Code => Alpha3Code.PNG;
		public int NumericCode => 598;
		public string[] TLD => new [] { ".pg" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Melanesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.ID,
		};

		public string[] Currencies => new [] { "PGK" };
		public string[] CallingCodes => new [] { "675" };
	}
}
