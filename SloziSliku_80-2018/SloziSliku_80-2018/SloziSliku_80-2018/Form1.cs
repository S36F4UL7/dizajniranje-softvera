using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SloziSliku_80_2018
{
    public partial class Form1 : Form
    {
        public int paddingLeft, paddingRight, paddingUp, paddingDown;
        public int lineWidth;
        public static int col = 3;
        public static int row = 3;
        public List<List<int>> imgMatrix;
        public int x = 0, y = 0;
        public int moveCount = 0;
        Color lineColor;
        public int borderLeft, borderRight, borderUp, borderDown;
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        public Image gameImg = null;
        public bool gameOver = false;

        public Form1()
        {
            InitializeComponent();

            ResizeRedraw = true;

            imgMatrix = new List<List<int>>();
            int value = 0;

            for (int i = 0; i < row; i++)
            {
                List<int> rows = new List<int>();
                for (int j = 0; j < col; j++)
                {
                    rows.Add(value);
                }
                imgMatrix.Add(rows);
            }

            paddingLeft = 40;
            paddingDown = 40;
            paddingUp = 40;
            paddingRight = 110;
            lineWidth = 1;
            lineColor = Color.FromArgb(255, 0, 0, 255);
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_moveCount.Text = moveCount.ToString();
        }

        private void move()
        {
            lbl_moveCount.Text = (++moveCount).ToString();
        }

        private void restartMoveCount()
        {
            moveCount = 0;
            lbl_moveCount.Text = moveCount.ToString();
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lineColor = colorDialog.Color;
            }
            this.Refresh();
        }

        private List<Point> getPoints()
        {
            List<Point> points = new List<Point>();

            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                points.Add(pictureBoxes[i].Location);
            }

            return points;
        }

        private void randomize()
        {
            Random rand = new Random();
            List<Point> points = new List<Point>();

            points = getPoints();

            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                var nextRand = rand.Next(0, points.Count);
                pictureBoxes[i].Location = points[nextRand];
                points.RemoveAt(nextRand);
            }

            pictureBoxes.LastOrDefault().Image = null;
            this.Refresh();
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            if (gameImg == null)
            {
                MessageBox.Show("Nije ucitana slika!");
            }
            else
            {
                moveCount = 0;
                lbl_moveCount.Text = (moveCount).ToString();
                randomize();
            }

        }

        private void rb_row3_CheckedChanged(object sender, EventArgs e)
        {
            row = 3;

            if (gameImg != null)
            {
                restartMoveCount();
                deleteImage();
                loadImage();
            }

            this.Refresh();
        }

        private void rb_row4_CheckedChanged(object sender, EventArgs e)
        {
            row = 4;

            if (gameImg != null)
            {
                restartMoveCount();
                deleteImage();
                loadImage();
            }

            this.Refresh();
        }

        private void rb_row5_CheckedChanged(object sender, EventArgs e)
        {
            row = 5;

            if (gameImg != null)
            {
                restartMoveCount();
                deleteImage();
                loadImage();
            }

            this.Refresh();
        }

        private void rb_col3_CheckedChanged(object sender, EventArgs e)
        {
            col = 3;

            if (gameImg != null)
            {
                restartMoveCount();
                deleteImage();
                loadImage();
            }

            this.Refresh();
        }

        private void rb_col4_CheckedChanged(object sender, EventArgs e)
        {
            col = 4;

            if (gameImg != null)
            {
                restartMoveCount();
                deleteImage();
                loadImage();
            }

            this.Refresh();
        }

        private void rb_col5_CheckedChanged(object sender, EventArgs e)
        {
            col = 5;

            if (gameImg != null)
            {
                restartMoveCount();
                deleteImage();
                loadImage();
            }

            this.Refresh();
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            GameDB gameDb = new GameDB();
            StringBuilder stringBuilder = new StringBuilder();

            List<Game> games = gameDb.getGames(row, col);
            stringBuilder.AppendLine("Najbolji rezultati " + row + "x" + col + ":");
            foreach (var game in games)
                if (game != null)
                {
                    stringBuilder.AppendLine((games.IndexOf(game) + 1).ToString() + ". " + game.ToString());
                }

            MessageBox.Show(stringBuilder.ToString());
        }

        private void enterResult(string username)
        {
                string usernameDb = username;

                GameDB gameDb = new GameDB();
                gameDb.insertGame(username, col, row, moveCount, "");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            Graphics graphics = this.CreateGraphics();
            borderLeft = rect.X + paddingLeft;
            borderRight = rect.Width - paddingRight;
            borderUp = rect.Y + paddingUp;
            borderDown = rect.Height - paddingDown;

            y = (borderDown - borderUp) / row;
            borderDown = borderUp + row * y;

            x = (borderRight - borderLeft) / col;
            borderRight = borderLeft + col * x;

            int n;
            Pen pen = new Pen(lineColor, lineWidth);

            if (row >= col) 
                n = row;
            else 
                n = col;

            for (int i = 0; i <= n; i++)
            {
                e.Graphics.DrawLine(pen, borderLeft, borderUp + i * y, borderRight + lineWidth - 1, borderUp + i * y);
                e.Graphics.DrawLine(pen, borderLeft + i * x, borderUp, borderLeft + (i * x), borderDown + lineWidth - 1);
            }
        }

        private void deleteImage()
        {
            List<Control> delete = new List<Control>();
            foreach (Control control in this.Controls)
                if (control is PictureBox)
                    delete.Add(control);
            
            for (int i = 0; i < delete.Count; i++)
                this.Controls.Remove(delete[i]);

            this.pictureBoxes = new List<PictureBox>();
            this.Refresh();
        }

        public static Bitmap changeImage(Image image, int x, int y)
        {
            var destRect = new Rectangle(0, 0, x * col, y * row);
            
            var destImage = new Bitmap(x * col, y * row);
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private static Image cropImage(Image image, Rectangle rect)
        {
            Bitmap bitmapImg = new Bitmap(image);
            Bitmap bitmapCrop = bitmapImg.Clone(rect, bitmapImg.PixelFormat);
            return (Image)(bitmapCrop);
        }

        private Boolean checkFinished()
        {
            for (int i = 0; i < pictureBoxes.Count - 1; i++)
            {
                if(pictureBoxes[i].Location.Y > pictureBoxes[i+1].Location.Y 
                    || (pictureBoxes[i].Location.Y == pictureBoxes[i+1].Location.Y && pictureBoxes[i].Location.X > pictureBoxes[i+1].Location.X))
                {
                    return false;
                }
            }

            return true;
        }

        private void gameWon()
        {
            string message, title, defaultUsername;
            object customUsername;

            message = "Cestitam! Uspesno ste slozili sliku!\n ( mozete uneti username kako bi sacuvali svoj rezultat )";
            title = "Pobeda! " + row + "x" + col;
            defaultUsername = "";

            customUsername = Interaction.InputBox(message, title, defaultUsername);

            if (((string)customUsername).Trim() != "")
                enterResult(((string)customUsername).Trim());

            restartMoveCount();
            deleteImage();
            loadImage();
        }

        private void PictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            Point point = new Point(x, y);

            if (pictureBoxes.FirstOrDefault(elem => elem.Image == null) != default(PictureBox))
            {
                if (pictureBoxes.LastOrDefault().Location.X == picBox.Location.X)
                {
                    if (pictureBoxes.LastOrDefault().Location.Y == (picBox.Location.Y + point.Y) || pictureBoxes.LastOrDefault().Location.Y == (picBox.Location.Y - point.Y))
                    {
                        move();
                        Point p = picBox.Location;
                        picBox.Location = pictureBoxes.LastOrDefault().Location;
                        pictureBoxes.LastOrDefault().Location = p;
                        this.Refresh();

                        if (checkFinished())
                        {
                            gameWon();
                        }
                    }
                }
                else if (pictureBoxes.LastOrDefault().Location.Y == picBox.Location.Y)
                {
                    if (pictureBoxes.LastOrDefault().Location.X == (picBox.Location.X + point.X) || pictureBoxes.LastOrDefault().Location.X == (picBox.Location.X - point.X))
                    {
                        move();
                        Point p = picBox.Location;
                        picBox.Location = pictureBoxes.LastOrDefault().Location;
                        pictureBoxes.LastOrDefault().Location = p;
                        this.Refresh();

                        if (checkFinished())
                        {
                            gameWon();
                        }
                    }
                }
            }
        }

        private void loadImage()
        {
            int x1 = 0;
            int y1 = -(gameImg.Height) / row;
            int leftPadding = paddingLeft + 1;
            int upPadding = paddingUp + 1;

            for (int i = 0; i < row; i++)
            {
                x1 = -(gameImg.Width) / col;
                y1 += (gameImg.Height) / row;

                for (int j = 0; j < col; j++)
                {
                    x1 += (gameImg.Width) / col;
                    Image img = cropImage(gameImg, new Rectangle(x1, y1, gameImg.Width - x1 - lineWidth * col + 3, gameImg.Height - y1 - lineWidth * row + 3));

                    var picBox = new PictureBox
                    {
                        Name = "picBox" + i + "" + j,
                        Size = new Size(x - 2, y - 2),
                        Location = new Point(leftPadding, upPadding),
                        Image = img
                    };
                    picBox.MouseDoubleClick += new MouseEventHandler(PictureBox_MouseDoubleClick);
             
                    pictureBoxes.Add(picBox);
                    this.Controls.Add(picBox);

                    leftPadding += x;
                }
                leftPadding = paddingLeft + 1;
                upPadding += y;
            }

            this.Refresh();
        }

        private void btn_loadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgUploadDialog = new OpenFileDialog();
            imgUploadDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (imgUploadDialog.ShowDialog() == DialogResult.OK)
            {
                string imgName = Path.GetFileName(imgUploadDialog.FileName);

                if (gameImg != null)
                    deleteImage();

                Image img = Image.FromFile(imgUploadDialog.FileName);
                gameImg = changeImage(img, x, y);
                lbl_img.Image = new Bitmap(img, lbl_img.Size);

                lbl_imgName.Text = imgName.ToString();

                loadImage();
                this.Refresh();
            }
        }
    }
}
