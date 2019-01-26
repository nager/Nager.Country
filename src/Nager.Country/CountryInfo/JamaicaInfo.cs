namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Jamaica
	/// </summary>
	public class JamaicaInfo : ICountryInfo
	{
		public string CommonName => "Jamaica";
		public string OfficialName => "Jamaica";

		public Alpha2Code Alpha2Code => Alpha2Code.JM;
		public Alpha3Code Alpha3Code => Alpha3Code.JAM;
		public int NumericCode => 388;
		public string[] TLD => new [] { ".jm" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "JMD" };
		public string[] CallingCodes => new [] { "1876" };
	}
}
