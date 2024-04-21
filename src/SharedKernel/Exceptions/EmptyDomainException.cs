namespace SharedKernel.Exceptions;

public class EmptyDomainException : DomainException
{
    public EmptyDomainException(string msg) : base(msg)
    {
    }
}
