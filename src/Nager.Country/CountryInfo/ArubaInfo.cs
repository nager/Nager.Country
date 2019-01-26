namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Aruba
	/// </summary>
	public class ArubaInfo : ICountryInfo
	{
		public string CommonName => "Aruba";
		public string OfficialName => "Aruba";

		public Alpha2Code Alpha2Code => Alpha2Code.AW;
		public Alpha3Code Alpha3Code => Alpha3Code.ABW;
		public int NumericCode => 533;
		public string[] TLD => new [] { ".aw" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "AWG" };
		public string[] CallingCodes => new [] { "297" };
	}
}
