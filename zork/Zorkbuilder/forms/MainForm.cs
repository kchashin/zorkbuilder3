using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json;
using zork.builder;
using Zorkbuilder;
using zork.common;
using Zorkbuilder.Control;
using zork.builder.forms;
using System.Diagnostics;

namespace Zorkbuilder
{
    //new, play, welcome message, statrting location
    public partial class MainForm : Form
    {
        private bool zIsGameLoaded;
        private ZorkViewModel zViewModel;
        private readonly Dictionary<Directions, NeighborControl> zNeighborControlMap;

        

        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        private ZorkViewModel ViewModel
        {
            get => zViewModel;
            set
            {
                if(zViewModel != value)
                {
                    zViewModel = value;
                    zorkViewModelBindingSource.DataSource = zViewModel;
                }
            }
        }

        private bool IsGameLoaded
        {
            get => zIsGameLoaded;
            set
            {
                zIsGameLoaded = value;
                mainTabControl.Enabled = zIsGameLoaded;
            }
        } 

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new ZorkViewModel();
            IsGameLoaded = false;

            zNeighborControlMap = new Dictionary<Directions, NeighborControl>
            {
                { Directions.North, northNeighborControl },
                { Directions.South, southNeighborControl },
                { Directions.East, eastNeighborControl },
                { Directions.West, westNeighborControl }
            };
        }

        //play JSON file

        //help

        private void LaunchZorkConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = Properties.Settings.Default.DotNetExecutable,
                    Arguments = $"{Properties.Settings.Default.ZorkGameAssembly} {Properties.Settings.Default.ZorkGameArguments}",
                    WorkingDirectory = Path.GetDirectoryName(Properties.Settings.Default.ZorkGameAssembly),
                    UseShellExecute = false
                };
                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Playing.");
            }
        }
       

        //about
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about to = new about();
            to.Show();
        }
        //open file
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = Game.Load(openFileDialog.FileName);
                ViewModel.Filename = openFileDialog.FileName;

                Room selectedRoom = roomsListBox.SelectedItem as Room;
                foreach (var control in zNeighborControlMap.Values)
                {
                    control.World = ViewModel.Game.World;
                    control.Room = selectedRoom;
                }

                IsGameLoaded = true;
            }
        }
        private void RoomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomsListBox.SelectedItem != null;
            Room selectedRoom = roomsListBox.SelectedItem as Room;
            foreach (var control in zNeighborControlMap.Values)
            {
                control.Room = selectedRoom;
            }
        }
        //save as
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveJSON.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveJSON.FileName;
                ViewModel.SaveWorld();
            }
        }
        //add rooms
        private void addRoomsButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoomForm.RoomName };
                    ViewModel.Rooms.Add(room);
                    
                }
            }
        }
        //new world
        //help
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zViewModel.Game = new Game(new World());            
        }

        //delete room
        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.RemoveRoom((Room)roomsListBox.SelectedItem);
                roomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }
        //exit progam
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveWorld();
    }
}
