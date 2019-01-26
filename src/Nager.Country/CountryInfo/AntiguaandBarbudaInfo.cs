namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Antigua and Barbuda
	/// </summary>
	public class AntiguaandBarbudaInfo : ICountryInfo
	{
		public string CommonName => "Antigua and Barbuda";
		public string OfficialName => "Antigua and Barbuda";

		public Alpha2Code Alpha2Code => Alpha2Code.AG;
		public Alpha3Code Alpha3Code => Alpha3Code.ATG;
		public int NumericCode => 028;
		public string[] TLD => new [] { ".ag" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XCD" };
		public string[] CallingCodes => new [] { "1268" };
	}
}
