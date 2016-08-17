using System;

namespace Lab3
{
    public enum UserRole
    {
        Developer = 1,
        TehnicalLead = 2,
        Architect = 3
    }
    public class User : IApprover
    {
        public int Experience { get; set; }
        private string role;
        private UserRole userRole;
        public string Name { get; set; }
        public string Role
        {
            get { return role; }
            private set { role = value; }
        }

        public UserRole UserRole
        {
            get { return userRole; }
            set
            {
                userRole = value;
                role = value.ToString();
            }
        }

        public User(string name, UserRole role, int experience)
        {
            Name = name;
            UserRole = role;
            Experience = experience;
        }

        public Response ApproveDesign(IReport report)
        {
            Random r = new Random((int)DateTime.Now.Ticks);

            int knowledge = 0;
            if (UserRole == UserRole.TehnicalLead)
            {
                knowledge = Experience + r.Next(1, 20);
            }
            else if (UserRole == UserRole.Architect)
            {
                knowledge = Experience + r.Next(1, 50);
            }

            if (knowledge > report.Difficuty)
            {
                Console.WriteLine(Name + " is reviewing the design");
                int accept = r.Next(1, 4);
                if (accept == 1)
                    return Response.Denied;
                return Response.Approved;
            }
            return Response.Unreviewed;
        }
    }
}
