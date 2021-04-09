namespace XML
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
            this.buttonCreateXML = new System.Windows.Forms.Button();
            this.textBoxData1 = new System.Windows.Forms.TextBox();
            this.textBoxData2 = new System.Windows.Forms.TextBox();
            this.textBoxData3 = new System.Windows.Forms.TextBox();
            this.textBoxData4 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCreateXML
            // 
            this.buttonCreateXML.Location = new System.Drawing.Point(65, 157);
            this.buttonCreateXML.Name = "buttonCreateXML";
            this.buttonCreateXML.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateXML.TabIndex = 0;
            this.buttonCreateXML.Text = "Save";
            this.buttonCreateXML.UseVisualStyleBackColor = true;
            this.buttonCreateXML.Click += new System.EventHandler(this.buttonCreateXML_Click);
            // 
            // textBoxData1
            // 
            this.textBoxData1.Location = new System.Drawing.Point(51, 12);
            this.textBoxData1.Name = "textBoxData1";
            this.textBoxData1.Size = new System.Drawing.Size(100, 20);
            this.textBoxData1.TabIndex = 1;
            // 
            // textBoxData2
            // 
            this.textBoxData2.Location = new System.Drawing.Point(51, 38);
            this.textBoxData2.Name = "textBoxData2";
            this.textBoxData2.Size = new System.Drawing.Size(100, 20);
            this.textBoxData2.TabIndex = 2;
            // 
            // textBoxData3
            // 
            this.textBoxData3.Location = new System.Drawing.Point(51, 64);
            this.textBoxData3.Name = "textBoxData3";
            this.textBoxData3.Size = new System.Drawing.Size(100, 20);
            this.textBoxData3.TabIndex = 3;
            // 
            // textBoxData4
            // 
            this.textBoxData4.Location = new System.Drawing.Point(51, 90);
            this.textBoxData4.Name = "textBoxData4";
            this.textBoxData4.Size = new System.Drawing.Size(100, 20);
            this.textBoxData4.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(60, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 249);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxData4);
            this.Controls.Add(this.textBoxData3);
            this.Controls.Add(this.textBoxData2);
            this.Controls.Add(this.textBoxData1);
            this.Controls.Add(this.buttonCreateXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateXML;
        private System.Windows.Forms.TextBox textBoxData1;
        private System.Windows.Forms.TextBox textBoxData2;
        private System.Windows.Forms.TextBox textBoxData3;
        private System.Windows.Forms.TextBox textBoxData4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

