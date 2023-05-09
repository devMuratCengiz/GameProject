using System;
namespace GameProject
{
    public class CheckRealPersonManager : ICheckRealPersonService
    {
        public bool Check(Gamer gamer)
        {
            if (gamer.Id==1&& gamer.IdentityNumber=="12345" && gamer.FirstName=="Murat" && gamer.LastName=="Cengiz" && gamer.BirthDate==2001)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

