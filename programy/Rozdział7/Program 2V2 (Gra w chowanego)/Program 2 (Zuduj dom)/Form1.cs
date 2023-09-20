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
        RoomWithHidingPlace bathroom;
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
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "w szafie œciennej", "dêbowe drzwi z mosiê¿n¹ klamk¹");
            diningRoom = new RoomWithHidingPlace("Jadalnia", "kryszta³owy ¿yrandol", "w wysokiej szafie");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztuæce", "w szafce", "rozsuwane drzwi");
            stairs = new Room("Schody", "drewniana porêcz");
            hallway = new RoomWithHidingPlace("Korytarz na górze", "obrazek z psem", "w szafie œciennej");
            bathroom = new RoomWithHidingPlace("£azienka", "umywalka i toaleta", "pod prysznicem");
            masterBedroom = new RoomWithHidingPlace("Du¿a sypialnia", "du¿e ³ó¿ko", "pod ³ó¿kiem");
            secondBedroom = new RoomWithHidingPlace("Druga sypialnia", "ma³e ³ó¿ko", "pod ³óŸkiem");

            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dêbowe drzwi z mosiê¿n¹ klamk¹");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
            garden = new OutsideWithHidingPlace("Ogród", false, "w szopie");
            driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "w gara¿u");

            livingRoom.Exits = new Location[] { diningRoom, stairs };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };

            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };

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