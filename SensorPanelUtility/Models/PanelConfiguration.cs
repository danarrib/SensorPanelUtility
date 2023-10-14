using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorPanelUtility.Models
{
    public class PanelConfiguration
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int PanelWidth { get; set; }
        public int PanelHeight { get; set; }
        public int PanelX { get; set; }
        public int PanelY { get; set; }
        public int Opacity { get; set; }
        public bool AlwaysOnTop { get; set; }
        public int BackgroundColor { get; set; }
        public List<PanelWidget> Widgets { get; set; }
    }
}
