using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorPanelUtility.Models
{
    public class PanelWidget
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int WidgetWidth { get; set; }
        public int WidgetHeight { get; set; }
        public int WidgetX { get; set; }
        public int WidgetY { get; set; }
        public int Opacity { get; set; }
        public bool Visible { get; set; }
        public int Order { get; set; }
    }
}
