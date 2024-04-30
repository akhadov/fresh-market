using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace SharedKernel.Exceptions;

public static class Ensure
{
    public static void NotNullOrEmpty(
        [NotNull] string? value,
        [CallerArgumentExpression("value")] string? paramName = default)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException(paramName);
        }
    }

    public static void NotNull(
        [NotNull] object? value,
        [CallerArgumentExpression("value")] string? paramName = default)
    {
        if (value is null)
        {
            throw new ArgumentNullException(paramName);
        }
    }

    public static void GreaterThanZero(
        decimal value,
        [CallerArgumentExpression("value")] string? paramName = default)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(paramName);
        }
    }

    public static void StartDatePrecedesEndDate(
        DateTime start,
        DateTime end,
        [CallerArgumentExpression("end")] string? paramName = default)
    {
        if (start >= end)
        {
            throw new ArgumentOutOfRangeException(paramName);
        }
    }
}
