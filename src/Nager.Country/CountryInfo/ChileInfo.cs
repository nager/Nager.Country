namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Chile
	/// </summary>
	public class ChileInfo : ICountryInfo
	{
		public string CommonName => "Chile";
		public string OfficialName => "Republic of Chile";

		public Alpha2Code Alpha2Code => Alpha2Code.CL;
		public Alpha3Code Alpha3Code => Alpha3Code.CHL;
		public int NumericCode => 152;
		public string[] TLD => new [] { ".cl" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AR,
			Alpha2Code.BO,
			Alpha2Code.PE,
		};

		public string[] Currencies => new [] { "CLF", "CLP" };
		public string[] CallingCodes => new [] { "56" };
	}
}
