using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangfire.Application.Interfaces.Service
{
    public interface IQuartoJobService
    {
        Task ExecuteJobAsync();
    }
}
