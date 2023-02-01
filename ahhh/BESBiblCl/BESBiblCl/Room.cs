using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BESBiblCl
{
    public class Room
    {
        double roomLenght; //длина комнаты
        double roomWidth; //ширина комнаты
        public double RoomLenght
        {
            get { return roomLenght; }
            set { roomLenght = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        public double RoomPerimetr()
        {
            return 2 * (roomWidth + roomLenght);
        }
        public double RoomArea()
        {
            return roomLenght * roomWidth;
        }
        //<param name="np">
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
        public string Info()
        {
            return "Комната площадью " + RoomArea() + " кв.м ";
        }

    }
    public class LivingRoom : Room
    {
        int numWin;
        public int NumWin
        { get { return numWin; } set { numWin = value; } }
        public string Info()
        {
            return "Жилая комната площадью " + RoomArea() + " кв.м " + numWin + " окнами";
        }
    }
    public class Office : Room
    {
        int numSockets;
        public int Numsockets
        { get { return numSockets; } set { numSockets = value; } }
        public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numSockets, num);
        }
        public string Info()
        {
            return "Офис на " + NumWorkplaces() + " рабочих мест";
        }
    }
}
