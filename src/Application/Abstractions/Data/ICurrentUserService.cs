using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.Data;

public interface ICurrentUserService
{
    public string? UserId { get; }
}
