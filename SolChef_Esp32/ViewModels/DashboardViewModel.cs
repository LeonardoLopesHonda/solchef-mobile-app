using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolChef_Esp32.ViewModels {
    /* TODO: Change these for the data mockup of the Solchef endpoint */
    internal class DashboardViewModel {
        public string SensorA_Temp { get; set; } = "23.4°C";
        public string SensorB_Temp { get; set; } = "24.1°C";

        public ObservableCollection<Reading> History { get; set; }

        public DashboardViewModel() {
            History = new ObservableCollection<Reading>
            {
                new Reading { Timestamp = "2025-10-20 13:00", Temperature = "23.2°C" },
                new Reading { Timestamp = "2025-10-20 12:00", Temperature = "22.8°C" },
                new Reading { Timestamp = "2025-10-20 11:00", Temperature = "22.4°C" },
                new Reading { Timestamp = "2025-10-20 10:00", Temperature = "21.9°C" }
            };
        }
    }

    public class Reading {
        public string Timestamp { get; set; }
        public string Temperature { get; set; }
    }
}
