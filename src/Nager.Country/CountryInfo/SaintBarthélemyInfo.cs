namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Saint Barthélemy
	/// </summary>
	public class SaintBarthélemyInfo : ICountryInfo
	{
		public string CommonName => "Saint Barthélemy";
		public string OfficialName => "Collectivity of Saint BarthélemySaint Barthélemy";

		public Alpha2Code Alpha2Code => Alpha2Code.BL;
		public Alpha3Code Alpha3Code => Alpha3Code.BLM;
		public int NumericCode => 652;
		public string[] TLD => new [] { ".bl" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "590" };
	}
}
