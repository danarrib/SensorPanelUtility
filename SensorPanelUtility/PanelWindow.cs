using SensorPanelUtility.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorPanelUtility
{
    public partial class PanelWindow : Form
    {
        public PanelWindow()
        {
            InitializeComponent();
        }

        public PanelConfigurationWindow PanelConfigurationWindow { get; set; }

        private void PanelWindow_Resize(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                PanelConfigurationWindow.CurrentPanelConfiguration.PanelWidth = this.Width;
                PanelConfigurationWindow.CurrentPanelConfiguration.PanelHeight = this.Height;
                PanelConfigurationWindow.SyncModelToUI();
                PanelConfigurationWindow.SetScreenUnsaved();
                Debug.WriteLine($"PanelWindow_Resize: {this.Width}x{this.Height}");
            }
        }

        private void PanelWindow_Move(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                PanelConfigurationWindow.CurrentPanelConfiguration.PanelX = this.Left;
                PanelConfigurationWindow.CurrentPanelConfiguration.PanelY = this.Top;
                PanelConfigurationWindow.SyncModelToUI();
                PanelConfigurationWindow.SetScreenUnsaved();
                Debug.WriteLine($"PanelWindow_Move: {this.Left}x{this.Top}");
            }
        }

        private void PanelWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
