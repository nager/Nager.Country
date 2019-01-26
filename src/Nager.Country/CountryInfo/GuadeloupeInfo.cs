namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Guadeloupe
	/// </summary>
	public class GuadeloupeInfo : ICountryInfo
	{
		public string CommonName => "Guadeloupe";
		public string OfficialName => "Guadeloupe";

		public Alpha2Code Alpha2Code => Alpha2Code.GP;
		public Alpha3Code Alpha3Code => Alpha3Code.GLP;
		public int NumericCode => 312;
		public string[] TLD => new [] { ".gp" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "590" };
	}
}
