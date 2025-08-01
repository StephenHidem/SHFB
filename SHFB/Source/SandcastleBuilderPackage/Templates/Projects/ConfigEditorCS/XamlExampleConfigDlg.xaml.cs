﻿using System;
using System.ComponentModel.Composition.Hosting;
using System.Windows;
using System.Xml.Linq;

using Sandcastle.Core;
using Sandcastle.Core.PlugIn;
using Sandcastle.Core.Project;

/* TODO: Include the build output in your component or plug-in project.  Add the following element to include
         the assembly from this project in the component or plug-in project's package output.  If there are
         other dependencies besides the Sandcastle assemblies, you may need to add additional elements for them
         as well.

         This keeps the platform-specific UI elements isolated and allows the component to work with MSBuild and
         dotnet build.

        <ItemGroup>
            <None Include="..\$safeprojectname$\bin\$(Configuration)\net48\$safeprojectname$.dll">
                <Pack>true</Pack>
                <PackagePath>tools\</PackagePath>
                <Visible>false</Visible>
            </None>
        </ItemGroup>
*/

namespace $safeprojectname$
{
    /// <summary>
    /// This is an example configuration form for a build component or plug-in created with XAML
    /// </summary>
    public partial class XamlExampleConfigDlg : Window
    {
        // TODO: Implement the editor factory for your build component or plug-in.  Remove the factory class
        // that you don't need.

        // TOOD: For a plug-in
        #region Plug-in configuration editor factory for MEF
        //=====================================================================

        /// <summary>
        /// This allows editing of the plug-in configuration
        /// </summary>
        [PlugInConfigurationEditorExport("TODO: Put your build component ID here")]
        public sealed class PlugInFactory : IPlugInConfigurationEditor
        {
            /// <inheritdoc />
            public bool EditConfiguration(SandcastleProject project, XElement configuration)
            {
                var dlg = new XamlExampleConfigDlg(configuration);

                return dlg.ShowDialog() ?? false;
            }
        }
        #endregion

        // TODO: For a build component
        #region Build component configuration editor factory for MEF
        //=====================================================================

        /// <summary>
        /// This allows editing of the component configuration
        /// </summary>
        [ConfigurationEditorExport("TODO: Put your build component ID here")]
        public sealed class BuildComponentFactory : IConfigurationEditor
        {
            /// <inheritdoc />
            public bool EditConfiguration(XElement configuration, CompositionContainer container)
            {
                var dlg = new XamlExampleConfigDlg(configuration);

                return dlg.ShowDialog() ?? false;
            }
        }
        #endregion

        #region Private data members
        //=====================================================================

        private readonly XElement configuration;

        #endregion

        #region Constructor
        //=====================================================================

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration">The current configuration element</param>
        public XamlExampleConfigDlg(XElement configuration)
        {
            InitializeComponent();

            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            // TODO: Load configuration from the XML and set the control values
            var node = configuration.Element("configElement");

            if(node != null)
                txtExample.Text = node.Attribute("configValue")?.Value;
        }
        #endregion

        #region Event handlers
        //=====================================================================

        /// <summary>
        /// Save changes to the configuration
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event arguments</param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Validate the settings and update the configuration elements with values from the controls
            var node = configuration.Element("configElement");

            if(node == null)
            {
                node = new XElement("configElement", new XAttribute("configValue", String.Empty));
                configuration.Add(node);
            }

            node.Attribute("configValue").Value = txtExample.Text;

            this.DialogResult = true;
            this.Close();
        }
        #endregion
    }
}
