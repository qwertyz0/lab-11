using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_11
{
    public partial class fMain : Form
    {
        CFigure[] figures;
        int FigureCount = 0;
        int CurrentFigureIndex;

        public fMain()
        {
            InitializeComponent();
            figures = new CFigure[100];
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (FigureCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }
            Graphics graphics = pnMain.CreateGraphics();
            CurrentFigureIndex = FigureCount;

            // Створення нового об'єкта - екземпляра класу CCircle     
            figures[CurrentFigureIndex] = new CFigure(graphics, 200, 200);
            figures[CurrentFigureIndex].Show();
            FigureCount++;

            cbFigures.Items.Add("Коло №" + (FigureCount - 1).ToString());
            cbFigures.SelectedIndex = FigureCount - 1;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;

            // ---------------------------------------------------------------     
            // Приховування поточного об'єкта - екземпляра класу CCircle     
            figures[CurrentFigureIndex].Hide();
            // --------------------------------------------------------------- 
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;

            // ---------------------------------------------------------------     
            // Відображення поточного об'єкта     
            figures[CurrentFigureIndex].Show();
            // --------------------------------------------------------------- 
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;

            // ---------------------------------------------------------------    
            // Розширення поточного об'єкта - екземпляра класу CCircle     
            figures[CurrentFigureIndex].Expand(5);
            // --------------------------------------------------------------- 
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;
            // ---------------------------------------------------------------     
            // Стискання поточного об'єкта - екземпляра класу CCircle     
            figures[CurrentFigureIndex].Collapse(5);
            // --------------------------------------------------------------- 
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;

            // ---------------------------------------------------------------     
            // Переміщення вверх поточного об'єкта    
            figures[CurrentFigureIndex].Move(0, -10);
            // ---------------------------------------------------------------
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;

            // ---------------------------------------------------------------     
            // Переміщення вниз поточного об'єкта     
            figures[CurrentFigureIndex].Move(0, 10);
            // --------------------------------------------------------------- } 
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;

            // ---------------------------------------------------------------     
            // Переміщення вправо поточного об'єкта    
            figures[CurrentFigureIndex].Move(10, 0);
            // --------------------------------------------------------------- 
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;
            // ---------------------------------------------------------------     
            // Переміщення вліво поточного об'єкта     
            figures[CurrentFigureIndex].Move(-10, 0);
            // --------------------------------------------------------------- 
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;

            // ---------------------------------------------------------------     
            // Переміщення поточного об'єкта вправо на більшу відстань     
            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
            // --------------------------------------------------------------- 
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;

            // ---------------------------------------------------------------     
            // Переміщення поточного об'єкта вліво на більшу відстань     
            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
            // --------------------------------------------------------------- 
        }

        private void btnUpFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;

            // ---------------------------------------------------------------    
            // Переміщення поточного об'єкта вверх на більшу відстань     
            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbFigures.SelectedIndex;
            if ((CurrentFigureIndex > FigureCount) || (CurrentFigureIndex < 0))
                return;

            // ---------------------------------------------------------------    
            // Переміщення поточного об'єкта вниз на більшу відстань     
            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
            // --------------------------------------------------------------- 
        }
    }
}
