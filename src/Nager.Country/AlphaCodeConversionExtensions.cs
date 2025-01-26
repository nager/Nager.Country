namespace Nager.Country;

public static class AlphaCodeConversionExtensions
{
	public static Alpha3Code ToAlpha3Code( this Alpha2Code code )
	{
		return (Alpha3Code)code;
	}

	public static Alpha2Code ToAlpha2Code( this Alpha3Code code )
	{
		return (Alpha2Code)code;
	}
}