using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCompuGrafica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarPanelControl(Control c)
        {
            //flagInicio = 1;
            c.Dock = DockStyle.Fill;
            panelDinamico.Controls.Clear();
            panelDinamico.Controls.Add(c);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.panelIzquierda.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.White;
                }
            }
            Button btn = (Button)sender;
            btn.BackColor = Color.GreenYellow;
            string  tag = btn.Tag.ToString();
            switch (tag)
            {
                case "1":
                    parcial1 cUsuario1 = new parcial1();
                    agregarPanelControl(cUsuario1);
                    break;
                case "2":
                    parcial2 cUsuario2 = new parcial2();
                    agregarPanelControl(cUsuario2);
                    break;
                case "3":
                    parcial3 controlUsuario = new parcial3();
                    agregarPanelControl(controlUsuario);
                    break;
                case "4":
                    ufractales fractales = new ufractales();
                    agregarPanelControl(fractales);
                    break;

            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //lblFecha.Text = DateTime.Now.ToLongDateString();
            parcial3 control = new parcial3();
            agregarPanelControl(control);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void panelDinamico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {

            
        }

        private void btnTools_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnTools.Checked)
            {
                panelHerramientas.Height += 10;
                if (panelHerramientas.Height >= 100)
                    timer1.Stop();
            }
            else
            {
                panelHerramientas.Height -= 10;
                if (panelHerramientas.Height <= 10)
                    timer1.Stop();
            }
        }

        private void panelIzquierda_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
