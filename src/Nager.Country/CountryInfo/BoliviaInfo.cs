namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Bolivia
	/// </summary>
	public class BoliviaInfo : ICountryInfo
	{
		public string CommonName => "Bolivia";
		public string OfficialName => "Plurinational State of Bolivia";

		public Alpha2Code Alpha2Code => Alpha2Code.BO;
		public Alpha3Code Alpha3Code => Alpha3Code.BOL;
		public int NumericCode => 068;
		public string[] TLD => new [] { ".bo" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AR,
			Alpha2Code.BR,
			Alpha2Code.CL,
			Alpha2Code.PY,
			Alpha2Code.PE,
		};

		public string[] Currencies => new [] { "BOB", "BOV" };
		public string[] CallingCodes => new [] { "591" };
	}
}
