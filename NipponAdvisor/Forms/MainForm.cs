using DarkUI.Docking;
using DarkUI.Forms;
using DarkUI.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NipponAdvisor.Forms.Docks;
using System.Drawing;
using NipponAdvisor.DarkUIExt;


namespace NipponAdvisor.Forms
{
    public partial class MainForm : DarkForm
    {
        #region [ Fields ]
        private List<DarkToolWindowExt> _dockWindows = new List<DarkToolWindowExt>();
        private DockDevDish _dockDevDish;
        private DockIngredientList _dockIngredients;
        private DockDishInfo _dockDishInfo;
        #endregion

        #region [ Constructor | Load ]
        public MainForm()
        {
            InitializeComponent();

            // [Construct] Add the control scroll message filter to re-route all mousewheel events
            // to the control the user is currently hovering over with their cursor.
            Application.AddMessageFilter(new ControlScrollFilter());

            // [Construct] Add the dock content drag message filter to handle moving dock content around.
            Application.AddMessageFilter(DockPanel.DockContentDragFilter);

            // [Construct] Add the dock panel message filter to filter through for dock panel splitter
            // input before letting events pass through to the rest of the application.
            Application.AddMessageFilter(DockPanel.DockResizeFilter);

            HookEvents();

            _dockDevDish = new DockDevDish(DarkDockArea.Left);
            _dockIngredients = new DockIngredientList(DarkDockArea.Right);
            _dockDishInfo = new DockDishInfo(_dockDevDish, DarkDockArea.Bottom);

            _dockWindows.Add(_dockDevDish);
            _dockWindows.Add(_dockIngredients);
            _dockWindows.Add(_dockDishInfo);

            // Adding Docks
            foreach (var dockWindow in _dockWindows)
                DockPanel.AddContent(dockWindow);

            // Custom dock placements:
            DockPanel.AddContent(_dockDishInfo, _dockDevDish.DockGroup);

            // [Construct] Build Window Menu
            BuildWindowMenu();
        }
        #endregion


        #region [ Load ]
        private void MainForm_Load(object sender, EventArgs e)
        {
            _dockIngredients.RefreshNodes();
            //_dockIngredients.Hide();
            //_dockIngredients.Show();
        }
        #endregion


        #region [ HookEvents ]
        private void HookEvents()
        {
            // Serialization
            FormClosing += MainForm_FormClosing;

            // Main Dock Panel
            DockPanel.ContentAdded += DockPanel_ContentAdded;
            DockPanel.ContentRemoved += DockPanel_ContentRemoved;

            // Menu Items
            Menu_ViewIngredients.Click += Menu_ViewIngredients_Click;
            Menu_ViewDevDish.Click += Menu_ViewDevDish_Click;
            Menu_ViewDishInfo.Click += Menu_ViewDishInfo_Click;
            Menu_NewDish.Click += Menu_NewDish_Click;
        }
        #endregion


        #region [ BuildWindowMenu ]     
        // Build the "Window" Menu
        private void BuildWindowMenu()
        {
            Menu_ViewDevDish.Checked = DockPanel.ContainsContent(_dockDevDish);
            Menu_ViewIngredients.Checked = DockPanel.ContainsContent(_dockIngredients);
            Menu_ViewDishInfo.Checked = DockPanel.ContainsContent(_dockDishInfo);
        }
        #endregion


        #region [ DockPanel Methods ]
        // Save Form State
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeDockPanel("dockpanel.config");
        }

        // Toggle Form Docks
        private void ToggleToolWindow(DarkToolWindowExt toolWindow)
        {
            if (toolWindow.DockPanel == null)
                DockPanel.AddContent(toolWindow);
            else
                DockPanel.RemoveContent(toolWindow);
        }
        // Adding Docks
        private void DockPanel_ContentAdded(object sender, DockContentEventArgs e)
        {

            if (_dockWindows.Contains(e.Content as DarkToolWindowExt))
                BuildWindowMenu();
        }
        // Removing Docks
        private void DockPanel_ContentRemoved(object sender, DockContentEventArgs e)
        {
            if (_dockWindows.Contains(e.Content as DarkToolWindowExt))
                BuildWindowMenu();
        }

        #endregion


        #region [ Menu Item Actions ]
        // File -> New Dish
        private void Menu_NewDish_Click(object sender, EventArgs e)
        {
            _dockDevDish.CreateNewDish();
        }
        // File -> Exit
        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Window -> Dish Info
        private void Menu_ViewDevDish_Click(object sender, EventArgs e)
        {
            ToggleToolWindow(_dockDevDish);
        }
        // Window -> Ingredients
        private void Menu_ViewIngredients_Click(object sender, EventArgs e)
        {
            ToggleToolWindow(_dockIngredients);
        }
        // Window -> Dish Info
        private void Menu_ViewDishInfo_Click(object sender, EventArgs e)
        {
            ToggleToolWindow(_dockDishInfo);
        }

        #endregion


        #region Serialization Region

        private void SerializeDockPanel(string path)
        {
            var state = DockPanel.GetDockPanelState();
            SerializerHelper.Serialize(state, path);
        }

        private void DeserializeDockPanel(string path)
        {
            var state = SerializerHelper.Deserialize<DockPanelState>(path);
            DockPanel.RestoreDockPanelState(state, GetContentBySerializationKey);
        }

        private DarkDockContent GetContentBySerializationKey(string key)
        {
            foreach (var window in _dockWindows)
            {
                if (window.SerializationKey == key)
                    return window;
            }

            return null;
        }

        #endregion

    }
}
