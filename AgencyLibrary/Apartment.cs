using AgencyLibrary;
using System.Net;

public class Apartment : Properties
{
    public int NumRooms;
    public int NumBathrooms;

    public Apartment(int numRooms, int numBathrooms, string address, string city, string cap, string codeId, int mq) : base(address, city, cap, codeId, mq)
    {
        this.NumRooms = numRooms;
        this.NumBathrooms = numBathrooms;
    }

    public override string ToString()
    {
        return $"Type of propertie: Apartment\nAddress: {Address}\nCity: {City}\nCap: {Cap}\nNumber of mq: {Mq}\nNumber of rooms: {NumRooms}\nNumber of bathrooms: {NumBathrooms}";
    }
}