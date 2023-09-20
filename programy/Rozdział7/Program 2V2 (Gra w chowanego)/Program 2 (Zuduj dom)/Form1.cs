using Accessibility;
using System.Transactions;

namespace Program_2__Zuduj_dom_
{
    public partial class Form1 : Form
    {
        int Moves;
        Location currentLocation;
        Opponent opponent;

        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bedroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }
        public void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "dêbowe drzwi z mosiê¿n¹ klamk¹");
            diningRoom = new Room("Jadalnia", "kryszta³owy ¿yrandol");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztuæce", "rozsuwane drzwi");
            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dêbowe drzwi z mosiê¿n¹ klamk¹");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
            garden = new Outside("Ogród", false);

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
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }
        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++) exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(ruch numer " + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "SprawdŸ " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else check.Visible = false;
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