using AdapterLibrary;

namespace AdapterLab
{
   
    public class LibraryConnection
    {
        private static LibraryConnection? _instance;

        
        private LibraryConnection()
        {
            
        }

        
        public static LibraryConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LibraryConnection();
                }
                return _instance;
            }
        }

       
        public IDigitalTime CreateAdapter(double hourAngle, double minuteAngle)
        {
            var watch = new AnalogWatch(hourAngle, minuteAngle);
            return new WatchAdapter(watch);
        }
    }
}