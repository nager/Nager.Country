using Nager.Country.Translation;

namespace Nager.Country.Subdivision;

public class EmptySubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => [];
}