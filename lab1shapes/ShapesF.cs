using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab1shapes
{
    public partial class ShapesF : Form
    {
        private readonly RandomShapeFactory factory = new RandomShapeFactory();

        private Shape currentShape;
        private Shape displayedShape;

        private readonly List<Shape> copies = new List<Shape>();
        public ShapesF()
        {
            InitializeComponent();
            panelShape.Paint += PanelShape_Paint;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            currentShape = factory.CreateRandomShape();
            displayedShape = currentShape;

            UpdateInfo();
            panelShape.Invalidate();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (currentShape == null)
            {
                MessageBox.Show("Сначала выберите фигуру.");
                return;
            }

            Shape copy = currentShape.Clone();
            copies.Add(copy);

            lstCopies.Items.Add(
                copy.Name + " — " + copy.Cells.Count + " клеток"
            );

            lstCopies.SelectedIndex = lstCopies.Items.Count - 1;
        }

        private void lstCopies_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            int index = lstCopies.SelectedIndex;

            if (index >= 0 && index < copies.Count)
            {
                displayedShape = copies[index];
                UpdateInfo();
                panelShape.Invalidate();
            }
        }
        private void UpdateInfo()
        {
            if (displayedShape == null)
            {
                lblInfo.Text = "Фигура не выбрана";
                return;
            }

            string type = displayedShape.IsSuper
                ? "Суперфигура"
                : "Обычная фигура";

            lblInfo.Text = type + ": " +
                displayedShape.Name + ", " +
                displayedShape.Cells.Count + " клеток";
        }

        private void PanelShape_Paint(
            object sender, PaintEventArgs e)
        {
            if (displayedShape == null)
                return;

            int cellSize = 30;

            int maxX = 0;
            int maxY = 0;

            foreach (Point cell in displayedShape.Cells)
            {
                if (cell.X > maxX)
                    maxX = cell.X;

                if (cell.Y > maxY)
                    maxY = cell.Y;
            }

            int shapeWidth = (maxX + 1) * cellSize;
            int shapeHeight = (maxY + 1) * cellSize;

            int startX = (panelShape.ClientSize.Width
                - shapeWidth) / 2;

            int startY = (panelShape.ClientSize.Height
                - shapeHeight) / 2;

            Color shapeColor = displayedShape.IsSuper
                ? Color.Orange
                : Color.CornflowerBlue;

            using (SolidBrush brush = new SolidBrush(shapeColor))
            using (Pen pen = new Pen(Color.Black))
            {
                foreach (Point cell in displayedShape.Cells)
                {
                    int x = startX + cell.X * cellSize;
                    int y = startY + cell.Y * cellSize;

                    Rectangle rectangle = new Rectangle(
                        x, y, cellSize, cellSize);

                    e.Graphics.FillRectangle(brush, rectangle);
                    e.Graphics.DrawRectangle(pen, rectangle);
                }

            }
        }
    }
}
