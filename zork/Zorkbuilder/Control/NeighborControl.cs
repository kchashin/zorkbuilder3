using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using zork.common;

namespace Zorkbuilder.Control
{
    public partial class NeighborControl : UserControl
    {
        

        public Room Room
        {
            get => zRoom;
            set
            {
                if (zRoom != value)
                {
                    zRoom = value;
                    if (zRoom != null)
                    {
                        //Help
                        var rooms = new List<Room>(World.Rooms.ToList());
                        rooms.Insert(0, NoNeighbor);
                        neighborComboBox.SelectedIndexChanged -= NeighborComboBox_SelectedIndexChanged;
                        neighborComboBox.DataSource = rooms;

                        SelectedRoom = zRoom.Neighbors.TryGetValue(Direction, out Room selectedRoom) ? selectedRoom : NoNeighbor;
                        neighborComboBox.SelectedIndexChanged += NeighborComboBox_SelectedIndexChanged;                        
                    }
                    else
                    {
                        neighborComboBox.DataSource = null;
                    }
                }
            }
        }

        public World World { get; set; }

        public Directions Direction
        {
            get => zDirection;
            set
            {
                zDirection = value;
                neighborTextBox.Text = zDirection.ToString();
            }
        }

        public Room SelectedRoom 
        { 
            get => (Room)neighborComboBox.SelectedItem; 
            set => neighborComboBox.SelectedItem = value; 
        }


        public NeighborControl()
        {
            InitializeComponent();
        }

        private static readonly Room NoNeighbor = new Room() { Name = "None" };
        private Room zRoom;
        private Directions zDirection;

        private void NeighborComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (zRoom != null)
            {
                Room selectedRoom = SelectedRoom;
                if (selectedRoom == NoNeighbor)
                {
                    zRoom.Neighbors.Remove(Direction);
                }
                else
                {
                    zRoom.Neighbors[Direction] = selectedRoom;
                } 
            }
        }
    }
}
