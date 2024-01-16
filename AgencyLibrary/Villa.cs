using AgencyLibrary;

public class Villa : Apartment
{
    public int MqGarden;

    public Villa(int mqGarden, int numRooms, int numBathrooms, string address, string city, string cap, string codeId, int mq) : base(numRooms, numBathrooms, address, city, cap, codeId, mq)
    {
        this.MqGarden = mqGarden;
    }
}