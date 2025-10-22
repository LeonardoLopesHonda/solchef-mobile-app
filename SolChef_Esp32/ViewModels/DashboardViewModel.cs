using Microcharts;
using SkiaSharp;
using System.Collections.ObjectModel;

namespace SolChef_Esp32.ViewModels {
    /* TODO: Change these for the data mockup of the Solchef endpoint */
    internal class DashboardViewModel {
        public string SensorA_Temp { get; set; } = "32.2ºC";
        public string SensorB_Temp { get; set; } = "35.2ºC";

        public ObservableCollection<Reading> History { get; set; }

        public Chart Chart { get; }

        public DashboardViewModel() {
            History = new ObservableCollection<Reading> {
                new Reading { Timestamp = "2025-10-20 13:00", Temperature = "23.2°C" },
                new Reading { Timestamp = "2025-10-20 12:00", Temperature = "22.8°C" },
                new Reading { Timestamp = "2025-10-20 11:00", Temperature = "22.4°C" },
                new Reading { Timestamp = "2025-10-20 10:00", Temperature = "21.9°C" }
            };

            Chart = new LineChart {
                Entries = new List<ChartEntry> {
                    new ChartEntry(21.9f) {
                        Label = "10h",
                        ValueLabel = "21.9ºC",
                        Color = SKColor.Parse("#FFEB3B")
                    },
                    new ChartEntry(22.4f) {
                        Label = "11h",
                        ValueLabel = "25.4ºC",
                        Color = SKColor.Parse("#FFC107")
                    },
                    new ChartEntry(22.8f) {
                        Label = "12h",
                        ValueLabel = "30.8ºC",
                        Color = SKColor.Parse("#FF9800")
                    },
                    new ChartEntry(23.2f) {
                        Label = "13h",
                        ValueLabel = "32.2ºC",
                        Color = SKColor.Parse("#FF5722")
                    }
                },
                LineMode = LineMode.Straight,
                LineSize = 10,
                LabelOrientation = Orientation.Horizontal,
                ValueLabelOrientation = Orientation.Horizontal,
                LabelTextSize = 35
            };
        }
    }

    public class Reading {
        public string Timestamp { get; set; }
        public string Temperature { get; set; }
    }
}
