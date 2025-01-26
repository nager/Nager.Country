using Nager.Country.Translation;

namespace Nager.Country.Subdivision;

public interface ISubdivisionTranslationProvider
{
	ISubdivisionTranslation GetSubdivisionTranslation( SubdivisionCode code );

	string GetSubdivisionTranslatedName( SubdivisionCode code, LanguageCode languageCode );

	string GetSubdivisionTranslatedOrCommonName( SubdivisionCode code, LanguageCode languageCode );
}