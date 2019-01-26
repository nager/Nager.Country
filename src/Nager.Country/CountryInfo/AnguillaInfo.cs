namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Anguilla
	/// </summary>
	public class AnguillaInfo : ICountryInfo
	{
		public string CommonName => "Anguilla";
		public string OfficialName => "Anguilla";

		public Alpha2Code Alpha2Code => Alpha2Code.AI;
		public Alpha3Code Alpha3Code => Alpha3Code.AIA;
		public int NumericCode => 660;
		public string[] TLD => new [] { ".ai" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XCD" };
		public string[] CallingCodes => new [] { "1264" };
	}
}
