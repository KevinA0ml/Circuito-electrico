using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuito_electrico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Rtotal.Enabled = false;
            Vtotal.Enabled = false;
            Ctotal.Enabled = false;
        }

        calculos calculos = new calculos();



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            validaciones();
            if (validaciones() == 0)
            {
                return;
            }
            
            double r11 = Convert.ToDouble(r1.Text);
            double r12 = Convert.ToDouble(r2.Text);
            double r13 = Convert.ToDouble(r3.Text);
            double r14 = Convert.ToDouble(r4.Text);
            double r15 = Convert.ToDouble(r5.Text);
            double r16 = Convert.ToDouble(r6.Text);
            double r17 = Convert.ToDouble(r7.Text);
            double r18 = Convert.ToDouble(r8.Text);
            double r19 = Convert.ToDouble(r9.Text);
            double r20 = Convert.ToDouble(r10.Text);

            double fuente = Convert.ToDouble(bateria.Text);


            //CALCULOS
            double req1 = calculos.req1(r18, r20);

            double req2 = calculos.req2(req1, r16, r17, r19);

            double req3 = calculos.req3(req2,r15);

            double req4 = calculos.req4(r11, r12);

            double req5 = calculos.req5(r13, r14);

            double req6 = calculos.reqtotal(req4, req5, req3);

            //resistencia total
            string Restotal = req6.ToString();
         
            Rtotal.Text = Restotal;
            // corriente total 
            double ctotal = calculos.ctotal(fuente, req6);

            Ctotal.Text = ctotal.ToString();

            // voltaje total 
            Vtotal.Text = bateria.Text;
            // voltaje  de r1 y r2
            double r1x2 = calculos.r12x(ctotal, req4);
            // voltaje de r3 y r4
            double r3x4 = calculos.r34x(ctotal, req5);
            // voltaje de r5
            double rx5 = calculos.r5x(ctotal, req3);

                    // corriente par r5
                     double cr5 = rx5 / r15;
                    // corriente para segunda maya 
                    double cmay2 = calculos.vreq3(rx5, req2);

            // voltaje de r6
            double rx6 = calculos.r6x(cmay2, r16);
            // voltaje de r7 
            double rx7 = calculos.r7x(cmay2, r17);
            // voltaje de r9
            double rx9 = calculos.r9x(cmay2, r19);
            // voltaje de r8 y r10
            double r8x10 = calculos.r810(cmay2, req1);

            textBox3.Text = req1.ToString();
            textBox2.Text = req5.ToString();
            textBox1.Text = req4.ToString();
            llenartabla(r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r1x2, r3x4, rx5, rx6, rx7, rx9, r8x10,ctotal, cr5,cmay2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
       
      


        //llenar tabla
        private void llenartabla(double r11, double r12, double r13, double r14, double r15,  double r16, double r17,  double r18,   double r19,  double r20,
        /* voltajes */    double r1x2, double r3x4, double rx5, double rx6, double rx7, double rx9, double r8x10 ,
            /*corriente*/    double ctotal,double cr5, double cmay2)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Resistencia");
            dt.Columns.Add("Valor resistencias");
            dt.Columns.Add("Corriente");
            dt.Columns.Add("Voltaje");
            
            DataRow dr1 = dt.NewRow();
            dr1["Resistencia"] = "R1";
            dr1["Valor resistencias"] = r11;
            dr1["Corriente"] = ctotal;
            dr1["Voltaje"] = r1x2;
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["Resistencia"] = "R2";
            dr2["Valor resistencias"] = r12;
            dr2["Corriente"] = ctotal;
            dr2["Voltaje"] = r1x2;
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3["Resistencia"] = "R3";
            dr3["Valor resistencias"] = r13;
            dr3["Corriente"] = ctotal;
            dr3["Voltaje"] = r3x4;
            dt.Rows.Add(dr3);
            DataRow dr4 = dt.NewRow();
            dr4["Resistencia"] = "R4";
            dr4["Valor resistencias"] = r14;
            dr4["Corriente"] = ctotal;
            dr4["Voltaje"] = r3x4;
            dt.Rows.Add(dr4);
            DataRow dr5 = dt.NewRow();
            dr5["Resistencia"] = "R5";
            dr5["Valor resistencias"] =r15;
            dr5["Corriente"] = cr5;
            dr5["Voltaje"] = rx5;
            dt.Rows.Add(dr5);
            DataRow dr6 = dt.NewRow();
            dr6["Resistencia"] = "R6";
            dr6["Valor resistencias"] = r16;
            dr6["Corriente"] = cmay2;
            dr6["Voltaje"] = rx6;
            dt.Rows.Add(dr6);
            DataRow dr7 = dt.NewRow();
            dr7["Resistencia"] = "R7";
            dr7["Valor resistencias"] = r17;
            dr7["Corriente"] = cmay2;
            dr7["Voltaje"] = rx7;
            dt.Rows.Add(dr7);
            DataRow dr8 = dt.NewRow();
            dr8["Resistencia"] = "R8";
            dr8["Valor resistencias"] = r18;
            dr8["Corriente"] = cmay2;
            dr8["Voltaje"] = r8x10;
            dt.Rows.Add(dr8);
            DataRow dr9 = dt.NewRow();
            dr9["Resistencia"] = "R9";
            dr9["Valor resistencias"] = r19;
            dr9["Corriente"] = cmay2;
            dr9["Voltaje"] = rx9;
            dt.Rows.Add(dr9);
            DataRow dr10 = dt.NewRow();
            dr10["Resistencia"] = "R10";
            dr10["Valor resistencias"] = r20;
            dr10["Corriente"] = cmay2;
            dr10["Voltaje"] = r8x10;
            dt.Rows.Add(dr10);

            dgvdatos.DataSource = dt;
        }

        // limpiar 
        private void limpiar()
        {
            r1.Text = "";
            r2.Text = "";
            r3.Text = "";
            r4.Text = "";
            r5.Text = "";
            r6.Text = "";
            r7.Text = "";
            r8.Text = "";
            r9.Text = "";
            r10.Text = "";
            bateria.Text = "";
            Rtotal.Text = "";
            Ctotal.Text = "";
            Vtotal.Text = "";

            //limpiamos los datos de la data grid
            //optenemos cuantas filas tiene y las eleminamos 1 a 1           
            


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        // validaciones de los cuadros de texto 
        private int validaciones()
        {
            //cuidando que se ingresen ambos datos necesarios
            if ((r1.Text == "") || (r2.Text == "") || (r3.Text == "" ) || (r4.Text == "") || (r5.Text == "") || (r6.Text == "") ||
                (r7.Text == "") || (r8.Text == "") || (r9.Text == "") || (r10.Text == "") || (bateria.Text == ""))
            {
                MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                bateria.Focus();
                return  0;
            }

            
            // verificando que no ingresen datos de texto
            double c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11;
            bool ry = Double.TryParse(bateria.Text, out c1);
            if (ry == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                bateria.Text = "";
                bateria.Focus();
                return 0;
            }
           
            bool ry1 = Double.TryParse(r1.Text, out c2);
            if (ry1 == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                r1.Text = "";
                r1.Focus();
                return 0;
            }
         
            bool ry2 = Double.TryParse(r2.Text, out c3);
            if (ry2 == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                r2.Text = "";
                r2.Focus();
                return 0;
            }
       
            bool ry3 = Double.TryParse(r3.Text, out c4);
            if (ry3 == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                r3.Text = "";
                r3.Focus();
                return 0;
            }
     
            bool ry4 = Double.TryParse(r4.Text, out c5);
            if (ry4 == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                r4.Text = "";
                r4.Focus();
                return 0;
            }

            bool ry5 = Double.TryParse(r5.Text, out c6);
            if (ry5 == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                r5.Text = "";
                r5.Focus();
                return 0;
            }
          
            bool ry6 = Double.TryParse(r6.Text, out c7);
            if (ry6 == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                r6.Text = "";
                r6.Focus();
                return 0;
            }
       
            bool ry7 = Double.TryParse(r7.Text, out c8);
            if (ry7 == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                r7.Text = "";
                r7.Focus();
                return 0;
            }
        
            bool ry8 = Double.TryParse(r8.Text, out c9);
            if (ry8 == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                r8.Text = "";
                r8.Focus();
                return 0;
            }
      
            bool ry9 = Double.TryParse(r9.Text, out c10);
            if (ry9 == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                r9.Text = "";
                r9.Focus();
                return 0;
            }
          
            bool ry10 = Double.TryParse(r10.Text, out c11);
            if (ry10 == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                r10.Text = "";
                r10.Focus();
                return 0;
            }
            return 1;
        }

 
    }
}
