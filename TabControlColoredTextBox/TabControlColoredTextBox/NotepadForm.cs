using System;
using Microsoft.CSharp;
using System.Diagnostics;
using FastColoredTextBoxNS;
using System.Windows.Forms;
using System.CodeDom.Compiler;

namespace TabControlColoredTextBox
{
    public partial class NotepadForm : Form
    {
        public NotepadForm()
        {
            InitializeComponent();
        }

        private void NewTabButtonClick(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage("New tab");
            FastColoredTextBox fastColoredTextBox = new FastColoredTextBox();
            fastColoredTextBox.Dock = DockStyle.Fill;
            tabPage.Controls.Add(fastColoredTextBox);
            mainTabControl.TabPages.Add(tabPage);
            mainTabControl.SelectedTab = tabPage;
        }

        private void CompileButtonClick(object sender, EventArgs e)
        {
            string exeName = $"{nameof(NotepadForm)}.exe";

            CSharpCodeProvider codeProvider = new CSharpCodeProvider();

            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateExecutable = true;
            compilerParams.GenerateInMemory = false;
            compilerParams.OutputAssembly = exeName;

            CompilerResults result = codeProvider.CompileAssemblyFromSource(compilerParams, mainFastColoredTextBox.Text);

            if (result.Errors.HasErrors)
                MessageBox.Show("Errors!");
            else
                Process.Start(exeName);
        }

        private void CloseTabButtonClick(object sender, EventArgs e)
        {
            if (mainTabControl.TabCount > 0 && mainTabControl.SelectedTab.Text != "Main")
                mainTabControl.TabPages.Remove(mainTabControl.SelectedTab);
        }
    }
}
