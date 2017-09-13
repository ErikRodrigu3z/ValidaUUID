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
using System.IO;
using ValidaUuuiSat.ServiceReference1; //referencia de servicio


namespace ValidaUuuiSat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clases publicas del web service del SAT
            ServiceReference1.ConsultaCFDIServiceClient wsValidaCFDI = new ServiceReference1.ConsultaCFDIServiceClient();
            ServiceReference1.Acuse wsSATAcuse = new ServiceReference1.Acuse();

            string sCadenaCFDI = "?re="+txtRfcEmisor.Text+"&rr="+txtRfcReceptor.Text+"&tt="+txtCadenaTotal.Text+"&id="+txtUUID.Text+"";
            wsSATAcuse = wsValidaCFDI.Consulta(sCadenaCFDI);
            string sCodigoEstatus = wsSATAcuse.CodigoEstatus;

            //MessageBox.Show(sCodigoEstatus);
            
            //?re=BEN9501023I0&rr=SARM8209281F1&tt=440.000000&id=EC609EC1-5F63-4333-A2B8-2EDC10B68075
            if (sCodigoEstatus == "S - Comprobante obtenido satisfactoriamente.")
            {
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.ForeColor = Color.Red;
            }
            label2.BackColor = Color.DarkBlue;            
            label2.Text = sCodigoEstatus;



            /*
             string sCadenaCFDI = "?re=" + _RFCEMISOR + "&rr=" + _RFCRECEPTOR + "&tt=" + _CadenaTotal + "&id=" + _uuid;
                            wsSATAcuse = wsValidaCFDI.Consulta(sCadenaCFDI);
                            string sCodigoEstatus = wsSATAcuse.CodigoEstatus;
             */
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRfcReceptor.ResetText();
            txtCadenaTotal.ResetText();
            txtRfcEmisor.ResetText();
            txtUUID.ResetText();
            label2.ResetText();
        }
       
    }
}
