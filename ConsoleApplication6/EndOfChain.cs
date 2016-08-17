using System;

namespace Lab3.Handlers
{
    public class EndOfChain : IHandler
    {
        private static readonly EndOfChain instance = new EndOfChain();
        public static EndOfChain Instance
        {
            get { return instance; }
        }

        private EndOfChain()
        {
        }

        public Response Approve(IReport report)
        {
            return Response.Denied;
        }

        public void SetNext(IHandler next)
        {
            throw new InvalidOperationException("End of Chain!");
        }
    }
}
