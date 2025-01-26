namespace Nager.Country.Subdivision;

public static class SubdivisionCodeExtensions
{
	public static Alpha2Code GetAlpha2Code( this SubdivisionCode subdivisionCode )
	{
		// get name
		string subdivisionName = Enum.GetName( typeof( SubdivisionCode ), subdivisionCode );
		if( subdivisionName == null )
		{
			throw new UnknownSubdivisionException( $"Cannot found subdivisions for subdivision code {subdivisionCode}" );
		}
		
		// get alpha code 2 part
		string alpha2Part = subdivisionName.Substring( 0, 2 );
		if( Enum.TryParse( alpha2Part, out Alpha2Code alpha2Code ) )
		{
			return alpha2Code;
		}
		throw new UnknownSubdivisionException( $"Cannot found alpha2code for subdivision code {subdivisionCode}" );
	}
}