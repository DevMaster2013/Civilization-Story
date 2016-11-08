using Engine.Modules.Humans;
using Engine.Modules.Regional;
using Engine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core
{
    public class Game
    {
        public World world = null;
        public Player player = null; 
        
        public Game()
        {
            GameClock.currentTime = GameSettings.gameStartDate;
            NameDatabase.createNameDatabase();
        }

        public void createWorld()
        {
            world = new World();
        }

        public void createPlayer(string playerName, string wifeName, string factionName)
        {
            Faction f = world.createFaction(factionName);
            player = new Player(playerName, f);

            DateTime dob = GameClock.currentTime.AddYears(-20);

            HumanMale founder = f.createHuman(playerName, dob, true) as HumanMale;
            HumanFemale founderWife = f.createHuman(wifeName, dob, false) as HumanFemale;
            f.createFamily(founder, founderWife);
            f.founder = founder;

            HumanMale aidedMan = f.createHuman(RandomGenerator.getRandomName(true), dob, true) as HumanMale;
            HumanFemale aidedWoman = f.createHuman(RandomGenerator.getRandomName(false), dob, false) as HumanFemale;
            f.createFamily(aidedMan, aidedWoman);
        }

        public void update(double elapsedSeconds)
        {
            GameClock.update(elapsedSeconds);
            world.update(elapsedSeconds);
            player.update(elapsedSeconds);
        }
    }
}
