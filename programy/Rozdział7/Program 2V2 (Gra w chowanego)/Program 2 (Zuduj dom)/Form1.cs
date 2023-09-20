using Accessibility;

namespace Program_2__Zuduj_dom_
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            //MoveToANewLocation(livingRoom);
        }
        public void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "d�bowe drzwi z mosi�n� klamk�");
            diningRoom = new Room("Jadalnia", "kryszta�owy �yrandol");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztu�ce", "rozsuwane drzwi");
            frontYard = new OutsideWithDoor("Podw�rko przed domem", false, "d�bowe drzwi z mosi�n� klamk�");
            backYard = new OutsideWithDoor("Podw�rko za domem", true, "rozsuwane drzwi");
            garden = new Outside("Ogr�d", false);

            livingRoom.Exits = new Location[] { diningRoom };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description;
            if (currentLocation is IHasExteriorDoor) goThroughTheDoor.Visible = true;
            else goThroughTheDoor.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}