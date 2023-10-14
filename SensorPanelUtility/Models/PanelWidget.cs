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
        public WidgetType WidgetType { get; set; }
        public decimal WidgetWidth { get; set; }
        public decimal WidgetHeight { get; set; }
        public decimal WidgetX { get; set; }
        public decimal WidgetY { get; set; }
        public int Opacity { get; set; }
        public bool Visible { get; set; }
        public int Order { get; set; }
    }
}
