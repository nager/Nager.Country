namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Mauritius
	/// </summary>
	public class MauritiusInfo : ICountryInfo
	{
		public string CommonName => "Mauritius";
		public string OfficialName => "Republic of Mauritius";

		public Alpha2Code Alpha2Code => Alpha2Code.MU;
		public Alpha3Code Alpha3Code => Alpha3Code.MUS;
		public int NumericCode => 480;
		public string[] TLD => new [] { ".mu" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "MUR" };
		public string[] CallingCodes => new [] { "230" };
	}
}
