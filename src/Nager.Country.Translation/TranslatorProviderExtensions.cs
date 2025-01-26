namespace Nager.Country.Translation;

public static class TranslatorProviderExtensions
{
	public static string GetCountryTranslatedOrCommonName( this ITranslationProvider provider,
		Alpha2Code alpha2Code,
		LanguageCode languageCode,
		ICountryProvider countryProvider )
	{
		ICountryTranslation translation = provider.GetCountryTranslation( alpha2Code );
		
		TranslationInfo countryTranslation =
			translation.Translations.FirstOrDefault( x => x.LanguageCode == languageCode );

		if( countryTranslation != null )
		{
			return countryTranslation.Name;
		}

		return countryProvider.GetCountry( alpha2Code ).CommonName;
	}
}