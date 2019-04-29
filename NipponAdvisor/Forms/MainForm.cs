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


            _dockCafeDish = new DockDish();
            _dockCafeDish.DefaultDockArea = DarkDockArea.None;
            _dockCafeDish.DockArea = DarkDockArea.Left;

            _toolWindows.Add(_dockCafeDish);

            foreach (var toolWindow in _toolWindows)
            {
                DockPanel.AddContent(toolWindow);
            }

        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        #endregion


        #region [ HookEvents ]
        private void HookEvents()
        {

        }
        #endregion
    }
}
