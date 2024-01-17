namespace AgencyLibrary
{
    public class Properties
    {
        protected string _codeID;
        public string Address;
        public string City;
        public string Cap;
        protected int _mq;

        public string CodeId
        {
            set
            {
                if (value.Length < 10)
                {
                    _codeID = value;
                }
                else
                {
                    _codeID = "Impossible to set this value.";
                }
            }
            get { return _codeID; }
        }

        public int Mq
        {
            set
            {
                if (value > 10)
                {
                    _mq = value;
                }
                else
                {
                    _mq = 0;
                }
            }
            get { return _mq; }
        }

        public Properties(string address, string city, string cap, string codeId, int mq)
        {
            this.Address = address;
            this.City = city;
            this.Cap = cap;
            this.CodeId = codeId;
            this.Mq = mq;
        }
    }
}