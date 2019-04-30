using DarkUI.Docking;
using DarkUI.Forms;
using DarkUI.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NipponAdvisor.Forms.Docks;

namespace NipponAdvisor.Forms
{
    public partial class MainForm : DarkForm
    {
        #region [ Fields ]
        private List<DarkDockContent> _toolWindows = new List<DarkDockContent>();
        private DockDish _dockCafeDish;
        private DockIngredientList _dockIngredients;
        private Dictionary<string, DarkDockArea> DockAreaMapping;
        #endregion

        #region [ Constructor | Load ]
        public MainForm()
        {
            InitializeComponent();

            // Add the control scroll message filter to re-route all mousewheel events
            // to the control the user is currently hovering over with their cursor.
            Application.AddMessageFilter(new ControlScrollFilter());

            // Add the dock content drag message filter to handle moving dock content around.
            Application.AddMessageFilter(DockPanel.DockContentDragFilter);

            // Add the dock panel message filter to filter through for dock panel splitter
            // input before letting events pass through to the rest of the application.
            Application.AddMessageFilter(DockPanel.DockResizeFilter);

            // Hook Events
            HookEvents();

            // Hack - each dock seems to lose its Dock Area if removed from form.
            // Keep a dictionary mapping for later use.
            DockAreaMapping = new Dictionary<string, DarkDockArea>();


            // Docks - Cafe Dish
            _dockCafeDish = new DockDish
            {
                DefaultDockArea = DarkDockArea.None,
                DockArea = DarkDockArea.Left,
                Name = "DockCafeDish"
            };
            DockAreaMapping.Add(_dockCafeDish.Name, DarkDockArea.Left);
            // Docks - Ingredients
            _dockIngredients = new DockIngredientList
            {
                DefaultDockArea = DarkDockArea.None,
                DockArea = DarkDockArea.Right,
                Name = "DockIngredients"
            };
            DockAreaMapping.Add(_dockIngredients.Name, DarkDockArea.Right);

            _toolWindows.Add(_dockCafeDish);
            _toolWindows.Add(_dockIngredients);

            foreach (var toolWindow in _toolWindows)
            {
                DockPanel.AddContent(toolWindow);
            }


            // Build Window Menu
            BuildWindowMenu();

        }

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
            DockPanel.ContentAdded += DockPanel_ContentAdded;
            DockPanel.ContentRemoved += DockPanel_ContentRemoved;
            mnuIngredients.Click += Ingredients_Click;
            mnuDish.Click += Dish_Click;
        }
        #endregion


        #region [ ToggleToolWindow ]
        private void ToggleToolWindow(DarkToolWindow toolWindow)
        {
            toolWindow.DockArea = DockAreaMapping[toolWindow.Name];

            if (toolWindow.DockPanel == null)
                DockPanel.AddContent(toolWindow);
            else
                DockPanel.RemoveContent(toolWindow);
        }
        #endregion


        #region [ BuildWindowMenu ]     
        private void BuildWindowMenu()
        {
            mnuDish.Checked = DockPanel.ContainsContent(_dockCafeDish);
            mnuIngredients.Checked = DockPanel.ContainsContent(_dockIngredients);
        }
        #endregion


        #region [ Events ]
        private void DockPanel_ContentAdded(object sender, DockContentEventArgs e)
        {
            if (_toolWindows.Contains(e.Content))
                BuildWindowMenu();
        }

        private void DockPanel_ContentRemoved(object sender, DockContentEventArgs e)
        {
            if (_toolWindows.Contains(e.Content))
                BuildWindowMenu();
        }

        private void Dish_Click(object sender, EventArgs e)
        {
            ToggleToolWindow(_dockCafeDish);
        }

        private void Ingredients_Click(object sender, EventArgs e)
        {
            ToggleToolWindow(_dockIngredients);
        }
        #endregion
    }
}
