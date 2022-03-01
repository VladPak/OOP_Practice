using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    public class Free : Room
    {
        public override string printRoomCostForType()
        {
            return $"Dscription {RoomType} - {RoomId} - {isOccupied}";
        }
    }
}
