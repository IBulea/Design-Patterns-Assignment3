using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Handlers
{
    public class Handler : IHandler
    {
        private readonly IApprover current;
        private IHandler next;

        public Handler(IApprover approver)
        {
            current = approver;
            next = EndOfChain.Instance;
        }

        public Response Approve(IReport report)
        {
            var response = current.ApproveDesign(report);
            if (response == Response.Unreviewed)
            {
                return next.Approve(report);
            }
            return response;
        }

        public void SetNext(IHandler n)
        {
            next = n;
        }
    }
}
