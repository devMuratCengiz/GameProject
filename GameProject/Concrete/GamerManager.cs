using System;
namespace GameProject
{
    public class GamerManager : IGamerService
    {
        ICheckRealPersonService _checkRealPersonService;
        public GamerManager(ICheckRealPersonService checkRealPersonManager)
        {
            _checkRealPersonService = checkRealPersonManager;
        }
        public void Add(Gamer gamer)
        {
            if (_checkRealPersonService.Check(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " eklendi.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " güncellendi.");
        }
    }
}

