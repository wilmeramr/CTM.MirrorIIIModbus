namespace CTM.MirrorIIIModbus
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.combxPorts = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.analogValueDisplay4 = new AdvancedHMIControls.AnalogValueDisplay();
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.analogValueDisplay3 = new AdvancedHMIControls.AnalogValueDisplay();
            this.analogValueDisplay2 = new AdvancedHMIControls.AnalogValueDisplay();
            this.analogValueDisplay1 = new AdvancedHMIControls.AnalogValueDisplay();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRele4 = new AdvancedHMIControls.MomentaryButton();
            this.btnRele3 = new AdvancedHMIControls.MomentaryButton();
            this.btnRele2 = new AdvancedHMIControls.MomentaryButton();
            this.btnRele1 = new AdvancedHMIControls.MomentaryButton();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ENTRADASDIG = new System.Windows.Forms.Label();
            this.motor4 = new AdvancedHMIControls.Motor();
            this.motor3 = new AdvancedHMIControls.Motor();
            this.motor2 = new AdvancedHMIControls.Motor();
            this.motor1 = new AdvancedHMIControls.Motor();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(327, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(369, 31);
            this.label6.TabIndex = 53;
            this.label6.Text = "EQUIPO MIRROR III MODBUS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(168, 15);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(80, 24);
            this.btnConectar.TabIndex = 52;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // combxPorts
            // 
            this.combxPorts.FormattingEnabled = true;
            this.combxPorts.Location = new System.Drawing.Point(39, 15);
            this.combxPorts.Name = "combxPorts";
            this.combxPorts.Size = new System.Drawing.Size(121, 24);
            this.combxPorts.TabIndex = 51;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(504, 308);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(47, 17);
            this.label46.TabIndex = 99;
            this.label46.Text = "INA_4";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(393, 308);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(47, 17);
            this.label45.TabIndex = 98;
            this.label45.Text = "INA_3";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(271, 308);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(47, 17);
            this.label44.TabIndex = 97;
            this.label44.Text = "INA_2";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(170, 308);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(47, 17);
            this.label43.TabIndex = 96;
            this.label43.Text = "INA_1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 31);
            this.label5.TabIndex = 95;
            this.label5.Text = "IN ANALOGICA 4-20 mA";
            // 
            // analogValueDisplay4
            // 
            this.analogValueDisplay4.BackColor = System.Drawing.SystemColors.Desktop;
            this.analogValueDisplay4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.analogValueDisplay4.ComComponent = this.ethernetIPforCLXCom1;
            this.analogValueDisplay4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay4.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay4.ForeColorInLimits = System.Drawing.Color.Lime;
            this.analogValueDisplay4.ForeColorOverLimit = System.Drawing.Color.Lime;
            this.analogValueDisplay4.ForeColorUnderLimit = System.Drawing.Color.Lime;
            this.analogValueDisplay4.KeypadFontColor = System.Drawing.Color.Lime;
            this.analogValueDisplay4.KeypadMaxValue = 1023D;
            this.analogValueDisplay4.KeypadMinValue = 0D;
            this.analogValueDisplay4.KeypadPasscode = null;
            this.analogValueDisplay4.KeypadScaleFactor = 1D;
            this.analogValueDisplay4.KeypadText = null;
            this.analogValueDisplay4.KeypadWidth = 300;
            this.analogValueDisplay4.Location = new System.Drawing.Point(479, 325);
            this.analogValueDisplay4.Name = "analogValueDisplay4";
            this.analogValueDisplay4.NumericFormat = null;
            this.analogValueDisplay4.PLCAddressKeypad = "";
            this.analogValueDisplay4.PLCAddressValue = null;
            this.analogValueDisplay4.PLCAddressValueLimitLower = null;
            this.analogValueDisplay4.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay4.PLCAddressVisible = null;
            this.analogValueDisplay4.ShowValue = true;
            this.analogValueDisplay4.Size = new System.Drawing.Size(102, 47);
            this.analogValueDisplay4.TabIndex = 94;
            this.analogValueDisplay4.Text = "0000";
            this.analogValueDisplay4.Value = "0000";
            this.analogValueDisplay4.ValueLimitLower = -999999D;
            this.analogValueDisplay4.ValueLimitUpper = 999999D;
            this.analogValueDisplay4.ValuePrefix = null;
            this.analogValueDisplay4.ValueSuffix = null;
            this.analogValueDisplay4.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // ethernetIPforCLXCom1
            // 
            this.ethernetIPforCLXCom1.CIPConnectionSize = 508;
            this.ethernetIPforCLXCom1.DisableMultiServiceRequest = false;
            this.ethernetIPforCLXCom1.DisableSubscriptions = false;
            this.ethernetIPforCLXCom1.IniFileName = "";
            this.ethernetIPforCLXCom1.IniFileSection = null;
            this.ethernetIPforCLXCom1.IPAddress = "192.168.0.10";
            this.ethernetIPforCLXCom1.PollRateOverride = 500;
            this.ethernetIPforCLXCom1.Port = 44818;
            this.ethernetIPforCLXCom1.ProcessorSlot = 0;
            this.ethernetIPforCLXCom1.RoutePath = null;
            this.ethernetIPforCLXCom1.Timeout = 4000;
            // 
            // analogValueDisplay3
            // 
            this.analogValueDisplay3.BackColor = System.Drawing.SystemColors.Desktop;
            this.analogValueDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.analogValueDisplay3.ComComponent = this.ethernetIPforCLXCom1;
            this.analogValueDisplay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay3.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay3.ForeColorInLimits = System.Drawing.Color.Lime;
            this.analogValueDisplay3.ForeColorOverLimit = System.Drawing.Color.Lime;
            this.analogValueDisplay3.ForeColorUnderLimit = System.Drawing.Color.Lime;
            this.analogValueDisplay3.KeypadFontColor = System.Drawing.Color.Lime;
            this.analogValueDisplay3.KeypadMaxValue = 1023D;
            this.analogValueDisplay3.KeypadMinValue = 0D;
            this.analogValueDisplay3.KeypadPasscode = null;
            this.analogValueDisplay3.KeypadScaleFactor = 1D;
            this.analogValueDisplay3.KeypadText = null;
            this.analogValueDisplay3.KeypadWidth = 300;
            this.analogValueDisplay3.Location = new System.Drawing.Point(371, 325);
            this.analogValueDisplay3.Name = "analogValueDisplay3";
            this.analogValueDisplay3.NumericFormat = null;
            this.analogValueDisplay3.PLCAddressKeypad = "";
            this.analogValueDisplay3.PLCAddressValue = null;
            this.analogValueDisplay3.PLCAddressValueLimitLower = null;
            this.analogValueDisplay3.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay3.PLCAddressVisible = null;
            this.analogValueDisplay3.ShowValue = true;
            this.analogValueDisplay3.Size = new System.Drawing.Size(102, 47);
            this.analogValueDisplay3.TabIndex = 93;
            this.analogValueDisplay3.Text = "0000";
            this.analogValueDisplay3.Value = "0000";
            this.analogValueDisplay3.ValueLimitLower = -999999D;
            this.analogValueDisplay3.ValueLimitUpper = 999999D;
            this.analogValueDisplay3.ValuePrefix = null;
            this.analogValueDisplay3.ValueSuffix = null;
            this.analogValueDisplay3.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // analogValueDisplay2
            // 
            this.analogValueDisplay2.BackColor = System.Drawing.SystemColors.Desktop;
            this.analogValueDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.analogValueDisplay2.ComComponent = this.ethernetIPforCLXCom1;
            this.analogValueDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay2.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay2.ForeColorInLimits = System.Drawing.Color.Lime;
            this.analogValueDisplay2.ForeColorOverLimit = System.Drawing.Color.Lime;
            this.analogValueDisplay2.ForeColorUnderLimit = System.Drawing.Color.Lime;
            this.analogValueDisplay2.KeypadFontColor = System.Drawing.Color.Lime;
            this.analogValueDisplay2.KeypadMaxValue = 1023D;
            this.analogValueDisplay2.KeypadMinValue = 0D;
            this.analogValueDisplay2.KeypadPasscode = null;
            this.analogValueDisplay2.KeypadScaleFactor = 1D;
            this.analogValueDisplay2.KeypadText = null;
            this.analogValueDisplay2.KeypadWidth = 300;
            this.analogValueDisplay2.Location = new System.Drawing.Point(255, 327);
            this.analogValueDisplay2.Name = "analogValueDisplay2";
            this.analogValueDisplay2.NumericFormat = null;
            this.analogValueDisplay2.PLCAddressKeypad = "";
            this.analogValueDisplay2.PLCAddressValue = null;
            this.analogValueDisplay2.PLCAddressValueLimitLower = null;
            this.analogValueDisplay2.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay2.PLCAddressVisible = null;
            this.analogValueDisplay2.ShowValue = true;
            this.analogValueDisplay2.Size = new System.Drawing.Size(110, 43);
            this.analogValueDisplay2.TabIndex = 92;
            this.analogValueDisplay2.Text = "0000";
            this.analogValueDisplay2.Value = "0000";
            this.analogValueDisplay2.ValueLimitLower = -999999D;
            this.analogValueDisplay2.ValueLimitUpper = 999999D;
            this.analogValueDisplay2.ValuePrefix = null;
            this.analogValueDisplay2.ValueSuffix = null;
            this.analogValueDisplay2.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // analogValueDisplay1
            // 
            this.analogValueDisplay1.BackColor = System.Drawing.SystemColors.Desktop;
            this.analogValueDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.analogValueDisplay1.ComComponent = this.ethernetIPforCLXCom1;
            this.analogValueDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay1.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay1.ForeColorInLimits = System.Drawing.Color.Lime;
            this.analogValueDisplay1.ForeColorOverLimit = System.Drawing.Color.Lime;
            this.analogValueDisplay1.ForeColorUnderLimit = System.Drawing.Color.Lime;
            this.analogValueDisplay1.KeypadFontColor = System.Drawing.Color.Lime;
            this.analogValueDisplay1.KeypadMaxValue = 1023D;
            this.analogValueDisplay1.KeypadMinValue = 0D;
            this.analogValueDisplay1.KeypadPasscode = null;
            this.analogValueDisplay1.KeypadScaleFactor = 1D;
            this.analogValueDisplay1.KeypadText = null;
            this.analogValueDisplay1.KeypadWidth = 300;
            this.analogValueDisplay1.Location = new System.Drawing.Point(138, 327);
            this.analogValueDisplay1.Name = "analogValueDisplay1";
            this.analogValueDisplay1.NumericFormat = null;
            this.analogValueDisplay1.PLCAddressKeypad = "";
            this.analogValueDisplay1.PLCAddressValue = null;
            this.analogValueDisplay1.PLCAddressValueLimitLower = null;
            this.analogValueDisplay1.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay1.PLCAddressVisible = null;
            this.analogValueDisplay1.ShowValue = true;
            this.analogValueDisplay1.Size = new System.Drawing.Size(110, 43);
            this.analogValueDisplay1.TabIndex = 91;
            this.analogValueDisplay1.Text = "0000";
            this.analogValueDisplay1.Value = "0000";
            this.analogValueDisplay1.ValueLimitLower = -999999D;
            this.analogValueDisplay1.ValueLimitUpper = 999999D;
            this.analogValueDisplay1.ValuePrefix = null;
            this.analogValueDisplay1.ValueSuffix = null;
            this.analogValueDisplay1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 104;
            this.label1.Text = "SALIDAS DIGITALES";
            // 
            // btnRele4
            // 
            this.btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            this.btnRele4.ComComponent = this.ethernetIPforCLXCom1;
            this.btnRele4.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large;
            this.btnRele4.Location = new System.Drawing.Point(445, 159);
            this.btnRele4.MaximumHoldTime = 3000;
            this.btnRele4.MinimumHoldTime = 500;
            this.btnRele4.Name = "btnRele4";
            this.btnRele4.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet;
            this.btnRele4.PLCAddressClick = "";
            this.btnRele4.PLCAddressVisible = "";
            this.btnRele4.Size = new System.Drawing.Size(64, 94);
            this.btnRele4.TabIndex = 103;
            this.btnRele4.Text = "RELE4";
            this.btnRele4.Click += new System.EventHandler(this.btnRele4_Click);
            // 
            // btnRele3
            // 
            this.btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            this.btnRele3.ComComponent = this.ethernetIPforCLXCom1;
            this.btnRele3.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large;
            this.btnRele3.Location = new System.Drawing.Point(355, 159);
            this.btnRele3.MaximumHoldTime = 3000;
            this.btnRele3.MinimumHoldTime = 500;
            this.btnRele3.Name = "btnRele3";
            this.btnRele3.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet;
            this.btnRele3.PLCAddressClick = "";
            this.btnRele3.PLCAddressVisible = "";
            this.btnRele3.Size = new System.Drawing.Size(61, 89);
            this.btnRele3.TabIndex = 102;
            this.btnRele3.Text = "RELE3";
            this.btnRele3.Click += new System.EventHandler(this.btnRele3_Click);
            // 
            // btnRele2
            // 
            this.btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            this.btnRele2.ComComponent = this.ethernetIPforCLXCom1;
            this.btnRele2.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large;
            this.btnRele2.Location = new System.Drawing.Point(267, 159);
            this.btnRele2.MaximumHoldTime = 3000;
            this.btnRele2.MinimumHoldTime = 500;
            this.btnRele2.Name = "btnRele2";
            this.btnRele2.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet;
            this.btnRele2.PLCAddressClick = "";
            this.btnRele2.PLCAddressVisible = "";
            this.btnRele2.Size = new System.Drawing.Size(64, 94);
            this.btnRele2.TabIndex = 101;
            this.btnRele2.Text = "RELE2";
            this.btnRele2.Click += new System.EventHandler(this.btnRele2_Click);
            // 
            // btnRele1
            // 
            this.btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            this.btnRele1.ComComponent = this.ethernetIPforCLXCom1;
            this.btnRele1.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large;
            this.btnRele1.Location = new System.Drawing.Point(168, 159);
            this.btnRele1.MaximumHoldTime = 3000;
            this.btnRele1.MinimumHoldTime = 500;
            this.btnRele1.Name = "btnRele1";
            this.btnRele1.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet;
            this.btnRele1.PLCAddressClick = "";
            this.btnRele1.PLCAddressVisible = "";
            this.btnRele1.Size = new System.Drawing.Size(61, 89);
            this.btnRele1.TabIndex = 100;
            this.btnRele1.Text = "RELE1";
            this.btnRele1.Click += new System.EventHandler(this.btnRele1_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(470, 446);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(39, 17);
            this.label30.TabIndex = 117;
            this.label30.Text = "IN_4";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(385, 446);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(39, 17);
            this.label29.TabIndex = 116;
            this.label29.Text = "IN_3";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(295, 446);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 17);
            this.label28.TabIndex = 115;
            this.label28.Text = "IN_2";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(211, 446);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 17);
            this.label27.TabIndex = 114;
            this.label27.Text = "IN_1";
            // 
            // ENTRADASDIG
            // 
            this.ENTRADASDIG.AutoSize = true;
            this.ENTRADASDIG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ENTRADASDIG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENTRADASDIG.Location = new System.Drawing.Point(195, 401);
            this.ENTRADASDIG.Name = "ENTRADASDIG";
            this.ENTRADASDIG.Size = new System.Drawing.Size(292, 31);
            this.ENTRADASDIG.TabIndex = 113;
            this.ENTRADASDIG.Text = "ENTRADAS DIGITALES";
            // 
            // motor4
            // 
            this.motor4.ComComponent = this.ethernetIPforCLXCom1;
            this.motor4.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green;
            this.motor4.Location = new System.Drawing.Point(451, 463);
            this.motor4.Name = "motor4";
            this.motor4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.motor4.PLCAddressClick = "";
            this.motor4.PLCAddressText = "";
            this.motor4.PLCAddressValue = "";
            this.motor4.PLCAddressVisible = "";
            this.motor4.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.motor4.Size = new System.Drawing.Size(75, 51);
            this.motor4.TabIndex = 112;
            this.motor4.Text = "IN4";
            this.motor4.Value = false;
            // 
            // motor3
            // 
            this.motor3.ComComponent = this.ethernetIPforCLXCom1;
            this.motor3.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green;
            this.motor3.Location = new System.Drawing.Point(364, 463);
            this.motor3.Name = "motor3";
            this.motor3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.motor3.PLCAddressClick = "";
            this.motor3.PLCAddressText = "";
            this.motor3.PLCAddressValue = "";
            this.motor3.PLCAddressVisible = "";
            this.motor3.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.motor3.Size = new System.Drawing.Size(75, 51);
            this.motor3.TabIndex = 111;
            this.motor3.Text = "IN3";
            this.motor3.Value = false;
            // 
            // motor2
            // 
            this.motor2.ComComponent = this.ethernetIPforCLXCom1;
            this.motor2.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green;
            this.motor2.Location = new System.Drawing.Point(279, 463);
            this.motor2.Name = "motor2";
            this.motor2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.motor2.PLCAddressClick = "";
            this.motor2.PLCAddressText = "";
            this.motor2.PLCAddressValue = "";
            this.motor2.PLCAddressVisible = "";
            this.motor2.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.motor2.Size = new System.Drawing.Size(75, 51);
            this.motor2.TabIndex = 110;
            this.motor2.Text = "IN2";
            this.motor2.Value = false;
            // 
            // motor1
            // 
            this.motor1.ComComponent = this.ethernetIPforCLXCom1;
            this.motor1.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green;
            this.motor1.Location = new System.Drawing.Point(195, 463);
            this.motor1.Name = "motor1";
            this.motor1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.motor1.PLCAddressClick = "";
            this.motor1.PLCAddressText = "";
            this.motor1.PLCAddressValue = "";
            this.motor1.PLCAddressVisible = "";
            this.motor1.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.motor1.Size = new System.Drawing.Size(75, 51);
            this.motor1.TabIndex = 109;
            this.motor1.Text = "IN1";
            this.motor1.Value = false;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(168, 45);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(80, 24);
            this.btnDesconectar.TabIndex = 119;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CTM.MirrorIIIModbus.Properties.Resources.logoctm;
            this.pictureBox1.Location = new System.Drawing.Point(504, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CTM.MirrorIIIModbus.Properties.Resources.update;
            this.pictureBox2.Image = global::CTM.MirrorIIIModbus.Properties.Resources.update;
            this.pictureBox2.Location = new System.Drawing.Point(8, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 120;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 550);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.ENTRADASDIG);
            this.Controls.Add(this.motor4);
            this.Controls.Add(this.motor3);
            this.Controls.Add(this.motor2);
            this.Controls.Add(this.motor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRele4);
            this.Controls.Add(this.btnRele3);
            this.Controls.Add(this.btnRele2);
            this.Controls.Add(this.btnRele1);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.analogValueDisplay4);
            this.Controls.Add(this.analogValueDisplay3);
            this.Controls.Add(this.analogValueDisplay2);
            this.Controls.Add(this.analogValueDisplay1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.combxPorts);
            this.Name = "Main";
            this.Text = "CTM | Mirror III Modbus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox combxPorts;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label5;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay4;
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay3;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay2;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay1;
        private System.Windows.Forms.Label label1;
        private AdvancedHMIControls.MomentaryButton btnRele4;
        private AdvancedHMIControls.MomentaryButton btnRele3;
        private AdvancedHMIControls.MomentaryButton btnRele2;
        private AdvancedHMIControls.MomentaryButton btnRele1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label ENTRADASDIG;
        private AdvancedHMIControls.Motor motor4;
        private AdvancedHMIControls.Motor motor3;
        private AdvancedHMIControls.Motor motor2;
        private AdvancedHMIControls.Motor motor1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

