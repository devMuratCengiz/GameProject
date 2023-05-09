using System;
namespace GameProject
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Game game, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " ile " + game.GameName + " oyununda " + campaign.CampaignDiscount + " indirim!!");
        }

        public void Delete(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " oyununda " + campaign.CampaignName + " güncellendi.");
        }

        public void Update(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " oyununda " + campaign.CampaignName + " artık geçersiz.");
        }
    }
}

