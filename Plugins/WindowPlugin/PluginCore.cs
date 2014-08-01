using System.ComponentModel.Composition;
using System.Windows.Forms;
using SS.Ynote.Classic.Extensibility;
using WeifenLuo.WinFormsUI.Docking;

namespace WindowPlugin
{
    public enum YnoteMenu
    {
        FileMenu = 0,
        EditMenu = 1,
        ViewMenu = 2,
        GotoMenu = 3,
        ToolsMenu = 4,
        ProjectMenu = 5,
        MacrosMenu = 6,
        HelpMenu = 7
    }

    [InheritedExport(typeof(IYnotePlugin))]
    public class MyPlugin : IYnotePlugin
    {
        public void Main(IYnote ynote)
        {
            var m = new MenuItem();
            int index = ((int)(YnoteMenu.ViewMenu));
            m.Text = "Window Plugin";
            m.Click += (sender, args) => new Window(ynote).Show(ynote.Panel,DockState.DockLeft);
            ynote.Menu.MenuItems[index].MenuItems.Add(m);
            m.Index = 7;
        }
    }
}
