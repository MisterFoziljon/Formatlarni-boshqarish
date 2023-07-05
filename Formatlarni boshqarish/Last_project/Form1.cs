using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Last_project
{
    public partial class Form1 : Form
    {
        
        private Panel[] buttons = new Panel[100];
        private Label[] labels= new Label[100];
        private Label[] label=new Label[100];
        private TextBox[]textbox=new TextBox[100];
        //public string 
        public string[,] files;
        public string path = @"C:\Users\Azure AI\Desktop\Foziljon\Dasturlash asoslari\Dasturlar\Tizimli\Last_project\data.txt";
        public string asosiy_adres;
        public Form1(string asosiy_adres)
        {
            InitializeComponent();
            this.asosiy_adres = asosiy_adres; // ichki fayllar soni
            
            CreateContextMenu();
            r001.Enabled = false;
            r000.Enabled = true;
            r010.Enabled = false;
            r100.Enabled = false;
            r110.Enabled = false;

            int posx = 10, posy = 35;
            for (int i = 0; i < 100; i++)
            {
                buttons[i] = new Panel();
                labels[i] = new Label();
                label[i] = new Label();
                textbox[i] = new TextBox();

                textbox[i].Name = Convert.ToString(i);
                labels[i].Name = Convert.ToString(i);
                label[i].Name = Convert.ToString(i);
                buttons[i].Name = Convert.ToString(i);

                buttons[i].Width = 60;
                buttons[i].Height = 60;

                buttons[i].Location = new Point(posx, posy);
                labels[i].Location = new Point(posx, posy+70);
                label[i].Location = new Point(posx, posy+70);
                textbox[i].Location = new Point(posx, posy+70);
                textbox[i].Width = 60;

                buttons[i].Visible = false;
                textbox[i].Visible = false;
                
                buttons[i].Click += new System.EventHandler(clicker);
                label[i].DoubleClick+=new System.EventHandler(label_double_click);
                buttons[i].DoubleClick += new System.EventHandler(dclicker);

                buttons[i].BackColor = Color.Transparent;
                posx += 100;
                Controls.Add(textbox[i]);
                Controls.Add(buttons[i]);
                Controls.Add(labels[i]);
                Controls.Add(label[i]);
                
                if ((i + 1) % 10 == 0)
                {
                    posx = 10;
                    posy += 100;
                }
            }
        }

        private void label_double_click(object sender, EventArgs e)
        {
            Label button = sender as Label;
            for (int i = 0; i < 100; i++)
                if (labels[i].Text == button.Text)
                {
                    //textbox[i].Text = label[i].Text;
                    textbox[i].Visible = true;
                    labels[i].Visible = false;
                    label[i].Visible=false;
                    break;
                }
        }

        private void clicker(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
                buttons[i].BackColor = Color.Transparent;
            files = dataset();
            Panel button = sender as Panel;
            button.BackColor = Color.Blue;

            for (int j = 0; j < 100; j++)
            {
                if (buttons[j].BackColor == Color.Blue)
                {
                    if (textbox[j].Text.EndsWith(".sys"))
                        r100.Checked = true;

                    if (textbox[j].Text.EndsWith(".txt"))
                        r010.Checked = true;

                    if (textbox[j].Text.EndsWith(".jpg"))
                        r001.Checked = true;

                    if (textbox[j].Text.EndsWith(".psd"))
                        r010.Checked = true;

                    if (textbox[j].Text.EndsWith(".mp3"))
                        r001.Checked = true;

                    if(buttons[j].Name.StartsWith("Folder"))
                        r110.Checked = true;

                    if (buttons[j].Name.StartsWith("File"))
                        r110.Checked = true;
                }
            }

            for (int i = 0; i < 100; i++)
            {
                if (textbox[i].Visible == true)
                {
                    labels[i].Visible = false;
                    string datetime = DateTime.Now.ToString("hh:mm:ss tt");
                    if (textbox[i].Text.Length != 0 && !buttons[i].Name.StartsWith("Folder") && !(textbox[i].Text.EndsWith(".txt")|| textbox[i].Text.EndsWith(".sys") || textbox[i].Text.EndsWith(".mp3") || textbox[i].Text.EndsWith(".psd") || textbox[i].Text.EndsWith(".jpg")))
                    {
                        buttons[i].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\file.png");
                        buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                        for(int k=0;k<files.GetLength(0);k++)
                        {
                            int count = files[i,7].Count(f => f == '\\');
                            int son = asosiy_adres.Count(f => f == '\\');

                            if (files[k,1]==labels[i].Text && files[k,2]=="" && son==count)
                            {
                                string message = "Bunday fayl mavjud.Boshqa nom bilan tahrirlansinmi?";
                                string caption = "Qayta nomlash";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result;

                                result = MessageBox.Show(this, message, caption, buttons,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign);

                                if (result == DialogResult.Yes)
                                {
                                    labels[i].Text = textbox[i].Text;
                                }

                                else
                                {
                                    //"Text" + indexOfdata("Text","txt").ToString() + ".txt";
                                }
                            }
                        }
                        buttons[i].Name = "File" + (i + 1).ToString();

                        File.AppendAllText(path, buttons[i].Name + "\t" + labels[i].Text + "\t" + "" + "\t" + "0" + "\t" + "010" + "\t" + datetime + "\t" + "-" + "\t" + asosiy_adres + labels[i].Text + "\n");
                    }

                    if(buttons[i].Name.StartsWith("Folder"))
                    {
                        buttons[i].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\folder.png");
                        buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                        labels[i].Text = textbox[i].Text;
                        label[i].Text = labels[i].Text;

                        File.AppendAllText(path, buttons[i].Name + "\t" + labels[i].Text + "\t" + "" + "\t" + "0" + "\t" + "100" + "\t" + datetime + "\t" + "-" + "\t" + asosiy_adres + labels[i].Text + "\n");
                    }

                    if (textbox[i].Text.EndsWith(".sys") && buttons[i].Name!="Folder")
                    {
                        buttons[i].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\sys.png");
                        buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                        labels[i].Text = textbox[i].Text;
                        label[i].Text = name_files(textbox[i].Text.Split('.')[0], textbox[i].Text.Split('.')[1], asosiy_adres + textbox[i].Text);
                        buttons[i].Name = "sys" + (i + 1).ToString();
                       
                        File.AppendAllText(path, buttons[i].Name + "\t" + labels[i].Text.Split('.')[0] + "\t" + labels[i].Text.Split('.')[1] + "\t" + "0" + "\t" + "100" + "\t" + datetime + "\t" + "-" + "\t" + asosiy_adres + labels[i].Text + "\n");
                    }

                    if (textbox[i].Text.EndsWith(".txt") && buttons[i].Name != "Folder")
                    {
                        buttons[i].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\textpad.png");
                        buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                        labels[i].Text = textbox[i].Text;
                        
                        label[i].Text = name_files(textbox[i].Text.Split('.')[0], textbox[i].Text.Split('.')[1], asosiy_adres + textbox[i].Text);
                        buttons[i].Name = "Text" + (i + 1).ToString();

                        for (int k = 0; k < files.GetLength(0); k++)
                        {
                            int count = files[k, 7].Count(f => f == '\\');
                            int son = asosiy_adres.Count(f => f == '\\');

                            if (files[k, 1] == labels[i].Text.Split('.')[0] && files[k, 2] == labels[i].Text.Split('.')[1] && son == count)
                            {
                                string message = "Bunday fayl mavjud.Boshqa nom bilan tahrirlansinmi?";
                                string caption = "Qayta nomlash";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result;

                                result = MessageBox.Show(this, message, caption, buttons,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign);

                                if (result == DialogResult.Yes)
                                {
                                    if (files[k, 1].Length < 12)
                                    {
                                        labels[i].Text = textbox[i].Text.Split('.')[0] + indexOfdata(textbox[i].Text.Split('.')[0], textbox[i].Text.Split('.')[1]) + "." + textbox[i].Text.Split('.')[1];
                                        label[i].Text = labels[i].Text;
                                    }

                                    else if(files[k, 1].Length >= 12)
                                    {
                                        label[i].Text = name_files(textbox[i].Text.Split('.')[0], textbox[i].Text.Split('.')[1], asosiy_adres + textbox[i].Text);
                                    }
                                }

                                else
                                    labels[i].Text = "Text" + indexOfdata("Text", "txt").ToString() + ".txt";
                            }
                        }

                        File.AppendAllText(path, buttons[i].Name + "\t" + labels[i].Text.Split('.')[0] + "\t" + labels[i].Text.Split('.')[1] + "\t" + "0" + "\t" + "010" + "\t" + datetime + "\t" + "-" + "\t" + asosiy_adres + labels[i].Text + "\n");
                    }

                    if (textbox[i].Text.EndsWith(".mp3") && buttons[i].Name != "Folder")
                    {
                        buttons[i].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\mp3.png");
                        buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                        labels[i].Text = textbox[i].Text;
                        label[i].Text = name_files(textbox[i].Text.Split('.')[0], textbox[i].Text.Split('.')[1], asosiy_adres + textbox[i].Text);
                        buttons[i].Name = "Audio" + (i + 1).ToString();
                        File.AppendAllText(path, buttons[i].Name + "\t" + labels[i].Text.Split('.')[0] + "\t" + labels[i].Text.Split('.')[1] + "\t" + "0" + "\t" + "001" + "\t" + datetime + "\t" + "-" + "\t" + asosiy_adres + labels[i].Text + "\n");
                    }

                    if (textbox[i].Text.EndsWith(".psd") && buttons[i].Name != "Folder")
                    {
                        buttons[i].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\photoshop.png");
                        buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                        labels[i].Text = textbox[i].Text;
                        label[i].Text = name_files(textbox[i].Text.Split('.')[0], textbox[i].Text.Split('.')[1], asosiy_adres + textbox[i].Text);
                        buttons[i].Name = "Photoshop" + (i + 1).ToString();
                        File.AppendAllText(path, buttons[i].Name + "\t" + labels[i].Text.Split('.')[0] + "\t" + labels[i].Text.Split('.')[1] + "\t" + "0" + "\t" + "010" + "\t" + datetime + "\t" + "-" + "\t" + asosiy_adres + labels[i].Text + "\n");
                    }

                    if (textbox[i].Text.EndsWith(".jpg") && buttons[i].Name != "Folder")
                    {
                        buttons[i].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\jpg.png");
                        buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                        labels[i].Text = textbox[i].Text;
                        label[i].Text = name_files(textbox[i].Text.Split('.')[0], textbox[i].Text.Split('.')[1], asosiy_adres + textbox[i].Text);
                        buttons[i].Name = "Jpeg" + (i + 1).ToString();
                        File.AppendAllText(path, buttons[i].Name + "\t" + labels[i].Text.Split('.')[0] + "\t" + labels[i].Text.Split('.')[1] + "\t" + "0" + "\t" + "001" + "\t" + datetime + "\t" + "-" + "\t" + asosiy_adres + labels[i].Text + "\n");
                    }
                    
                    textbox[i].Visible = false;
                    label[i].Visible = true;
                }
            }

            datagrid.Rows.Clear();
            files = dataset();
            for (int i = 0; i < files.GetLength(0); i++)
                datagrid.Rows.Add(files[i, 1], files[i, 2], files[i, 3], files[i, 4], files[i, 5], files[i, 6],files[i,7]+"\n");
        }

        private void dclicker(object sender, EventArgs e)
        {
            Panel button = sender as Panel;
            int index = -1;
            for(int i=0;i<100;i++)
            {
                if (buttons[i].BackColor == Color.Blue)
                    index = i;
            }
            if(button.Name.StartsWith("Folder"))
            {
                Form1 folder = new Form1(asosiy_adres+labels[index].Text+"\\");
                folder.Show();
            }
        }
        private void CreateContextMenu()
        {
            ContextMenuStrip menuStrip = contextMenuStrip1;

            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("TextPad");
            menuItem1.Click += new EventHandler(menuItem_Click);
            menuItem1.Name = "TextPad";
            menuStrip.Items.Add(menuItem1);

            ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Audio");
            menuItem2.Click += new EventHandler(menuItem_Click);
            menuItem2.Name = "Audio";
            menuStrip.Items.Add(menuItem2);

            ToolStripMenuItem menuItem3 = new ToolStripMenuItem("Photoshop");
            menuItem3.Click += new EventHandler(menuItem_Click);
            menuItem3.Name = "Photoshop";
            menuStrip.Items.Add(menuItem3);

            ToolStripMenuItem menuItem4 = new ToolStripMenuItem("Jpeg");
            menuItem4.Click += new EventHandler(menuItem_Click);
            menuItem4.Name = "Jpeg";
            menuStrip.Items.Add(menuItem4);

            ToolStripMenuItem menuItem5 = new ToolStripMenuItem("Folder");
            menuItem5.Click += new EventHandler(menuItem_Click);
            menuItem5.Name = "Folder";
            menuStrip.Items.Add(menuItem5);

            this.ContextMenuStrip = menuStrip;
        }

        void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            int index = checking_btn_last();
            for (int i = 0; i < 100; i++)
                buttons[i].BackColor = Color.Transparent;
            buttons[index].Visible = true;
            textbox[index].Visible = true;
            labels[index].Visible = false;
            if (menuItem.Name == "TextPad")
            {
                buttons[index].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\textpad.png");
                buttons[index].BackgroundImageLayout = ImageLayout.Stretch;
                labels[index].Text = "Text" + indexOfdata("Text","txt").ToString() + ".txt";
                textbox[index].Text = labels[index].Text;
                buttons[index].Name = "Text" + (index + 1).ToString();
                buttons[index].BackColor = Color.Blue;
                r010.Checked = true;
            }

            if (menuItem.Name == "Audio")
            {
                buttons[index].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\mp3.png");
                buttons[index].BackgroundImageLayout = ImageLayout.Stretch;
                labels[index].Text = "Audio" + indexOfdata("Audio","mp3").ToString() + ".mp3";
                textbox[index].Text = labels[index].Text;
                buttons[index].Name = "Audio" + (index + 1).ToString();
                buttons[index].BackColor = Color.Blue;
                r001.Checked = true;
            }

            if (menuItem.Name == "Photoshop")
            {
                buttons[index].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\photoshop.png");
                buttons[index].BackgroundImageLayout = ImageLayout.Stretch;
                labels[index].Text = "Photoshop" + indexOfdata("Photoshop","psd").ToString() + ".psd";
                textbox[index].Text = labels[index].Text;
                buttons[index].Name = "Photoshop" + (index + 1).ToString();
                buttons[index].BackColor = Color.Blue;
                r010.Checked = true;
            }

            if (menuItem.Name == "Jpeg")
            {
                buttons[index].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\jpg.png");
                buttons[index].BackgroundImageLayout = ImageLayout.Stretch;
                labels[index].Text = "Jpeg" + indexOfdata("Jpeg","jpg").ToString() + ".jpg";
                textbox[index].Text = labels[index].Text;
                buttons[index].Name = "Jpeg" + (index + 1).ToString();
                buttons[index].BackColor = Color.Blue;
                r001.Checked = true;
            }

            if (menuItem.Name == "Folder")
            {
                buttons[index].BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\folder.png");
                buttons[index].BackgroundImageLayout = ImageLayout.Stretch;
                labels[index].Text = "Folder" + indexOfdata("Folder","").ToString();
                textbox[index].Text = labels[index].Text;
                buttons[index].Name = "Folder" + (index + 1).ToString();
                buttons[index].BackColor = Color.Blue;
                r110.Checked = true;
            }
        }

        private int checking_btn_last()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].Visible == false)
                    return i;
            }
            return -1;
        }

        public string[,] dataset()
        {
            string[] lines = File.ReadAllLines(path);
            string[] liner = new string[lines.Length];

            string[,] matrix = new string[liner.Length, 8];
            int iter = 0;

            foreach (string line in lines)
            {
                string[] line_data = line.Split('\t');
                for (int i = 0; i < 8; i++)
                {
                    matrix[iter, i] = line_data[i];
                }
                iter++;
            }
            return matrix;
        }
        public string name_files(string name, string format, string adres)
        {
            files = dataset();
            string result = name+"."+format;

            for (int i = 0; i < files.GetLength(0); i++)
            {
                if (name.Length >= 12)
                {
                    if (files[i, 1] == name && files[i, 2] == format && files[i, 7] == adres)
                    {
                        int index = indexOfdata(name.Substring(0, 12), format);
                        result = name.Substring(0, 9) + "...(" + index+ ")." + format;
                    }

                    else
                        result = name.Substring(0, 9) + "...";
                }
            }
            return result;
        }
        public int indexOfdata(string name,string kengaytma)
        {
            int count = asosiy_adres.Count(f => f == '\\');
            List<string> nomlar = new List<string>();
            string [,]matrix = dataset();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int son=matrix[i,7].Count(f => f == '\\');
                if (matrix[i, 1].StartsWith(name) && matrix[i,2]==kengaytma && son==count)
                    nomlar.Add(matrix[i, 1]);
            }
            nomlar.Sort();

            string[] nom = nomlar.ToArray();

            for (int i = 1; i <= nomlar.Count; i++)
            {
                string x = name + i.ToString();

                if (!nomlar.Contains(x))
                {
                    return i;
                }
            }
            return nom.Length + 1;
        }
        
        private void panel1_Click(object sender, EventArgs e)
        {
            string []sx=new string[7];
            files = dataset();

            panel1.BackgroundImage = Image.FromFile(@"C:\\Users\\Azure AI\\Desktop\Foziljon\\Dasturlash asoslari\\Dasturlar\\Tizimli\\Last_project\\trash.png");
            for (int i = 0; i < 30; i++)
            {
                if (buttons[i].BackColor == Color.Blue)
                {
                    string fnom = labels[i].Text.Split('.')[0];
                    string fkeng = labels[i].Text.Split('.')[1];
                    buttons[i].Name = "";
                    buttons[i].BackColor = Color.Transparent;
                    buttons[i].BackgroundImage = null;
                    labels[i].Text = "";
                    textbox[i].Visible = false;
                    buttons[i].Visible = false;

                    for (int j = 0; j < files.GetLength(0); j++)
                    {
                        if (files[j, 1] == fnom && files[j, 2] == fkeng)
                        {
                            files[i, 0] = "";
                            files[i, 1] = "";
                            files[i, 2] = "";
                            files[i, 3] = "";
                            files[i, 4] = "";
                            files[i, 5] = "";
                            files[i, 6] = "";
                            files[i, 7] = "";
                        }
                    }
                    File.Delete(path);

                    for (int j = 0; j < files.GetLength(0); j++)
                    {
                        if (files[j, 0] != "")
                            File.AppendAllText(path, files[j, 0] + "\t" + files[j, 1] + "\t" + files[j, 2] + "\t" + files[j, 3] + "\t" + files[j, 4] + "\t" + files[j, 5] + "\t" + files[j, 6] + "\t" + files[j, 7] + "\n");
                    }

                    files = dataset();
                    datagrid.Rows.Clear();
                    datagrid.RowCount=files.GetLength(0);

                    for(int j=0;j<files.GetLength(0);j++)
                    {
                        datagrid.Rows[j].Cells[0].Value = files[j, 1];
                        datagrid.Rows[j].Cells[1].Value = files[j, 2];
                        datagrid.Rows[j].Cells[2].Value = files[j, 3];
                        datagrid.Rows[j].Cells[3].Value = files[j, 4];
                        datagrid.Rows[j].Cells[4].Value = files[j, 5];
                        datagrid.Rows[j].Cells[5].Value = files[j, 6];
                        datagrid.Rows[j].Cells[6].Value = files[j, 7];
                    }
                        break;
                }
            }
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            files = dataset();
            datagrid.Rows.Clear();
            datagrid.RowCount = files.GetLength(0);

            for (int j = 0; j < files.GetLength(0); j++)
            {
                datagrid.Rows[j].Cells[0].Value = files[j, 1];
                datagrid.Rows[j].Cells[1].Value = files[j, 2];
                datagrid.Rows[j].Cells[2].Value = files[j, 3];
                datagrid.Rows[j].Cells[3].Value = files[j, 4];
                datagrid.Rows[j].Cells[4].Value = files[j, 5];
                datagrid.Rows[j].Cells[5].Value = files[j, 6];
                datagrid.Rows[j].Cells[6].Value = files[j, 7];
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
                File.Delete(path);

            File.AppendAllText(path, "");

            files = dataset();
            datagrid.Rows.Clear();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            //if (panel6.BackgroundImage == Image.FromFile(@"C:\Users\Azure AI\Desktop\Foziljon\Dasturlash asoslari\Dasturlar\Tizimli\Last_project\list.png"))
            //    MessageBox.Show("asdasd");
            //  if (panel6.BackgroundImage == Image.FromFile(@"C:\Users\Azure AI\Desktop\Foziljon\Dasturlash asoslari\Dasturlar\Tizimli\Last_project\icon.png"))
            //  panel6.BackgroundImage = Image.FromFile(@"C:\Users\Azure AI\Desktop\Foziljon\Dasturlash asoslari\Dasturlar\Tizimli\Last_project\list.png");
        }

        private void r000_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
