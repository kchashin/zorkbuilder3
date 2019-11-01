namespace Zorkbuilder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchZorkConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zorkViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveJSON = new System.Windows.Forms.SaveFileDialog();
            this.openJSON = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.Rooms = new System.Windows.Forms.TabPage();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomsButton = new System.Windows.Forms.Button();
            this.neighborGroupBox = new System.Windows.Forms.GroupBox();
            this.southNeighborControl = new Zorkbuilder.Control.NeighborControl();
            this.eastNeighborControl = new Zorkbuilder.Control.NeighborControl();
            this.westNeighborControl = new Zorkbuilder.Control.NeighborControl();
            this.northNeighborControl = new Zorkbuilder.Control.NeighborControl();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.Room_Name = new System.Windows.Forms.TextBox();
            this.namew = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.neighbors = new System.Windows.Forms.Label();
            this.descriptionw = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.WelcomeMessagebox = new System.Windows.Forms.TextBox();
            this.WelcomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StartingLocationBox = new System.Windows.Forms.TextBox();
            this.StartingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startingLocation = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zorkViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.Rooms.SuspendLayout();
            this.neighborGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New ";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchZorkConsoleToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "&Run";
            // 
            // launchZorkConsoleToolStripMenuItem
            // 
            this.launchZorkConsoleToolStripMenuItem.Name = "launchZorkConsoleToolStripMenuItem";
            this.launchZorkConsoleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.launchZorkConsoleToolStripMenuItem.Text = "Launch Zork Console";
            this.launchZorkConsoleToolStripMenuItem.Click += new System.EventHandler(this.LaunchZorkConsoleToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.zorkViewModelBindingSource;
            // 
            // zorkViewModelBindingSource
            // 
            this.zorkViewModelBindingSource.DataSource = typeof(Zorkbuilder.ZorkViewModel);
            // 
            // saveJSON
            // 
            this.saveJSON.Filter = "Zork Files (*.json)|*.json";
            // 
            // openJSON
            // 
            this.openJSON.FileName = "openFileDialog1";
            this.openJSON.Filter = "Zork Files (*.json)|*.json";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.Rooms);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Location = new System.Drawing.Point(12, 27);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(768, 403);
            this.mainTabControl.TabIndex = 26;
            // 
            // Rooms
            // 
            this.Rooms.Controls.Add(this.deleteRoomButton);
            this.Rooms.Controls.Add(this.addRoomsButton);
            this.Rooms.Controls.Add(this.neighborGroupBox);
            this.Rooms.Controls.Add(this.roomsListBox);
            this.Rooms.Controls.Add(this.Room_Name);
            this.Rooms.Controls.Add(this.namew);
            this.Rooms.Controls.Add(this.Description);
            this.Rooms.Controls.Add(this.neighbors);
            this.Rooms.Controls.Add(this.descriptionw);
            this.Rooms.Location = new System.Drawing.Point(4, 22);
            this.Rooms.Name = "Rooms";
            this.Rooms.Padding = new System.Windows.Forms.Padding(3);
            this.Rooms.Size = new System.Drawing.Size(760, 377);
            this.Rooms.TabIndex = 0;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = true;
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(28, 353);
            this.deleteRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(82, 19);
            this.deleteRoomButton.TabIndex = 43;
            this.deleteRoomButton.Text = "&Delete Room";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.deleteRoomButton_Click);
            // 
            // addRoomsButton
            // 
            this.addRoomsButton.Location = new System.Drawing.Point(28, 319);
            this.addRoomsButton.Margin = new System.Windows.Forms.Padding(2);
            this.addRoomsButton.Name = "addRoomsButton";
            this.addRoomsButton.Size = new System.Drawing.Size(82, 19);
            this.addRoomsButton.TabIndex = 42;
            this.addRoomsButton.Text = "&Add Room";
            this.addRoomsButton.UseVisualStyleBackColor = true;
            this.addRoomsButton.Click += new System.EventHandler(this.addRoomsButton_Click);
            // 
            // neighborGroupBox
            // 
            this.neighborGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neighborGroupBox.Controls.Add(this.southNeighborControl);
            this.neighborGroupBox.Controls.Add(this.eastNeighborControl);
            this.neighborGroupBox.Controls.Add(this.westNeighborControl);
            this.neighborGroupBox.Controls.Add(this.northNeighborControl);
            this.neighborGroupBox.Location = new System.Drawing.Point(207, 159);
            this.neighborGroupBox.Name = "neighborGroupBox";
            this.neighborGroupBox.Size = new System.Drawing.Size(536, 204);
            this.neighborGroupBox.TabIndex = 41;
            this.neighborGroupBox.TabStop = false;
            // 
            // southNeighborControl
            // 
            this.southNeighborControl.Direction = zork.common.Directions.South;
            this.southNeighborControl.Location = new System.Drawing.Point(195, 145);
            this.southNeighborControl.Margin = new System.Windows.Forms.Padding(4);
            this.southNeighborControl.Name = "southNeighborControl";
            this.southNeighborControl.Room = null;
            this.southNeighborControl.SelectedRoom = null;
            this.southNeighborControl.Size = new System.Drawing.Size(126, 53);
            this.southNeighborControl.TabIndex = 3;
            this.southNeighborControl.World = null;
            // 
            // eastNeighborControl
            // 
            this.eastNeighborControl.Direction = zork.common.Directions.East;
            this.eastNeighborControl.Location = new System.Drawing.Point(399, 83);
            this.eastNeighborControl.Margin = new System.Windows.Forms.Padding(4);
            this.eastNeighborControl.Name = "eastNeighborControl";
            this.eastNeighborControl.Room = null;
            this.eastNeighborControl.SelectedRoom = null;
            this.eastNeighborControl.Size = new System.Drawing.Size(126, 53);
            this.eastNeighborControl.TabIndex = 2;
            this.eastNeighborControl.World = null;
            // 
            // westNeighborControl
            // 
            this.westNeighborControl.Direction = zork.common.Directions.West;
            this.westNeighborControl.Location = new System.Drawing.Point(6, 83);
            this.westNeighborControl.Margin = new System.Windows.Forms.Padding(4);
            this.westNeighborControl.Name = "westNeighborControl";
            this.westNeighborControl.Room = null;
            this.westNeighborControl.SelectedRoom = null;
            this.westNeighborControl.Size = new System.Drawing.Size(126, 53);
            this.westNeighborControl.TabIndex = 1;
            this.westNeighborControl.World = null;
            // 
            // northNeighborControl
            // 
            this.northNeighborControl.Direction = zork.common.Directions.North;
            this.northNeighborControl.Location = new System.Drawing.Point(195, 10);
            this.northNeighborControl.Margin = new System.Windows.Forms.Padding(4);
            this.northNeighborControl.Name = "northNeighborControl";
            this.northNeighborControl.Room = null;
            this.northNeighborControl.SelectedRoom = null;
            this.northNeighborControl.Size = new System.Drawing.Size(126, 53);
            this.northNeighborControl.TabIndex = 0;
            this.northNeighborControl.World = null;
            // 
            // roomsListBox
            // 
            this.roomsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.roomsListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(6, 11);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(120, 303);
            this.roomsListBox.TabIndex = 39;
            this.roomsListBox.ValueMember = "Location";
            // 
            // Room_Name
            // 
            this.Room_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Room_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Room_Name.Location = new System.Drawing.Point(355, 13);
            this.Room_Name.Name = "Room_Name";
            this.Room_Name.Size = new System.Drawing.Size(304, 20);
            this.Room_Name.TabIndex = 38;
            // 
            // namew
            // 
            this.namew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namew.AutoSize = true;
            this.namew.Location = new System.Drawing.Point(224, 11);
            this.namew.Name = "namew";
            this.namew.Size = new System.Drawing.Size(35, 13);
            this.namew.TabIndex = 37;
            this.namew.Text = "&Name";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Description.Location = new System.Drawing.Point(355, 51);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(364, 68);
            this.Description.TabIndex = 32;
            // 
            // neighbors
            // 
            this.neighbors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neighbors.AutoSize = true;
            this.neighbors.Location = new System.Drawing.Point(204, 143);
            this.neighbors.Name = "neighbors";
            this.neighbors.Size = new System.Drawing.Size(55, 13);
            this.neighbors.TabIndex = 28;
            this.neighbors.Text = "&Neighbors";
            // 
            // descriptionw
            // 
            this.descriptionw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionw.AutoSize = true;
            this.descriptionw.Location = new System.Drawing.Point(199, 42);
            this.descriptionw.Name = "descriptionw";
            this.descriptionw.Size = new System.Drawing.Size(60, 13);
            this.descriptionw.TabIndex = 27;
            this.descriptionw.Text = "&Description";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.WelcomeMessagebox);
            this.tabPage2.Controls.Add(this.StartingLocationBox);
            this.tabPage2.Controls.Add(this.startingLocation);
            this.tabPage2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.WelcomeBindingSource, "Game", true));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome Message:";
            // 
            // WelcomeMessagebox
            // 
            this.WelcomeMessagebox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.WelcomeBindingSource, "World", true));
            this.WelcomeMessagebox.Location = new System.Drawing.Point(259, 100);
            this.WelcomeMessagebox.Multiline = true;
            this.WelcomeMessagebox.Name = "WelcomeMessagebox";
            this.WelcomeMessagebox.Size = new System.Drawing.Size(405, 25);
            this.WelcomeMessagebox.TabIndex = 2;
            // 
            // WelcomeBindingSource
            // 
            this.WelcomeBindingSource.DataSource = this.zorkViewModelBindingSource;
            // 
            // StartingLocationBox
            // 
            this.StartingLocationBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.StartingBindingSource, "World", true));
            this.StartingLocationBox.Location = new System.Drawing.Point(259, 25);
            this.StartingLocationBox.Multiline = true;
            this.StartingLocationBox.Name = "StartingLocationBox";
            this.StartingLocationBox.Size = new System.Drawing.Size(405, 25);
            this.StartingLocationBox.TabIndex = 1;
            // 
            // StartingBindingSource
            // 
            this.StartingBindingSource.DataSource = this.zorkViewModelBindingSource;
            // 
            // startingLocation
            // 
            this.startingLocation.AutoSize = true;
            this.startingLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingLocation.Location = new System.Drawing.Point(35, 26);
            this.startingLocation.Name = "startingLocation";
            this.startingLocation.Size = new System.Drawing.Size(110, 16);
            this.startingLocation.TabIndex = 0;
            this.startingLocation.Text = "Starting Location:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 442);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zorkViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.Rooms.ResumeLayout(false);
            this.Rooms.PerformLayout();
            this.neighborGroupBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveJSON;
        private System.Windows.Forms.OpenFileDialog openJSON;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.BindingSource zorkViewModelBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage Rooms;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.TextBox Room_Name;
        private System.Windows.Forms.Label namew;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label neighbors;
        private System.Windows.Forms.Label descriptionw;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label startingLocation;
        private System.Windows.Forms.TextBox StartingLocationBox;
        private System.Windows.Forms.GroupBox neighborGroupBox;
        private Control.NeighborControl southNeighborControl;
        private Control.NeighborControl eastNeighborControl;
        private Control.NeighborControl westNeighborControl;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomsButton;
        private System.Windows.Forms.BindingSource WelcomeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WelcomeMessagebox;
        private System.Windows.Forms.BindingSource StartingBindingSource;
        private Control.NeighborControl northNeighborControl;
        private System.Windows.Forms.ToolStripMenuItem launchZorkConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

