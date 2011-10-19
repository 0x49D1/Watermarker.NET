namespace Watermarker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLocations = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.lbStyle = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPreview = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnLoadTemplate = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.chbSaveOnClose = new System.Windows.Forms.CheckBox();
            this.lnkSupport = new System.Windows.Forms.LinkLabel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.tbHeight = new System.Windows.Forms.TrackBar();
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.lblImageSize = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cmbFontFamily = new Watermarker.ComboBox(this.components);
            this.cmbFormat = new Watermarker.ComboBox(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocations
            // 
            this.btnLocations.Location = new System.Drawing.Point(83, 205);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(212, 40);
            this.btnLocations.TabIndex = 0;
            this.btnLocations.Text = "Add pictures to watermark  && choose save location";
            this.toolTip1.SetToolTip(this.btnLocations, "Add pictures to watermark  && choose save location");
            this.btnLocations.UseVisualStyleBackColor = true;
            this.btnLocations.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif|TIFF|*.tiff";
            this.openFileDialog1.Multiselect = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose folder where to save watermarked copies";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif|TIFF|*.tiff";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(83, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Enter watermark text here...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Font Family";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Font Color";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(83, 90);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(28, 23);
            this.btnColor.TabIndex = 7;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbStyle
            // 
            this.lbStyle.FormattingEnabled = true;
            this.lbStyle.Location = new System.Drawing.Point(214, 92);
            this.lbStyle.Name = "lbStyle";
            this.lbStyle.Size = new System.Drawing.Size(102, 56);
            this.lbStyle.TabIndex = 8;
            this.lbStyle.SelectedIndexChanged += new System.EventHandler(this.lbStyle_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Style";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTest.Location = new System.Drawing.Point(0, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 10;
            this.lblTest.TextChanged += new System.EventHandler(this.lblTest_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTest);
            this.panel1.Location = new System.Drawing.Point(83, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 46);
            this.panel1.TabIndex = 12;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(12, 153);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(45, 13);
            this.lblPreview.TabIndex = 13;
            this.lblPreview.Text = "Preview";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Size";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(83, 120);
            this.txtFontSize.MaxLength = 3;
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(48, 21);
            this.txtFontSize.TabIndex = 15;
            this.txtFontSize.Text = "12";
            this.txtFontSize.TextChanged += new System.EventHandler(this.txtFontSize_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlblInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(696, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlblInfo
            // 
            this.tlblInfo.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tlblInfo.Name = "tlblInfo";
            this.tlblInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.AutoSize = true;
            this.btnSaveSettings.Image = global::Watermarker.Properties.Resources.disk;
            this.btnSaveSettings.Location = new System.Drawing.Point(318, 199);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(24, 23);
            this.btnSaveSettings.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnSaveSettings, "Save settings");
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnLoadTemplate
            // 
            this.btnLoadTemplate.AutoSize = true;
            this.btnLoadTemplate.Image = global::Watermarker.Properties.Resources.table_go;
            this.btnLoadTemplate.Location = new System.Drawing.Point(318, 245);
            this.btnLoadTemplate.Name = "btnLoadTemplate";
            this.btnLoadTemplate.Size = new System.Drawing.Size(24, 23);
            this.btnLoadTemplate.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnLoadTemplate, "Load settings template");
            this.btnLoadTemplate.UseVisualStyleBackColor = true;
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.AutoSize = true;
            this.btnSaveTemplate.Image = global::Watermarker.Properties.Resources.table_save;
            this.btnSaveTemplate.Location = new System.Drawing.Point(318, 222);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(24, 23);
            this.btnSaveTemplate.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnSaveTemplate, "Save settings as template");
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            // 
            // chbSaveOnClose
            // 
            this.chbSaveOnClose.AutoSize = true;
            this.chbSaveOnClose.Location = new System.Drawing.Point(318, 185);
            this.chbSaveOnClose.Name = "chbSaveOnClose";
            this.chbSaveOnClose.Size = new System.Drawing.Size(15, 14);
            this.chbSaveOnClose.TabIndex = 20;
            this.toolTip1.SetToolTip(this.chbSaveOnClose, "Save settings on program close (if this checkbox is checked the settings will be " +
        "re-saved every time the program is closed)");
            this.chbSaveOnClose.UseVisualStyleBackColor = true;
            // 
            // lnkSupport
            // 
            this.lnkSupport.AutoSize = true;
            this.lnkSupport.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSupport.Location = new System.Drawing.Point(646, 327);
            this.lnkSupport.Name = "lnkSupport";
            this.lnkSupport.Size = new System.Drawing.Size(45, 13);
            this.lnkSupport.TabIndex = 21;
            this.lnkSupport.TabStop = true;
            this.lnkSupport.Text = "Support";
            this.toolTip1.SetToolTip(this.lnkSupport, "Go to project website to suggest a feature or report a bug");
            this.lnkSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSupport_LinkClicked);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(322, 90);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(57, 58);
            this.btnPreview.TabIndex = 23;
            this.btnPreview.Text = "Check preview";
            this.toolTip1.SetToolTip(this.btnPreview, "Click on this button to choose picture and see the small preview of watermark on " +
        "it. To apply new changes to watermark-click on this button again");
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // tbWidth
            // 
            this.tbWidth.Enabled = false;
            this.tbWidth.Location = new System.Drawing.Point(385, 267);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(246, 45);
            this.tbWidth.TabIndex = 27;
            this.toolTip1.SetToolTip(this.tbWidth, "Adjust sliders to change coordinates");
            this.tbWidth.Scroll += new System.EventHandler(this.tbWidth_Scroll);
            // 
            // tbHeight
            // 
            this.tbHeight.Enabled = false;
            this.tbHeight.Location = new System.Drawing.Point(639, 12);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbHeight.Size = new System.Drawing.Size(45, 251);
            this.tbHeight.TabIndex = 28;
            this.toolTip1.SetToolTip(this.tbHeight, "Adjust sliders to change coordinates");
            this.tbHeight.Scroll += new System.EventHandler(this.tbHeight_Scroll);
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Location = new System.Drawing.Point(450, -1);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(119, 13);
            this.lblCoordinates.TabIndex = 29;
            this.lblCoordinates.Text = "Watermark coordinates";
            this.toolTip1.SetToolTip(this.lblCoordinates, "Adjust sliders to change coordinates");
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(385, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(246, 251);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 22;
            this.picPreview.TabStop = false;
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.Location = new System.Drawing.Point(454, 299);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(83, 13);
            this.lblImageSize.TabIndex = 25;
            this.lblImageSize.Text = "Image real size:";
            this.lblImageSize.Visible = false;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(560, 299);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(13, 13);
            this.lblSize.TabIndex = 26;
            this.lblSize.Text = "x";
            this.lblSize.Visible = false;
            // 
            // cmbFontFamily
            // 
            this.cmbFontFamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFontFamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFontFamily.FormattingEnabled = true;
            this.cmbFontFamily.Location = new System.Drawing.Point(83, 65);
            this.cmbFontFamily.Name = "cmbFontFamily";
            this.cmbFontFamily.Size = new System.Drawing.Size(233, 21);
            this.cmbFontFamily.TabIndex = 4;
            this.cmbFontFamily.SelectedIndexChanged += new System.EventHandler(this.cmbFontFamily_SelectedIndexChanged);
            // 
            // cmbFormat
            // 
            this.cmbFormat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFormat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(83, 38);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(233, 21);
            this.cmbFormat.TabIndex = 2;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(83, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(212, 40);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 299);
            this.lblLocation.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 13);
            this.lblLocation.TabIndex = 31;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 343);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblImageSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblCoordinates);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.lnkSupport);
            this.Controls.Add(this.chbSaveOnClose);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnLoadTemplate);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtFontSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbStyle);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFontFamily);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLocations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private Watermarker.ComboBox cmbFormat;
        private System.Windows.Forms.Label label1;
        private Watermarker.ComboBox cmbFontFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ListBox lbStyle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlblInfo;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLoadTemplate;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.CheckBox chbSaveOnClose;
        private System.Windows.Forms.LinkLabel lnkSupport;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.TrackBar tbHeight;
        private System.Windows.Forms.Label lblCoordinates;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLocation;
    }
}


