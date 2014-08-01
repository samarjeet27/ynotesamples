using System;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using SS.Ynote.Classic.Core.Extensibility;
using SS.Ynote.Classic.Core.Project;
using SS.Ynote.Classic.Core.RunScript;
using SS.Ynote.Classic.Core.Snippets;
using SS.Ynote.Classic.UI;
using WeifenLuo.WinFormsUI.Docking;

namespace WindowPlugin
{
    public class Window : DockContent
    {
        private System.Windows.Forms.Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private IYnote _ynote;

        public Window(IYnote ynote)
        {
            InitializeComponent();
            this._ynote = ynote;
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ask for Input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Trace To Status Bar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Run YnoteScript";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(141, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Info of Active Document";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(141, 335);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 58);
            this.button5.TabIndex = 4;
            this.button5.Text = "Close Active Window";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 57);
            this.button6.TabIndex = 5;
            this.button6.Text = "Create New Document";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 75);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 57);
            this.button7.TabIndex = 6;
            this.button7.Text = "Open File";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 149);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 57);
            this.button8.TabIndex = 7;
            this.button8.Text = "Save File";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(140, 273);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 56);
            this.button9.TabIndex = 8;
            this.button9.Text = "Info of Active Project";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 225);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(122, 57);
            this.button10.TabIndex = 9;
            this.button10.Text = "Execute RunScript";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 300);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(122, 57);
            this.button11.TabIndex = 10;
            this.button11.Text = "Insert Snippet";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Window
            // 
            this.ClientSize = new System.Drawing.Size(269, 416);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Window";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ynote.AskInput("Name:", (o, args) => MessageBox.Show("Your name is " + args.GetFormattedInput()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ynote.AskInput("Message:", (o, args) => _ynote.Trace(args.GetFormattedInput(), 1000));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Ynote Scripts (*.ys)|*.ys";
                dlg.ShowDialog();
                if (!string.IsNullOrEmpty(dlg.FileName))
                {
                    YnoteScript.RunScript(_ynote,dlg.FileName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();
            var doc = _ynote.Panel.ActiveDocument as Editor;
            if (doc != null)
            {
                if (doc.IsSaved)
                {
                    // file name
                    builder.Append("File : " + doc.Name + "\n");
                }
                builder.Append("Language : " + doc.Tb.Language + "\n");
                builder.Append("Tab Text : " + doc.Text + "\n");
                builder.Append("Lines : " + doc.Tb.LinesCount + "\n");
                // add 1 as they are indexed
                int line = doc.Tb.Selection.Start.iLine + 1;
                int column = doc.Tb.Selection.Start.iChar + 1;
                builder.Append("Active line : " + line + "\n");
                builder.Append("Active Column : " + column + "\n");
            }
            MessageBox.Show(builder.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _ynote.Panel.ActiveDocument.DockHandler.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _ynote.CreateNewDoc();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _ynote.OpenFile(dlg.FileName);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _ynote.SaveEditor(_ynote.Panel.ActiveDocument as Editor);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            YnoteProject proj = _ynote.GetActiveProject();
            if (proj != null)
            {
                var builder = new StringBuilder();
                builder.Append("Project Name : " + proj.Name + "\n");
                builder.Append("Project File Path : " + proj.FilePath + "\n");
                builder.Append("Excluded Directories : " + proj.ExcludeDirectories + "\n");
                builder.Append("Excluded File Types : " + proj.ExcludeFileTypes + "\n");
                builder.Append("Project Directory : " + proj.Path + "\n");
                MessageBox.Show(builder.ToString());
            }
            else
            {
                MessageBox.Show("Please open a project");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "RunScript (*.ynoterun)|*.ynoterun";
                if(dlg.ShowDialog() == DialogResult.OK)
                    RunScript.Get(dlg.FileName).Run();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Ynote Snippet (*.ynotesnipet)|*.ynotesnippet";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    YnoteSnippet snip = YnoteSnippet.Read(dlg.FileName);
                    var edit = _ynote.Panel.ActiveDocument as Editor;
                    if(edit != null)
                        edit.InsertSnippet(snip);
                }
            }
        }
    }
}
