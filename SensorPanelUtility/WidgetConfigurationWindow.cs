﻿using SensorPanelUtility.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorPanelUtility
{
    public partial class WidgetConfigurationWindow : Form
    {
        public WidgetConfigurationWindow()
        {
            InitializeComponent();
        }

        public PanelWidget PanelWidget { get; set; }


    }
}
