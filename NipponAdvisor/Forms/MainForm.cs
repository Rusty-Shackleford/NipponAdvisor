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
        private DockCafeDish _dockCafeDish;
        private DockIngredientList _dockIngredients;

        // Default Colors for Status Label
        private Color StatusErrorColor = Color.FromArgb(255, 0, 0); 
        private Color StatusDefaultColor = Color.FromArgb(220, 220, 220);
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

            // [Construct] Hook Events
            HookEvents();

            // DOCK: Dish
            _dockCafeDish = new DockCafeDish(DarkDockArea.Left)
            {
                Name = "DockCafeDish"
            };

            // DOCK: Ingredients
            _dockIngredients = new DockIngredientList(DarkDockArea.Right)
            {
                Name = "DockIngredients"
            };

            // DOCK: Setup
            _dockWindows.Add(_dockCafeDish);
            _dockWindows.Add(_dockIngredients);

            foreach (var dockWindow in _dockWindows)
            {
                DockPanel.AddContent(dockWindow);
                dockWindow.StatusUpdate += UpdateStatusLabel;
            }

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
            // Main Dock Panel
            DockPanel.ContentAdded += DockPanel_ContentAdded;
            DockPanel.ContentRemoved += DockPanel_ContentRemoved;
            // Menu Items
            mnuIngredients.Click += Ingredients_Click;
            mnuDish.Click += Dish_Click;
        }
        #endregion


        #region [ HandleErrorMessages ]
        public void UpdateStatusLabel(object sender, StatusMessageArgs args)
        {
            switch (args.Type)
            {
                case StatusType.Error:
                    LabelStatus.Text = args.Message;
                    LabelStatus.ForeColor = StatusErrorColor;
                    break;
                case StatusType.Ready:
                    LabelStatus.Text = "Ready";
                    LabelStatus.ForeColor = StatusDefaultColor;
                    break;
                case StatusType.Info:
                    LabelStatus.Text = "Ready";
                    LabelStatus.ForeColor = StatusDefaultColor;
                    break;
                case StatusType.Clear:
                    LabelStatus.Text = "Ready";
                    LabelStatus.ForeColor = StatusDefaultColor;
                    break;
                default:
                    break;
            }
            
        }

        private void SetError()
        {
            LabelStatus.ForeColor = StatusErrorColor;
        }

        private void ClearError()
        {
            LabelStatus.ForeColor = StatusDefaultColor;
        }
        #endregion


        #region [ BuildWindowMenu ]     
        // Build the "Window" Menu
        private void BuildWindowMenu()
        {
            mnuDish.Checked = DockPanel.ContainsContent(_dockCafeDish);
            mnuIngredients.Checked = DockPanel.ContainsContent(_dockIngredients);
        }
        #endregion


        #region [ DockPanel / Window Events ]
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
        // Toggle Dish Window
        private void Dish_Click(object sender, EventArgs e)
        {
            ToggleToolWindow(_dockCafeDish);
        }
        // Toggle Ingredients Window
        private void Ingredients_Click(object sender, EventArgs e)
        {
            ToggleToolWindow(_dockIngredients);
        }
        #endregion


        #region [ Menu Item Actions ]
        private void mnuClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        #endregion

    }
}
