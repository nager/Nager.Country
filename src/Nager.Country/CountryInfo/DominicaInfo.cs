namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Dominica
	/// </summary>
	public class DominicaInfo : ICountryInfo
	{
		public string CommonName => "Dominica";
		public string OfficialName => "Commonwealth of Dominica";

		public Alpha2Code Alpha2Code => Alpha2Code.DM;
		public Alpha3Code Alpha3Code => Alpha3Code.DMA;
		public int NumericCode => 212;
		public string[] TLD => new [] { ".dm" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XCD" };
		public string[] CallingCodes => new [] { "1767" };
	}
}
