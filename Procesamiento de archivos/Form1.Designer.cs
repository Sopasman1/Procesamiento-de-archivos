namespace Procesamiento_de_archivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabcontrol = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewCsv = new DataGridView();
            btnLoadcsv = new Button();
            btnBrowsecsv = new Button();
            tabPage2 = new TabPage();
            dataGridViewXml = new DataGridView();
            btnLoadxml = new Button();
            btnBrowsexml = new Button();
            tabPage3 = new TabPage();
            dataGridViewJson = new DataGridView();
            btnLoadjson = new Button();
            btnBrowsejson = new Button();
            tabcontrol.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCsv).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewXml).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJson).BeginInit();
            SuspendLayout();
            // 
            // tabcontrol
            // 
            tabcontrol.Controls.Add(tabPage1);
            tabcontrol.Controls.Add(tabPage2);
            tabcontrol.Controls.Add(tabPage3);
            tabcontrol.Location = new Point(12, 12);
            tabcontrol.Name = "tabcontrol";
            tabcontrol.SelectedIndex = 0;
            tabcontrol.Size = new Size(776, 438);
            tabcontrol.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewCsv);
            tabPage1.Controls.Add(btnLoadcsv);
            tabPage1.Controls.Add(btnBrowsecsv);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 410);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CSV";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCsv
            // 
            dataGridViewCsv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCsv.Location = new Point(6, 44);
            dataGridViewCsv.Name = "dataGridViewCsv";
            dataGridViewCsv.Size = new Size(756, 358);
            dataGridViewCsv.TabIndex = 2;
            // 
            // btnLoadcsv
            // 
            btnLoadcsv.Location = new Point(96, 15);
            btnLoadcsv.Name = "btnLoadcsv";
            btnLoadcsv.Size = new Size(75, 23);
            btnLoadcsv.TabIndex = 1;
            btnLoadcsv.Text = "Load";
            btnLoadcsv.UseVisualStyleBackColor = true;
            btnLoadcsv.Click += btnLoadcsv_Click;
            // 
            // btnBrowsecsv
            // 
            btnBrowsecsv.Location = new Point(6, 15);
            btnBrowsecsv.Name = "btnBrowsecsv";
            btnBrowsecsv.Size = new Size(75, 23);
            btnBrowsecsv.TabIndex = 0;
            btnBrowsecsv.Text = "Browse";
            btnBrowsecsv.UseVisualStyleBackColor = true;
            btnBrowsecsv.Click += btnBrowsecsv_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewXml);
            tabPage2.Controls.Add(btnLoadxml);
            tabPage2.Controls.Add(btnBrowsexml);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 410);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "XML";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewXml
            // 
            dataGridViewXml.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewXml.Location = new Point(6, 35);
            dataGridViewXml.Name = "dataGridViewXml";
            dataGridViewXml.Size = new Size(756, 367);
            dataGridViewXml.TabIndex = 2;
            // 
            // btnLoadxml
            // 
            btnLoadxml.Location = new Point(87, 6);
            btnLoadxml.Name = "btnLoadxml";
            btnLoadxml.Size = new Size(75, 23);
            btnLoadxml.TabIndex = 1;
            btnLoadxml.Text = "Load";
            btnLoadxml.UseVisualStyleBackColor = true;
            btnLoadxml.Click += btnLoadxml_Click;
            // 
            // btnBrowsexml
            // 
            btnBrowsexml.Location = new Point(6, 6);
            btnBrowsexml.Name = "btnBrowsexml";
            btnBrowsexml.Size = new Size(75, 23);
            btnBrowsexml.TabIndex = 0;
            btnBrowsexml.Text = "Browse";
            btnBrowsexml.UseVisualStyleBackColor = true;
            btnBrowsexml.Click += btnBrowsexml_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridViewJson);
            tabPage3.Controls.Add(btnLoadjson);
            tabPage3.Controls.Add(btnBrowsejson);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 410);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "JSON";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewJson
            // 
            dataGridViewJson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJson.Location = new Point(6, 35);
            dataGridViewJson.Name = "dataGridViewJson";
            dataGridViewJson.Size = new Size(756, 369);
            dataGridViewJson.TabIndex = 2;
            // 
            // btnLoadjson
            // 
            btnLoadjson.Location = new Point(87, 6);
            btnLoadjson.Name = "btnLoadjson";
            btnLoadjson.Size = new Size(75, 23);
            btnLoadjson.TabIndex = 1;
            btnLoadjson.Text = "Load";
            btnLoadjson.UseVisualStyleBackColor = true;
            btnLoadjson.Click += btnLoadjson_Click;
            // 
            // btnBrowsejson
            // 
            btnBrowsejson.Location = new Point(6, 6);
            btnBrowsejson.Name = "btnBrowsejson";
            btnBrowsejson.Size = new Size(75, 23);
            btnBrowsejson.TabIndex = 0;
            btnBrowsejson.Text = "Browse";
            btnBrowsejson.UseVisualStyleBackColor = true;
            btnBrowsejson.Click += btnBrowsejson_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabcontrol);
            Name = "Form1";
            Text = "Form1";
            tabcontrol.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCsv).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewXml).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewJson).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcontrol;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridViewCsv;
        private Button btnLoadcsv;
        private Button btnBrowsecsv;
        private DataGridView dataGridViewXml;
        private Button btnLoadxml;
        private Button btnBrowsexml;
        private DataGridView dataGridViewJson;
        private Button btnLoadjson;
        private Button btnBrowsejson;
    }
}
