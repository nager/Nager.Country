namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Saint Kitts and Nevis
	/// </summary>
	public class SaintKittsandNevisInfo : ICountryInfo
	{
		public string CommonName => "Saint Kitts and Nevis";
		public string OfficialName => "Federation of Saint Christopher and Nevisa";

		public Alpha2Code Alpha2Code => Alpha2Code.KN;
		public Alpha3Code Alpha3Code => Alpha3Code.KNA;
		public int NumericCode => 659;
		public string[] TLD => new [] { ".kn" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XCD" };
		public string[] CallingCodes => new [] { "1869" };
	}
}
