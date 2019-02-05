using System;
using System.Collections.Generic;
using System.Text;

namespace HotelGo99
{
    class RoomSize
    {
        public string Queen;
        public string King;
        public string Suite;

        public string getQueen() { return Queen; }
        public void setQueen(string Queen) { this.Queen = Queen; }
        public string getKing() { return King; }
        public void setKing(string King) { this.King = King; }
        public string getSuite() { return Suite; }
        public void setSuite(string Suite) { this.Suite = Suite; }

        public RoomSize(string v) { }

        public RoomSize(string Queen, string King, string Suite)
        {
            this.Queen = Queen;
            this.King = King;
            this.Suite = Suite;

            RoomSize[] sizes = new RoomSize[3];
            sizes[0] = new RoomSize ("Queen");
            sizes[1] = new RoomSize("King");
            sizes[2] = new RoomSize("Suite");

      
    
        }

    }
}
