namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Cuba
	/// </summary>
	public class CubaInfo : ICountryInfo
	{
		public string CommonName => "Cuba";
		public string OfficialName => "Republic of Cuba";

		public Alpha2Code Alpha2Code => Alpha2Code.CU;
		public Alpha3Code Alpha3Code => Alpha3Code.CUB;
		public int NumericCode => 192;
		public string[] TLD => new [] { ".cu" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "CUC", "CUP" };
		public string[] CallingCodes => new [] { "53" };
	}
}
