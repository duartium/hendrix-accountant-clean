using System.Drawing;

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
        //primary original 27; 46; 140
        //secondary original 253; 184; 39
        public Color ColorPrimary { get { return Color.FromArgb(184, 74, 159); } }
        public Color ColorSecondary { get { return Color.FromArgb(255, 218, 192); } }
        public Color ColorTertiary { get { return Color.FromArgb(30, 107, 247); } }
        public Color ColorQuaternary { get { return Color.FromArgb(253, 184, 39); } }

    }
}
