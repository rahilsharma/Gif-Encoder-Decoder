//do for repeat no repeats and other things........give good gui.......
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NGif;
using System.Drawing.Imaging;
using System.Collections;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.VisualBasic;
namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        ArrayList imageFilePaths = new ArrayList();
        
        public  string outputfilepath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Visible = false;
            initialize_open_file_dialog();
        }

       public void button1_Click(object sender, EventArgs e)
        {
            /* create Gif */
            //you should replace filepath
            //find the root folder from here
            //var rs = imageFilePaths[0].ToString().LastIndexOf("\\");
           //find the root folder using savedialog
            //Stream myStream;
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //saveFileDialog1.Filter = "Images (*.gif)|*.gif";
            //saveFileDialog1.FilterIndex = 2;
            //saveFileDialog1.RestoreDirectory = true;

            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    if ((myStream = saveFileDialog1.OpenFile()) != null)
            //    {
            //        outputfilepath=saveFileDialog1.FileName;
            //        // Code to write the stream goes here.
                  
            //    }
            //}
            var rs = imageFilePaths[0].ToString().Substring(10).LastIndexOf("\\");
            var outputfilepath1 = imageFilePaths[0].ToString().Substring(10).Substring(0, rs);

            textBox1.Text = outputfilepath;
            var file_name = textBox2.Text;
            //|| file_name.ToLower().IndexOf("gif"))>0
           if (file_name.Equals("") ) 
           {
               MessageBox.Show("enter a file name");
           }
           outputfilepath = outputfilepath1 +"\\" + file_name + ".gif";
           AnimatedGifEncoder es = new AnimatedGifEncoder();

            es.Start(outputfilepath);
            es.SetDelay(500);
            //-1:no repeat,0:always repeat
            es.SetRepeat(0);
            for (int i = 0, count = imageFilePaths.Count; i < count; i++)
            {
                es.AddFrame(Image.FromFile(imageFilePaths[i].ToString().Substring(10)));
            }
            es.Finish();
          
            }

      
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
    if (dr == System.Windows.Forms.DialogResult.OK)
    {
        
    
        // Read the files 
        foreach (String file in openFileDialog1.FileNames) 
        {
               TreeNode tree=new TreeNode(file);
               treeView1.Nodes.Add(tree);

               imageFilePaths.Add(tree);

             
        }
        treeView1.Visible = true;
    }
        }


        private void initialize_open_file_dialog()
        {
            this.openFileDialog1.Filter =  "Images (*.PNG;*.BMP;*.JPG;*.jpeg)|*.PNG;*.BMP;*.JPG;*.jpeg|" +
        "All files (*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
    this.openFileDialog1.Title = "Select Images u want to encode";

        }

        private void button2_Click(object sender, EventArgs e)
        {//read the path.....................................
           
            this.openFileDialog1.Filter = "Images (*.gif)|*.GIF|" +
        "All files (*.*)|*.*";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Select the Image u want to decode";
            string outputPath = "c:\\rahil";

            GifDecoder gifDecoder = new GifDecoder();
            DialogResult dr = this.openFileDialog1.ShowDialog();
            gifDecoder.Read(openFileDialog1.FileName);
            for (int i = 0, count = gifDecoder.GetFrameCount(); i < count; i++)
            {
                Image frame = gifDecoder.GetFrame(i); // frame i
                frame.Save(outputPath + i+ ".png", ImageFormat.Png);
            }
        }

        
    }
}
