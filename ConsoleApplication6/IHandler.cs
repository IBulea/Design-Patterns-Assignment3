using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Handlers
{
    public interface IHandler
    {
        Response Approve(IReport report);
        void SetNext(IHandler next);
    }
}
