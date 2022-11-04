using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    public class Sample : Room
    {
        public int someAddInfo {get; set;}

        public sealed override string printRoomCostForType()
        {
            return $"Description Id: {RoomId} - {RoomType} - {RoomCost} - {someAddInfo}";
        }
    }
}