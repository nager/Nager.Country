namespace Nager.Country.Subdivision;

public class UnknownSubdivisionException : Exception
{
	public UnknownSubdivisionException()
	{
	}

	public UnknownSubdivisionException( string message ) : base( message )
	{
		
	}
}