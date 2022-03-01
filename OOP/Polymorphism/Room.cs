using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    public class Room
    {
        public int RoomId;
        public string RoomType;
        public int RoomCost;
        public bool isReserved;
        public bool isOccupied;

        //public Room(int roomId, string roomType, int roomCost, bool reserved, bool occupied)
        //{
        //    RoomId = roomId;
        //    RoomType = roomType;
        //    RoomCost = roomCost;
        //    isReserved = reserved;
        //    isOccupied = occupied;
        //}

        public virtual string printRoomCostForType()
        {
            return $"Type: {RoomType} - {RoomCost}";
        }
    }
}
