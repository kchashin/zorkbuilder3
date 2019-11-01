using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.ComponentModel;

namespace zork.common
{
    [JsonConverter(typeof(RoomConverter))]
    public class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(Order = 1)]
        public string Name { get; set; }

        [JsonProperty(Order = 2)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        private Dictionary<Directions, string> NeighborNames { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors { get; set; }

        public static bool operator ==(Room lhs, Room rhs)
        {
            if (ReferenceEquals(lhs, rhs))
            {
                return true;
            }
            if (lhs is null || rhs is null)
            {
                return false;
            }
            return lhs.Name == rhs.Name;
        }

        public Room() :
            this(string.Empty, string.Empty)
        {

        }
        public Room(string name = null, string description = null, Dictionary<Directions, string> neighborNames = null)
        {
            Name = name;
            Description = description;
            NeighborNames = neighborNames;
            Neighbors = new Dictionary<Directions, Room>();
        }


        public void BuildNeighborsFromNames(List<Room> rooms)
        {
                Neighbors = (from entry in NeighborNames
                             let room = rooms.Find(i => i.Name.Equals(entry.Value, System.StringComparison.InvariantCultureIgnoreCase))
                             where room != null
                             select (Directions: entry.Key, Item: room)).
                         ToDictionary(pair => pair.Directions, pair => pair.Item);

            NeighborNames.Clear();
        }

        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);
        public override bool Equals(object obj) => obj is Room room ? this == room : false;
        public bool Equals(Room other) => this == other;
        public override string ToString() => Name;
        public override int GetHashCode() => Name.GetHashCode();
        public void UpdateNeighbors(World world) => Neighbors = (from entry in NeighborNames
                                                                 let room = world.RoomsByName.GetValueOrDefault(entry.Value)
                                                                 where room != null
                                                                 select (Direction: entry.Key, Room: room))
                                                                .ToDictionary(pair => pair.Direction, pair => pair.Room);


    }
}
