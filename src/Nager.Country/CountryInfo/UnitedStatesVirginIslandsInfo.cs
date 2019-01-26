namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// United States Virgin Islands
	/// </summary>
	public class UnitedStatesVirginIslandsInfo : ICountryInfo
	{
		public string CommonName => "United States Virgin Islands";
		public string OfficialName => "Virgin Islands of the United States";

		public Alpha2Code Alpha2Code => Alpha2Code.VI;
		public Alpha3Code Alpha3Code => Alpha3Code.VIR;
		public int NumericCode => 850;
		public string[] TLD => new [] { ".vi" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "1340" };
	}
}
