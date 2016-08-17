using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Handlers;

namespace Lab3
{
    public class Utils
    {
        private List<User> users ;
        private List<Handler> designHandlers;
        public Utils(List<User> u )
        {
            users = u;
            designHandlers = new List<Handler>() ;
        }

        public string StartReview(int difficulty)
        {

            foreach (User user in users)
            {
                Handler dh = new Handler(user);
                designHandlers.Add(dh);
            }

            for (int i = 0; i < designHandlers.Count-1; i++)
            {
                designHandlers[i].SetNext(designHandlers[i+1]);
            }

            Report designReport = new Report(difficulty);
            Response response = designHandlers.First().Approve(designReport);

            return "Request was " + response;
        }
    }
}
