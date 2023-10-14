using SensorPanelUtility.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        private PanelWindow _panelWindow;

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



        public void SyncModelToUI()
        {
            _isSyncingToUI = true;

            if (txtName.Text != CurrentPanelConfiguration.Name)
                txtName.Text = CurrentPanelConfiguration.Name;

            if (txtSizeWidth.Text != CurrentPanelConfiguration.PanelWidth.ToString())
                txtSizeWidth.Text = CurrentPanelConfiguration.PanelWidth.ToString();

            if (txtSizeHeight.Text != CurrentPanelConfiguration.PanelHeight.ToString())
                txtSizeHeight.Text = CurrentPanelConfiguration.PanelHeight.ToString();

            if (txtPositionX.Text != CurrentPanelConfiguration.PanelX.ToString())
                txtPositionX.Text = CurrentPanelConfiguration.PanelX.ToString();

            if (txtPositionY.Text != CurrentPanelConfiguration.PanelY.ToString())
                txtPositionY.Text = CurrentPanelConfiguration.PanelY.ToString();

            if (sliderOpacity.Value != CurrentPanelConfiguration.Opacity)
                sliderOpacity.Value = CurrentPanelConfiguration.Opacity;

            if (chkAlwaysOnTop.Checked != CurrentPanelConfiguration.AlwaysOnTop)
                chkAlwaysOnTop.Checked = CurrentPanelConfiguration.AlwaysOnTop;

            if (btnBGColor.BackColor.ToArgb() != CurrentPanelConfiguration.BackgroundColor)
                btnBGColor.BackColor = Color.FromArgb(CurrentPanelConfiguration.BackgroundColor);

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
            CurrentPanelConfiguration.BackgroundColor = btnBGColor.BackColor.ToArgb();

            SetScreenUnsaved();
            ControlUI();
        }

        private void PanelConfigurationWindow_Load(object sender, EventArgs e)
        {
            _isSyncingToUI = false;

            // If it's a new panel, set some defaults
            if (CurrentPanelConfiguration.Id.IsNullOrWhiteSpace())
            {
                CurrentPanelConfiguration.Opacity = 100;
                CurrentPanelConfiguration.PanelWidth = 500;
                CurrentPanelConfiguration.PanelHeight = 500;
                CurrentPanelConfiguration.BackgroundColor = Color.Black.ToArgb();
            }

            ShowThePanel();
            SyncModelToUI();
            ControlUI();
            SetScreenSaved();

        }

        private void ShowThePanel()
        {
            _panelWindow = new PanelWindow();
            _panelWindow.PanelConfigurationWindow = this;
            _panelWindow.Width = CurrentPanelConfiguration.PanelWidth;
            _panelWindow.Height = CurrentPanelConfiguration.PanelHeight;
            _panelWindow.Left = CurrentPanelConfiguration.PanelX;
            _panelWindow.Top = CurrentPanelConfiguration.PanelY;
            _panelWindow.Show();
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

            if (_panelWindow != null)
            {
                _panelWindow.Left = CurrentPanelConfiguration.PanelX;
                _panelWindow.Top = CurrentPanelConfiguration.PanelY;
                _panelWindow.Width = CurrentPanelConfiguration.PanelWidth;
                _panelWindow.Height = CurrentPanelConfiguration.PanelHeight;
                _panelWindow.Opacity = CurrentPanelConfiguration.Opacity / 100.0;

                if (CurrentPanelConfiguration.BackgroundColor != 0)
                    _panelWindow.BackColor = Color.FromArgb(CurrentPanelConfiguration.BackgroundColor);

                if (_panelWindow.TopMost != CurrentPanelConfiguration.AlwaysOnTop)
                    _panelWindow.TopMost = CurrentPanelConfiguration.AlwaysOnTop;
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
            Close();
        }

        private void PanelConfigurationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_hasUnsavedChanges)
            {
                var result = MessageBox.Show("You have unsaved changes. Do you want to save now?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    SavePanelConfiguration();
                }
            }
            _panelWindow.Close();
            _panelWindow.Dispose();
        }

        public void SetScreenUnsaved()
        {
            _hasUnsavedChanges = true;
        }

        public void SetScreenSaved()
        {
            _hasUnsavedChanges = false;
        }

        private void btnBGColor_Click(object sender, EventArgs e)
        {
            var color = colorDialog1.ShowDialog();
            if (color == DialogResult.OK)
            {
                btnBGColor.BackColor = colorDialog1.Color;
                SyncModelFromUI();
                SetScreenUnsaved();
            }
        }

        private void btnAddWidget_Click(object sender, EventArgs e)
        {

        }
    }
}
