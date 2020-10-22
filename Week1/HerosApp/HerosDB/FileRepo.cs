using System.Collections.Generic;
using Heroslib;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace HerosDB
{
    /// <summary>
    /// Repository using file
    /// </summary>
    public class FileRepo : IRepository
    {
        string filepath = "HerosDB/HerosDataPlace/Heros.txt";
        /// <summary>
        /// Adds hero to file
        /// </summary>
        /// <param name="hero"></param>
        public async void AddHeroAsync(Hero hero)
        {
            using (FileStream fs = File.Create(filepath)){
                await JsonSerializer.SerializeAsync(fs, hero);
                System.Console.WriteLine("hero is being written to file");
            }
        }

        /// <summary>
        /// Gets all heros from data storing place
        /// </summary>
        /// <returns></returns>
        public async Task<List<Hero>> GetAllHerosAsync()
        {
            List<Hero> allHeros = new List<Hero>();
            using(FileStream fs = File.OpenRead(filepath)){
                allHeros.Add(await JsonSerializer.DeserializeAsync<Hero>(fs));
            }
            return allHeros;
        }
    }
}