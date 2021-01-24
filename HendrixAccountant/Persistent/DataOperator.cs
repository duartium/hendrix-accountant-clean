namespace HendrixAccountant
{
    public  class DataOperator
    {
        private static DataOperator _dataOperator;

        private DataOperator()
        {
        }

        public static DataOperator Instance
        {
            get
            {
                if (_dataOperator == null)
                    _dataOperator = new DataOperator();
                return _dataOperator;
            }
        }

        //las fucking propiedades que necesite
        public int IdUser { get; set; }
        public string Username { get; set; }
        public int UserRole { get; set; }
        public string Role { get; set; }
    }
}
