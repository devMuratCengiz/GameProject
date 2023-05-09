using System;
namespace GameProject
{
	public interface ICampaignService
	{
		void Add(Game game, Campaign campaign);
        void Update(Game game, Campaign campaign);
        void Delete(Game game, Campaign campaign);
	}
}

