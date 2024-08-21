using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new  NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 2003, FirstName = "Umut", LastName = "AYAN", IdentityNumber = 12345 });
        
        }
    }
}
