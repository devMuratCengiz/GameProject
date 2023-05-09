using System;
namespace GameProject
{
	public class GameManager:IGameService
	{
        public void Sell(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + ", " + game.GameName + " oyununu " + game.GamePrice + " TL karşılığında satın aldı.");
        }
    }
}

