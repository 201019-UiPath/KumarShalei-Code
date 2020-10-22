using System.Collections.Generic;
using System.Threading.Tasks;
using HerosDB;
using Heroslib;


namespace HerosBL
{
    public class HeroBL
    {
        IRepository repo = new FileRepo();
        public void AddHero(Hero newHero){
            // You can add BL to check stuff
            // like if hero name is unique
            // Throw an exception or two
            repo.AddHeroAsync(newHero);
        }

        public List<Hero> GetAllHeros(){
            Task<List<Hero>> getHeros = repo.GetAllHerosAsync();
            return getHeros.Result;
    }
    }
}
