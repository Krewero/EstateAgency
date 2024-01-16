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
                    value = _codeID;
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
                    value = _mq;
                }
            }
            get { return _mq; }
        }

        public Properties(string address, string city, string cap, string codeId, int mq)
        {
            this.Address = address;
            this.City = city;
            this.Cap = cap;
            this._codeID = codeId;
            this._mq = mq;
        }
    }
}