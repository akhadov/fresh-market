namespace SharedKernel.Exceptions;

public class ConditionDomainException : DomainException
{
    public ConditionDomainException(string msg) : base(msg) { }
}
