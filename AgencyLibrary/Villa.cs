using AgencyLibrary;

public class Villa : Apartment
{
    public int MqGarden;

    public Villa(int mqGarden, int numRooms, int numBathrooms, string address, string city, string cap, string codeId, int mq) : base(numRooms, numBathrooms, address, city, cap, codeId, mq)
    {
        this.MqGarden = mqGarden;
    }

    public override string ToString()
    {
        return $"Type of estate: Villa\nAddress: {Address}\nCity: {City}\nCap: {Cap}\nMq: {Mq}\nNumber of rooms: {NumRooms}\nNumber of Bathrooms: {NumBathrooms}\nMq of the garden: {MqGarden}";
    }
}