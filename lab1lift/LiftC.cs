using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1lift
{
    public class Room
    {
        public string Number { get; private set; }
        public string Purpose { get; private set; }

        public Room(string number, string purpose)
        {
            Number = number;
            Purpose = purpose;
        }

        public override string ToString()
        {
            return Number + " — " + Purpose;
        }
    }
    public class Floor
    {
        public int Number { get; private set; }

        public List<Room> Rooms { get; private set; }

        public Floor(int number)
        {
            Number = number;
            Rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public override string ToString()
        {
            return "Этаж " + Number;
        }
    }
    public sealed class Elevator
    {
        private static readonly Elevator instance = new Elevator();

        public static Elevator Instance
        {
            get { return instance; }
        }

        public int CurrentFloor { get; private set; }

        public bool IsMoving { get; private set; }

        private Elevator()
        {
            CurrentFloor = 1;
            IsMoving = false;
        }

        public string MoveTo(int floorNumber)
        {
            if (floorNumber < 1 || floorNumber > 5)
            {
                return "Такого этажа не существует.";
            }

            if (CurrentFloor == floorNumber)
            {
                return "Лифт уже находится на этом этаже.";
            }

            IsMoving = true;

            int previousFloor = CurrentFloor;
            CurrentFloor = floorNumber;

            IsMoving = false;

            return "Лифт переместился с этажа " + previousFloor + " на этаж " + CurrentFloor + ".";
        }
    }
    public sealed class Building
    {
        private static readonly Building instance =
            new Building();

        public static Building Instance
        {
            get { return instance; }
        }

        public List<Floor> Floors { get; private set; }

        public Elevator Elevator { get; private set; }

        private Building()
        {
            Floors = new List<Floor>();

            Elevator = Elevator.Instance;

            for (int i = 1; i <= 5; i++)
            {
                Floor floor = new Floor(i);

                floor.AddRoom(new Room(
                    i + "01", "Офис"));

                floor.AddRoom(new Room(
                    i + "02", "Кабинет"));

                floor.AddRoom(new Room(
                    i + "03", "Склад"));

                Floors.Add(floor);
            }
        }
    }
    public class ElevatorService
    {
        private readonly Building building;

        public ElevatorService()
        {
            building = Building.Instance;
        }

        public int GetCurrentFloor()
        {
            return building.Elevator.CurrentFloor;
        }

        public string CallElevator(int floorNumber)
        {
            return building.Elevator.MoveTo(floorNumber);
        }

        public string GetFloorInfo(int floorNumber)
        {
            foreach (Floor floor in building.Floors)
            {
                if (floor.Number == floorNumber)
                {
                    string result = "Этаж " + floor.Number + "\n";

                    foreach (Room room in floor.Rooms)
                    {
                        result += room.ToString() + "\n";
                    }

                    return result;
                }
            }

            return "Этаж не найден.";
        }
    }
}
