using System;
using System.Collections.Generic;
using System.Text;

namespace Voting_Server_App
{
    public class DataBaseScript
    {
        public void CreateDatabase()
        {
            using (var context = new Context.VoteContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public void StartServer()
        {
            while (true)
            {
                
            }
        }
    }
}
