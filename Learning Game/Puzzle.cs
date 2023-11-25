using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Game
{
    public partial class frm_puzzle : Form
    {

//njkl

        List<PictureBox> picboxlist = new List<PictureBox>();
        List<Bitmap> images = new List<Bitmap>();
        List<string> locations = new List<string>();
        List<string> cur_locations = new List<string>();
        string win_pos;
        string cur_pos;
        Bitmap Mainbitmap;
        public frm_puzzle()
        {
            InitializeComponent();
        }
        private void OpenFIle(object sender, EventArgs e)
        {
            if (picboxlist != null)
            {
                foreach (PictureBox pics in picboxlist.ToList())
                {
                    this.Controls.Remove(pics);
                }
                picboxlist.Clear();
                images.Clear();
                locations.Clear();
                cur_locations.Clear();
                win_pos = string.Empty;
                cur_pos = string.Empty;
                status.Text = string.Empty;
            }
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Only Image Files | *.jpg; *.jpeg; *.gif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Mainbitmap = new Bitmap(open.FileName);
                CreatePictureBoxes();
                AddImages();
            }
        }
        private void CreatePictureBoxes()
        {
            for (int i = 0; i < 9; i++)
            {
                PictureBox temporary_pic = new PictureBox();
                temporary_pic.Size = new Size(130, 130);
                temporary_pic.Tag = i.ToString();
                temporary_pic.Click += OnPicClick;
                picboxlist.Add(temporary_pic);
                locations.Add(temporary_pic.Tag.ToString());
            }
        }
        private void OnPicClick(object sender, EventArgs e)
        {
            
        }
        private void CropImage(Bitmap main_bitmap, int height, int width)
        {
            int x, y;
            x = 0;
            y = 0;
            for (int blocks = 0; blocks < 9; blocks++)
            {
                Bitmap cropped_image = new Bitmap(height, width);
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        cropped_image.SetPixel(i, j, main_bitmap.GetPixel((i + x), (j + y)));
                    }
                }
                images.Add(cropped_image);
                x += 130;
                if (x == 390)
                {
                    x = 0;
                    y += 130;
                }
            }
        }
        private void AddImages()
        {
            Bitmap tempBitmap = new Bitmap(Mainbitmap, new Size(390, 390));
            CropImage(tempBitmap, 130, 130);
            for (int i = 1; i < picboxlist.Count; i++)
            {
                picboxlist[i].BackgroundImage = (Image)images[i];
            }
            InsertPictureBoxesInTheForm();
        }
        private void InsertPictureBoxesInTheForm()
        {
            
            int x = 200;
            int y = 25;
            for (int i = 0; i < picboxlist.Count; i++)
            {
                picboxlist[i].BackColor = Color.Silver;
                if (i == 3 || i == 6)
                {
                    y += 130;
                    x = 200;
                }
                picboxlist[i].BorderStyle = BorderStyle.FixedSingle;
                picboxlist[i].Location = new Point(x, y);
                this.Controls.Add(picboxlist[i]);
                x += 130;
                win_pos += locations[i];
            }
        }
        private void CheckGame() 
        {
            
        }
        

    }
}
