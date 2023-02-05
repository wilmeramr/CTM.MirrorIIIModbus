using AdvancedHMIControls;
using EasyModbus;
using System;
using System.Drawing;
using System.Windows.Forms;
using static MfgControl.AdvancedHMI.Controls.PushButton;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace CTM.MirrorIIIModbus
{
    public partial class Main : Form
    {

        private static EasyModbusRTU _modbusMaster = null;
        private static bool consultaHabilitada = false;
        delegate void delegado(ushort[] valor);
        delegate void delegadoAnalogia(bool[] valor);


        public Main()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            actualizarPorts();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (_modbusMaster == null || _modbusMaster.Connected() == false)
                _modbusMaster = new EasyModbusRTU(combxPorts.SelectedItem.ToString());
            timer1.Start();
            LeerSalida();
            btnConectar.Enabled = false;
            btnDesconectar.Enabled = true;
            btnConectar.BackColor = Color.Green;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (consultaHabilitada)
            {
                // Task.Run(new Action(ReadAnalogicas4));
                //Task.Run(new Action(ReadAnalogicas5));
                //Task.Run(new Action(Tank));
                //  Task.Run(new Action());
                Actualizar_InDigitales();
                actualizar_INA1();
            }

        }



        private void actualizar_INA1()
        {
            var Valor = _modbusMaster.ReadInputRegister(3, 21, 12);
            if (Valor != null)
            {
                analogValueDisplay1.Value = Valor[0].ToString();
                analogValueDisplay2.Value = Valor[1].ToString();
                analogValueDisplay3.Value = Valor[2].ToString();
                analogValueDisplay4.Value = Valor[3].ToString();
            }


        }

        private void Actualizar_InDigitales()
        {

            var Valor = _modbusMaster.ReadDiscreteInputs(3, 0, 8);

            if (Valor != null)
            {
                consultaHabilitada = true;
                motor1.Value = !Valor[0];
                motor2.Value = !Valor[1];
                motor3.Value = !Valor[2];
                motor4.Value = !Valor[3];
           
            }
            consultaHabilitada = true;




        }
        private void EscribirSalida(int registro, int valor)
        {

            _modbusMaster.WriteSingleRegister(3, registro, valor);
        }

        private void LeerSalida()
        {

            _modbusMaster.ReadHoldingRegisters(1,1, 15);
        }

        private void btnRele1_Click(object sender, EventArgs e)
        {
            var mb = btnRele1.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(0, 1);
            }
            else
            {
                btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(0, 0);
            }
        }

        private void btnRele2_Click(object sender, EventArgs e)
        {
            var mb = btnRele2.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(0, 1);
            }
            else
            {
                btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(0, 0);
            }
        }

        private void btnRele3_Click(object sender, EventArgs e)
        {
            var mb = btnRele3.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(0, 1);
            }
            else
            {
                btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(0, 0);
            }
        }

        private void btnRele4_Click(object sender, EventArgs e)
        {
            var mb = btnRele4.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(0, 1);
            }
            else
            {
                btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(0, 0);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            _modbusMaster.Close();
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnConectar.BackColor = Color.Transparent;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_modbusMaster != null)
                _modbusMaster.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            actualizarPorts();
        }

        private void actualizarPorts()
        {
            var serial = System.IO.Ports.SerialPort.GetPortNames();
            combxPorts.DataSource = serial;
        }
    }
}
