using SensorPanelUtility.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorPanelUtility
{
    public partial class PanelConfigurationWindow : Form
    {
        public PanelConfigurationWindow()
        {
            InitializeComponent();
        }

        public PanelConfiguration CurrentPanelConfiguration { get; set; }
        private bool _hasUnsavedChanges;
        private bool _isSyncingToUI;

        private void btnSave_Click(object sender, EventArgs e)
        {
            SyncModelFromUI();
            SavePanelConfiguration();
            ControlUI();
        }

        private void SavePanelConfiguration()
        {
            if (CurrentPanelConfiguration.Id.IsNullOrWhiteSpace())
            {
                CurrentPanelConfiguration.Id = Guid.NewGuid().ToString();
            }

            var panelConfigurationJson = JsonSerializer.Serialize(CurrentPanelConfiguration);
            var panelConfigurationFile = $@"{Application.StartupPath}panels\{CurrentPanelConfiguration.Id}.json";
            File.WriteAllText(panelConfigurationFile, panelConfigurationJson);
            SetScreenSaved();
        }

        private void SyncModelToUI()
        {
            _isSyncingToUI = true;
            txtName.Text = CurrentPanelConfiguration.Name;
            txtSizeWidth.Text = CurrentPanelConfiguration.PanelWidth.ToString();
            txtSizeHeight.Text = CurrentPanelConfiguration.PanelHeight.ToString();
            txtPositionX.Text = CurrentPanelConfiguration.PanelX.ToString();
            txtPositionY.Text = CurrentPanelConfiguration.PanelY.ToString();
            sliderOpacity.Value = CurrentPanelConfiguration.Opacity;
            chkAlwaysOnTop.Checked = CurrentPanelConfiguration.AlwaysOnTop;

            if (CurrentPanelConfiguration.Id.IsNullOrWhiteSpace())
            {
                sliderOpacity.Value = 100;
            }
            _isSyncingToUI = false;
        }

        private void SyncModelFromUI()
        {
            if (_isSyncingToUI)
                return;

            CurrentPanelConfiguration.Name = txtName.Text;
            CurrentPanelConfiguration.PanelWidth = txtSizeWidth.Text.ToInt();
            CurrentPanelConfiguration.PanelHeight = txtSizeHeight.Text.ToInt();
            CurrentPanelConfiguration.PanelX = txtPositionX.Text.ToInt();
            CurrentPanelConfiguration.PanelY = txtPositionY.Text.ToInt();
            CurrentPanelConfiguration.Opacity = sliderOpacity.Value;
            CurrentPanelConfiguration.AlwaysOnTop = chkAlwaysOnTop.Checked;

            SetScreenUnsaved();
        }

        private void PanelConfigurationWindow_Load(object sender, EventArgs e)
        {
            _isSyncingToUI = false;
            SyncModelToUI();
            ControlUI();
            SetScreenSaved();
        }

        private void ControlUI()
        {
            if (CurrentPanelConfiguration.Id.IsNullOrWhiteSpace())
            {
                lblScreenTitle.Text = "New Panel";
            }
            else
            {
                lblScreenTitle.Text = "Edit Panel";
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SyncModelFromUI();
        }

        private void txtSizeWidth_TextChanged(object sender, EventArgs e)
        {
            SyncModelFromUI();
        }

        private void txtSizeHeight_TextChanged(object sender, EventArgs e)
        {
            SyncModelFromUI();
        }

        private void txtPositionX_TextChanged(object sender, EventArgs e)
        {
            SyncModelFromUI();
        }

        private void txtPositionY_TextChanged(object sender, EventArgs e)
        {
            SyncModelFromUI();
        }

        private void chkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            SyncModelFromUI();
        }

        private void sliderOpacity_Scroll(object sender, EventArgs e)
        {
            lblOpacity.Text = $"Opacity ({sliderOpacity.Value}%)";
            SyncModelFromUI();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_hasUnsavedChanges)
            {
                if (MessageBox.Show("You have unsaved changes. Are you sure you want to close this window?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            Close();
        }

        private void PanelConfigurationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_hasUnsavedChanges)
            {
                if (MessageBox.Show("You have unsaved changes. Are you sure you want to close this window?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private void SetScreenUnsaved()
        {
            _hasUnsavedChanges = true;
        }

        private void SetScreenSaved()
        {
            _hasUnsavedChanges = false;
        }
    }
}
