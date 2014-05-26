namespace WindowsFormsApplication7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Encode_btn = new System.Windows.Forms.Button();
            this.Select_file_to_encode_decode = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Decode_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Encode_btn
            // 
            this.Encode_btn.Location = new System.Drawing.Point(51, 266);
            this.Encode_btn.Name = "Encode_btn";
            this.Encode_btn.Size = new System.Drawing.Size(106, 29);
            this.Encode_btn.TabIndex = 0;
            this.Encode_btn.Text = "Encode";
            this.Encode_btn.UseVisualStyleBackColor = true;
            this.Encode_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Select_file_to_encode_decode
            // 
            this.Select_file_to_encode_decode.Location = new System.Drawing.Point(67, 12);
            this.Select_file_to_encode_decode.Name = "Select_file_to_encode_decode";
            this.Select_file_to_encode_decode.Size = new System.Drawing.Size(103, 34);
            this.Select_file_to_encode_decode.TabIndex = 2;
            this.Select_file_to_encode_decode.Text = "Select Files To Encode";
            this.Select_file_to_encode_decode.UseVisualStyleBackColor = true;
            this.Select_file_to_encode_decode.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(51, 52);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(145, 141);
            this.treeView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Decode_btn
            // 
            this.Decode_btn.Location = new System.Drawing.Point(329, 20);
            this.Decode_btn.Name = "Decode_btn";
            this.Decode_btn.Size = new System.Drawing.Size(114, 26);
            this.Decode_btn.TabIndex = 6;
            this.Decode_btn.Text = "Decode";
            this.Decode_btn.UseVisualStyleBackColor = true;
            this.Decode_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Tag = "";
            this.label1.Text = "File Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(327, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output Folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 296);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Decode_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Select_file_to_encode_decode);
            this.Controls.Add(this.Encode_btn);
            this.Name = "Form1";
            this.Text = "Gif Encoder And Decoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encode_btn;
        private System.Windows.Forms.Button Select_file_to_encode_decode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Decode_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
    }
}

