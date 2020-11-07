using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace AppResultadosDeMezclaDeColores
{
    public partial class frmPrincipal : Form
    {
        Color color1;
        Color color2;
        Color colorRes;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void mezclarColores()
        {
            int R1 = this.color1.R;
            int G1 = this.color1.G;
            int B1 = this.color1.B;
            int R2 = this.color2.R;
            int G2 = this.color2.G;
            int B2 = this.color2.B;

            double R = (float)((0.5 * R1) + (0.5 * R2));
            double G = ((float)(0.5 * G1)) + (0.5 * G2);
            double B = ((float)(0.5 * B1)) + (0.5 * B2);

            R = Math.Round(R) - 1;
            G = Math.Round(G) - 1;
            B = Math.Round(B) - 1;
            if (R < 0)
            {
                R++;
            }
            if (G < 0)
            {
                G++;
            }
            if (B < 0)
            {
                B++;
            }

            lblRes.Text = $"{R.ToString()},{G.ToString()},{B.ToString()}";
            this.colorRes = Color.FromArgb(int.Parse(R.ToString()), int.Parse(G.ToString()), int.Parse(B.ToString()));
            btnColorRes.BackColor = this.colorRes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbColor1.Items.Clear();
            cbColor2.Items.Clear();
            string[] colores = Enum.GetNames(typeof(KnownColor));
            cbColor1.Items.AddRange(colores);
            cbColor2.Items.AddRange(colores);
        }

        private void cbColor2_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string texto = cbColor2.Items[e.Index].ToString();
                Brush borde = new SolidBrush(e.ForeColor);
                this.color2 = Color.FromName(texto);
                Brush pincel = new SolidBrush(this.color2);
                Pen boli = new Pen(e.ForeColor);

                e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6));
                e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 65, e.Bounds.Top + 2);
                e.DrawFocusRectangle();

                lblColor2.Text = $"{this.color2.R.ToString()},{this.color2.G.ToString()},{this.color2.B.ToString()}";
                btnColor2.BackColor = this.color2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void cbColor1_DrawItem(object sender, DrawItemEventArgs e)
        {            
            AllowDrop = false;
            try
            {
                e.DrawBackground();
                string texto = cbColor1.Items[e.Index].ToString();
                Brush borde = new SolidBrush(e.ForeColor);
                this.color1 = Color.FromName(texto);
                Brush pincel = new SolidBrush(this.color1);
                Pen boli = new Pen(e.ForeColor);

                e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6));
                e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 65, e.Bounds.Top + 2);
                e.DrawFocusRectangle();

                lblColor1.Text = $"{this.color1.R.ToString()},{this.color1.G.ToString()},{this.color1.B.ToString()}";
                btnColor1.BackColor = this.color1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnMezclar_Click(object sender, EventArgs e)
        {
            if (cbColor1.Text=="" || cbColor2.Text=="")
            {
                MessageBox.Show("Debe seleccionar 2 colores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.mezclarColores();
            }
        }

        private void cbColor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Back)
            {
                this.color1 = new Color();
                lblColor1.Text = "";
                btnColor1.BackColor = Color.Transparent;
            }
        }

        private void cbColor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                this.color2 = new Color();
                lblColor2.Text = "";
                btnColor2.BackColor = Color.Transparent;
            }
        }
    }
}
