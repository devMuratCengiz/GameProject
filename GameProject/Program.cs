using GameProject;

Gamer gamer1 = new Gamer()
{
    Id=1,
    IdentityNumber="12345",
    FirstName="Murat.",
    LastName="Cengiz",
    BirthDate=2001
};
Game game1 = new Game()
{
    GameId = 1,
    GameName = "Hades",
    GamePrice = 50,
};
Campaign campaign1 = new Campaign()
{
    CampaignId = 1,
    CampaignName = "Yaz İndirimleri",
    CampaignDiscount = "%40",
};
GamerManager gamerManager = new GamerManager(new CheckRealPersonManager());
gamerManager.Add(gamer1);
gamerManager.Update(gamer1);
gamerManager.Delete(gamer1);

Console.WriteLine("--------------------------------------");

GameManager gameManager = new GameManager();
gameManager.Sell(gamer1, game1);

Console.WriteLine("--------------------------------------");

CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(game1,campaign1);
campaignManager.Update(game1,campaign1);
campaignManager.Delete(game1, campaign1);