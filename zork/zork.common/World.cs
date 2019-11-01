using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Linq;
namespace zork.common

{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(Order = 1)]
        public List<Room> Rooms { get; set; }

        [JsonProperty(Order = 0)]
        private string StartingLocation { get; set; }

        public World()
        {
            Rooms = new List<Room>();
        }

        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName => zRoomsByName;

        public Player SpawnPlayer() => new Player(this, StartingLocation);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            zRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }

        private Dictionary<string, Room> zRoomsByName;
    }
}
