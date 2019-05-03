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
        private Dock_ChosenDish _dockChosenDish;
        private DockDishInfo _dockDishInfo;
        private Dock_Inventory _dockInventory;
        private Dock_DevelopDish _dockDevelopDish_Calc;
        private Dock_DevelopDish _dockDevelopDish_User;
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

            // [Construct] Hook Events Up
            HookEvents();

            _dockChosenDish = new Dock_ChosenDish(DarkDockArea.Document);
            _dockDishInfo = new DockDishInfo(_dockChosenDish, DarkDockArea.Right);
            _dockInventory = new Dock_Inventory(DarkDockArea.Bottom);
            _dockDevelopDish_Calc = new Dock_DevelopDish();
            _dockDevelopDish_User = new Dock_DevelopDish();

            _dockWindows.Add(_dockChosenDish);            
            _dockWindows.Add(_dockInventory);
            _dockWindows.Add(_dockDishInfo);
            _dockWindows.Add(_dockDevelopDish_Calc);
            _dockWindows.Add(_dockDevelopDish_User);

            foreach (var dockWindow in _dockWindows)
                DockPanel.AddContent(dockWindow);

            // Customize Docks
            DockPanel.Regions[DarkDockArea.Bottom].Height = 200;
            DockPanel.AddContent(_dockDevelopDish_User, _dockDevelopDish_Calc.DockGroup);

            // [Construct] Build Window Menu
            BuildWindowMenu();
        }
        #endregion


        #region [ Load ]
        private void MainForm_Load(object sender, EventArgs e)
        {
            _dockInventory.RefreshNodes();
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
            Menu_DevDish.Click += Menu_Toggle_DevDish;
            Menu_DishInfo.Click += Menu_Toggle_DishInfo;
            Menu_NewDish.Click += Menu_NewDish_Click;
            Menu_Inventory.Click += Menu_Toggle_Inventory;
        }
        #endregion


        #region [ BuildWindowMenu ]  
        private void BuildWindowMenu()
        {
            Menu_DevDish.Checked = DockPanel.ContainsContent(_dockChosenDish);
            Menu_DishInfo.Checked = DockPanel.ContainsContent(_dockDishInfo);
            Menu_Inventory.Checked = DockPanel.ContainsContent(_dockInventory);
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
        // [FILE]->[NEW]
        private void Menu_NewDish_Click(object sender, EventArgs e)
        {
            _dockChosenDish.CreateNewDish();
        }

        // [FILE]->[EXIT]
        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // [WINDOW]->[DEVELOP DISH]
        private void Menu_Toggle_DevDish(object sender, EventArgs e)
        {
            ToggleToolWindow(_dockChosenDish);
        }

        // [WINDOW]->[DISH INFO]
        private void Menu_Toggle_DishInfo(object sender, EventArgs e)
        {
            ToggleToolWindow(_dockDishInfo);
        }

        // [WINDOW]->[INGREDIENT MANAGER]
        private void Menu_Toggle_Inventory(object sender, EventArgs e)
        {
            ToggleToolWindow(_dockInventory);
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
