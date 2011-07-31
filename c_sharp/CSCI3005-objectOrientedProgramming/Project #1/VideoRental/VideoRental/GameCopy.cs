using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRental
{
    public class GameCopy : Copy
    {
        private string gameId;
        private string gameTitle;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string GameId
        {
            get { return gameId; }
            set { gameId = value; }
        }
        
        public string GameTitle
        {
            get { return gameTitle; }
            set { gameTitle = value; }
        }
        
        public GameCopy()
        {
            gameId = "";
            gameTitle = "";
            id = 0;
        }
    }
}
