using Alturos.Yolo;
using Alturos.Yolo.Model;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectDetectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ImageFileName = string.Empty;
        Image<Bgr, byte> ImgInput = null;

        private void rasmniYuklashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ImageFileName = dlg.FileName;
                    pictureBox1.Image = Image.FromFile(ImageFileName);
                }
            }
        }

        private void narsalarniAniqlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var configurationDetector = new ConfigurationDetector();
            var config = configurationDetector.Detect();
            using (var yoloWrapper = new YoloWrapper(config))
            {
                var items = yoloWrapper.Detect(ImageToByte(pictureBox1.Image));
                if (items.Count() > 0)
                {
                    foreach (YoloItem item in items)
                    {
                        Bitmap bmp = new Bitmap(pictureBox1.Image);
                        Rectangle rectangle = new Rectangle(item.X, item.Y, item.Width, item.Height);
                        ImgInput = new Image<Bgr, byte>(bmp);
                        ImgInput.Draw(rectangle, new Bgr(0, 0, 255), 2);
                        ImgInput.Draw($"{item.Type} ({string.Format("{0:0.0}", item.Confidence)})", 
                            new Point(item.X - 2, item.Y - 2), 
                            Emgu.CV.CvEnum.FontFace.HersheyDuplex, 0.5, new Bgr(Color.DarkBlue));
                        
                        pictureBox1.Image = ImgInput.Bitmap;
                    }
                }
            }
        }

        private byte[] ImageToByte(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }
    }
}
