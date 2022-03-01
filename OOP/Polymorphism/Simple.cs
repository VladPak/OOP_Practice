using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    public class Simple : Room
    {
        public sealed override string printRoomCostForType()
        {
            return $"Description Id: {RoomId} - {RoomType} - {RoomCost}";
        }
    }
}
