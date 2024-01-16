using AgencyLibrary;

public class Box : Properties
{
    public int ParkingSpaces;

    public Box(int parkingSpaces, string address, string city, string cap, string codeId, int mq) : base(address, city, cap, codeId, mq)
    {
        this.ParkingSpaces = parkingSpaces;
    }
}