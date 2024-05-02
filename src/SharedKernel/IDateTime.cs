using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel;

public interface IDateTime
{
    public DateTimeOffset Now => DateTimeOffset.UtcNow;
}
