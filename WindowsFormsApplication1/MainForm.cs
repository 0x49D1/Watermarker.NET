using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Watermarker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += (e, s) => Init();
        }

        List<ImageFormat> imageFormat = new List<ImageFormat>();
        List<string> fontFamily = new List<string>();
        List<FontStyle> fontStyle = new List<FontStyle>();
        private bool allow;
        private float coordinateX = 10;
        private float coordinateY = 10;

        private void Init()
        {
            string tempAssemblyName = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = string.Format("{3} ver. {0}.{1}.{2}", tempAssemblyName.Split('.')[0],
                tempAssemblyName.Split('.')[1],
                tempAssemblyName.Split('.')[2],
                Application.ProductName.Trim());

            // image format
            AddImageFormats();

            cmbFormat.DataSource = imageFormat;

            cmbFormat.SelectedIndex = Properties.Settings.Default.ImageFormatIndex;

            // font family
            foreach (FontFamily systemFont in FontFamily.Families)
            {
                fontFamily.Add(systemFont.Name);
            }

            cmbFontFamily.DataSource = fontFamily;
            cmbFontFamily.SelectedItem = Properties.Settings.Default.FontFamily;

            AddFontStyles();

            lbStyle.DataSource = fontStyle;

            lbStyle.SelectedIndex = Properties.Settings.Default.FontStyleIndex;

            colorDialog1.Color = Properties.Settings.Default.FontColor;
            btnColor.BackColor = colorDialog1.Color;

            // font sizes
            txtFontSize.Text = Properties.Settings.Default.FontSize.ToString();

            allow = true;

            chbSaveOnClose.Checked = Properties.Settings.Default.SaveOnCloseCheck;

            // check
            Check();
        }

        private void AddFontStyles()
        {
            // font styles
            fontStyle.Add(FontStyle.Regular);
            fontStyle.Add(FontStyle.Bold);
            fontStyle.Add(FontStyle.Italic);
            fontStyle.Add(FontStyle.Strikeout);
            fontStyle.Add(FontStyle.Underline);
        }

        private void AddImageFormats()
        {
            imageFormat.Add(ImageFormat.Jpeg);
            imageFormat.Add(ImageFormat.Bmp);
            imageFormat.Add(ImageFormat.Png);
            imageFormat.Add(ImageFormat.Gif);
            imageFormat.Add(ImageFormat.Tiff);
        }


        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Properties.Settings.Default.Reload();
        }

        private void SaveSettings()
        {
            try
            {
                Properties.Settings.Default.FontColor = colorDialog1.Color;
                Properties.Settings.Default.FontFamily = cmbFontFamily.SelectedItem.ToString();
                try
                {
                    Properties.Settings.Default.FontSize = int.Parse(txtFontSize.Text);
                }
                catch (Exception ex)
                { }
                Properties.Settings.Default.FontStyleIndex = lbStyle.SelectedIndex;
                Properties.Settings.Default.ImageFormatIndex = cmbFormat.SelectedIndex;
                Properties.Settings.Default.SaveOnCloseCheck = chbSaveOnClose.Checked;

                Properties.Settings.Default.Save();

                tlblInfo.Text = "Settings saved successfully!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tlblInfo.Text = string.Empty;
            }
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    openFileDialog1.FileName = string.Empty;
                    openFileDialog1.ShowDialog();
                    if (openFileDialog1.FileNames.Length == 0 || (openFileDialog1.FileNames[0] == string.Empty))
                        return;
                    btnSave.Text = string.Format("Save Changes to {0} images.", openFileDialog1.FileNames.Length);
                }

                folderBrowserDialog1.ShowDialog();
                if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
                    return;
                lblLocation.Text = string.Format("Changes will be saved to {0}", folderBrowserDialog1.SelectedPath);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                tlblInfo.Text = string.Empty;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Bitmap> bmList = new List<Bitmap>();
            foreach (var fileName in openFileDialog1.FileNames)
            {
                Bitmap bm = new Bitmap(fileName);
                Graphics g = Graphics.FromImage(bm);
                System.Drawing.Font f = new Font((string)cmbFontFamily.SelectedValue, Int32.Parse(txtFontSize.Text), (FontStyle)lbStyle.SelectedItem);
                SolidBrush b = new SolidBrush(btnColor.BackColor);
                g.DrawString(textBox1.Text.Trim(), f, b, coordinateX, coordinateY);

                // todo Optimize this
                var files = fileName.Split('\\');
                var tfiles = files[files.Length - 1].Split('.');
                string fi = string.Empty;
                for (int i = 0; i < tfiles.Length - 1; i++)
                {
                    fi += tfiles[i];
                }
                bm.Tag = fi;
                bmList.Add(bm);
            }

            foreach (Bitmap bitmap in bmList)
            {
                bitmap.Save(string.Format("{0}\\{1}.{2}", folderBrowserDialog1.SelectedPath, bitmap.Tag.ToString(), cmbFormat.SelectedValue.ToString().ToLower()), (ImageFormat)cmbFormat.SelectedValue);
            }
            tlblInfo.Text = string.Format("Success! Saved to: {0}", folderBrowserDialog1.SelectedPath);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            // todo remove this dublicate
            if (string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                openFileDialog1.FileName = string.Empty;
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileNames.Length == 0 || (openFileDialog1.FileNames[0] == string.Empty))
                    return;
            }
            var fileName = openFileDialog1.FileNames[0];
            Bitmap bm = new Bitmap(fileName);
            Graphics g = Graphics.FromImage(bm);
            System.Drawing.Font f = new Font((string)cmbFontFamily.SelectedValue, Int32.Parse(txtFontSize.Text), (FontStyle)lbStyle.SelectedItem);
            SolidBrush b = new SolidBrush(btnColor.BackColor);
            g.DrawString(textBox1.Text.Trim(), f, b, coordinateX, coordinateY);
            lblImageSize.Visible = lblSize.Visible = true;
            lblSize.Text = bm.Size.Width + "x" + bm.Size.Height;
            tbHeight.Enabled = tbWidth.Enabled = true;
            tbHeight.Maximum = bm.Size.Height;
            tbWidth.Maximum = bm.Size.Width;
            tbWidth.Value = (int)coordinateX;
            tbHeight.Value = tbHeight.Maximum - (int)coordinateY;

            picPreview.Image = bm;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ReplaceWatermarkText();
        }

        private void ReplaceWatermarkText()
        {
            textBox1.ForeColor = Color.Black;
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            ReplaceWatermarkText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColor.BackColor = colorDialog1.Color;
            Check();
        }


        private void Check()
        {
            if (allow)
            {
                System.Drawing.Font f = new Font((string)cmbFontFamily.SelectedValue, Int32.Parse(txtFontSize.Text),
                                                 (FontStyle)lbStyle.SelectedItem);
                lblTest.Text = textBox1.Text;
                lblTest.Font = f;
                lblTest.ForeColor = btnColor.BackColor;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void cmbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void cmbFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private string latest;

        private void txtFontSize_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtFontSize.Text, "^[0-9]{1,3}$"))
            {
                txtFontSize.Text = latest;
            }
            else
            {
                Check();
                latest = txtFontSize.Text;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void lblTest_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((Label)sender, ((Label)sender).Text);
        }

        private void lnkSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.AppURL);
        }

        private void tbWidth_Scroll(object sender, EventArgs e)
        {
            coordinateX = tbWidth.Value;
            btnPreview_Click(null, null);
        }

        private void tbHeight_Scroll(object sender, EventArgs e)
        {
            coordinateY = tbHeight.Maximum - tbHeight.Value;
            btnPreview_Click(null, null);
        }

      
    }
}