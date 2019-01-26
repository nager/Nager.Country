namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Mexico
	/// </summary>
	public class MexicoInfo : ICountryInfo
	{
		public string CommonName => "Mexico";
		public string OfficialName => "United Mexican States";

		public Alpha2Code Alpha2Code => Alpha2Code.MX;
		public Alpha3Code Alpha3Code => Alpha3Code.MEX;
		public int NumericCode => 484;
		public string[] TLD => new [] { ".mx" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.CentralAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BZ,
			Alpha2Code.GT,
			Alpha2Code.US,
		};

		public string[] Currencies => new [] { "MXN" };
		public string[] CallingCodes => new [] { "52" };
	}
}
