using SensorPanelUtility.Models;
using System.Text.Json;

namespace SensorPanelUtility
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            PopulateListOfPanels();
            ControlUI();


        }

        private PanelConfiguration _selectedPanel;



        private void PopulateListOfPanels()
        {
            listBoxPanels.Items.Clear();

            var panelsDirectory = $@"{Application.StartupPath}panels";
            if (!Directory.Exists(panelsDirectory))
            {
                Directory.CreateDirectory(panelsDirectory);
            }

            listBoxPanels.DisplayMember = "Name";
            listBoxPanels.ValueMember = "Id";

            // Fill up the list of available panels (Each panel configuration is a json file)
            var panelFiles = Directory.GetFiles(panelsDirectory, "*.json");
            foreach (var panelFile in panelFiles)
            {
                var panel = JsonSerializer.Deserialize<PanelConfiguration>(File.ReadAllText(panelFile));
                listBoxPanels.Items.Add(panel);

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var panelConfigurationWindow = new PanelConfigurationWindow();
            panelConfigurationWindow.CurrentPanelConfiguration = new PanelConfiguration();
            panelConfigurationWindow.ShowDialog();

            PopulateListOfPanels();

            if (panelConfigurationWindow.CurrentPanelConfiguration != null)
            {
                listBoxPanels.SelectedItem = panelConfigurationWindow.CurrentPanelConfiguration;
            }
        }

        private void listBoxPanels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPanels.SelectedIndex >= 0)
            {
                _selectedPanel = listBoxPanels.SelectedItem as PanelConfiguration;
            }
            else
            {
                _selectedPanel = null;
            }

            ControlUI();
        }

        private void ControlUI()
        {
            btnExport.Enabled = _selectedPanel != null;
            btnModify.Enabled = _selectedPanel != null;
            btnRemove.Enabled = _selectedPanel != null;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var panelConfigurationWindow = new PanelConfigurationWindow();
            panelConfigurationWindow.CurrentPanelConfiguration = _selectedPanel;
            panelConfigurationWindow.ShowDialog();

            PopulateListOfPanels();

            if (panelConfigurationWindow.CurrentPanelConfiguration != null)
            {
                listBoxPanels.SelectedItem = panelConfigurationWindow.CurrentPanelConfiguration;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this panel?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            var panelFile = $@"{Application.StartupPath}panels\{_selectedPanel.Id}.json";
            File.Delete(panelFile);
            _selectedPanel = null;

            PopulateListOfPanels();
            ControlUI();
        }
    }
}