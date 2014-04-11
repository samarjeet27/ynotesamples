using System;
using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace HelloPlugin
{
    public enum YnoteMenu
    {
        FileMenu = 0,
        EditMenu = 1,
        ViewMenu = 2,
        ToolsMenu = 3,
        MacrosMenu = 4
    }
    [InheritedExport(typeof(IYnotePlugin))]
    public class MyPlugin : IYnotePlugin
    {

        public void Main(IYnote ynote)
        {
            var m = new MenuItem();
            int index = ((int)(YnoteMenu.ViewMenu));
            m.Text = "Say Hello";
            m.Click += (sender, args) => MessageBox.Show("Hello, World!");
            ynote.Menu.MenuItems[index].MenuItems.Add(m);
        }
    }
}
