
namespace FotoCami2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileOrigen = new System.Windows.Forms.TextBox();
            this.btnFileOrigen = new System.Windows.Forms.Button();
            this.dataArchivos = new System.Windows.Forms.DataGridView();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.help = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnSeleccionarDetino = new System.Windows.Forms.Button();
            this.txtSufijo = new System.Windows.Forms.TextBox();
            this.txtPrefijo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabData = new System.Windows.Forms.TabPage();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnIngSel = new System.Windows.Forms.Button();
            this.snLimpiar = new System.Windows.Forms.CheckBox();
            this.btnCargarArchivos = new System.Windows.Forms.Button();
            this.folderOrigen = new System.Windows.Forms.FolderBrowserDialog();
            this.folderDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.helpPrfijo = new System.Windows.Forms.HelpProvider();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.SNBorrarAnteriores = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataArchivos)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tabData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carpeta de origen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFileOrigen
            // 
            this.txtFileOrigen.Location = new System.Drawing.Point(172, 3);
            this.txtFileOrigen.Name = "txtFileOrigen";
            this.txtFileOrigen.Size = new System.Drawing.Size(509, 27);
            this.txtFileOrigen.TabIndex = 3;
            // 
            // btnFileOrigen
            // 
            this.btnFileOrigen.Location = new System.Drawing.Point(687, 3);
            this.btnFileOrigen.Name = "btnFileOrigen";
            this.btnFileOrigen.Size = new System.Drawing.Size(94, 29);
            this.btnFileOrigen.TabIndex = 4;
            this.btnFileOrigen.Text = "seleccionar";
            this.btnFileOrigen.UseVisualStyleBackColor = true;
            this.btnFileOrigen.Click += new System.EventHandler(this.btnFileOrigen_Click);
            // 
            // dataArchivos
            // 
            this.dataArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArchivos.Location = new System.Drawing.Point(6, 57);
            this.dataArchivos.Name = "dataArchivos";
            this.dataArchivos.RowHeadersWidth = 51;
            this.dataArchivos.RowTemplate.Height = 29;
            this.dataArchivos.Size = new System.Drawing.Size(1024, 330);
            this.dataArchivos.TabIndex = 5;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabConfig);
            this.tabs.Controls.Add(this.tabData);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1044, 426);
            this.tabs.TabIndex = 7;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.help);
            this.tabConfig.Controls.Add(this.txtLog);
            this.tabConfig.Controls.Add(this.label6);
            this.tabConfig.Controls.Add(this.label5);
            this.tabConfig.Controls.Add(this.txtDestino);
            this.tabConfig.Controls.Add(this.btnSeleccionarDetino);
            this.tabConfig.Controls.Add(this.txtSufijo);
            this.tabConfig.Controls.Add(this.txtPrefijo);
            this.tabConfig.Controls.Add(this.label4);
            this.tabConfig.Controls.Add(this.label2);
            this.tabConfig.Controls.Add(this.label3);
            this.tabConfig.Controls.Add(this.txtFileOrigen);
            this.tabConfig.Controls.Add(this.btnFileOrigen);
            this.tabConfig.Location = new System.Drawing.Point(4, 29);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(1036, 393);
            this.tabConfig.TabIndex = 0;
            this.tabConfig.Text = "Configuracion";
            this.tabConfig.UseVisualStyleBackColor = true;
            this.tabConfig.Click += new System.EventHandler(this.tabConfig_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(687, 53);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(94, 29);
            this.help.TabIndex = 16;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(61, 158);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(955, 216);
            this.txtLog.TabIndex = 13;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Log";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Carpeta de destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(141, 103);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(540, 27);
            this.txtDestino.TabIndex = 10;
            // 
            // btnSeleccionarDetino
            // 
            this.btnSeleccionarDetino.Location = new System.Drawing.Point(687, 103);
            this.btnSeleccionarDetino.Name = "btnSeleccionarDetino";
            this.btnSeleccionarDetino.Size = new System.Drawing.Size(94, 29);
            this.btnSeleccionarDetino.TabIndex = 11;
            this.btnSeleccionarDetino.Text = "seleccionar";
            this.btnSeleccionarDetino.UseVisualStyleBackColor = true;
            this.btnSeleccionarDetino.Click += new System.EventHandler(this.btnSeleccionarDetino_Click);
            // 
            // txtSufijo
            // 
            this.txtSufijo.Location = new System.Drawing.Point(522, 53);
            this.txtSufijo.Name = "txtSufijo";
            this.txtSufijo.Size = new System.Drawing.Size(159, 27);
            this.txtSufijo.TabIndex = 8;
            // 
            // txtPrefijo
            // 
            this.txtPrefijo.Location = new System.Drawing.Point(172, 53);
            this.txtPrefijo.Name = "txtPrefijo";
            this.txtPrefijo.Size = new System.Drawing.Size(151, 27);
            this.txtPrefijo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Caracter Posterior a nro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caracter Anterior a nro";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.SNBorrarAnteriores);
            this.tabData.Controls.Add(this.btnCopiar);
            this.tabData.Controls.Add(this.btnMatch);
            this.tabData.Controls.Add(this.btnIngSel);
            this.tabData.Controls.Add(this.snLimpiar);
            this.tabData.Controls.Add(this.btnCargarArchivos);
            this.tabData.Controls.Add(this.dataArchivos);
            this.tabData.Location = new System.Drawing.Point(4, 29);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(1036, 393);
            this.tabData.TabIndex = 2;
            this.tabData.Text = "Archivos";
            this.tabData.UseVisualStyleBackColor = true;
            this.tabData.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(529, 11);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(124, 29);
            this.btnMatch.TabIndex = 9;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnIngSel
            // 
            this.btnIngSel.Location = new System.Drawing.Point(337, 10);
            this.btnIngSel.Name = "btnIngSel";
            this.btnIngSel.Size = new System.Drawing.Size(176, 29);
            this.btnIngSel.TabIndex = 8;
            this.btnIngSel.Text = "Ingresar Seleccion";
            this.btnIngSel.UseVisualStyleBackColor = true;
            this.btnIngSel.Click += new System.EventHandler(this.btnIngSel_Click);
            // 
            // snLimpiar
            // 
            this.snLimpiar.AutoSize = true;
            this.snLimpiar.Location = new System.Drawing.Point(6, 11);
            this.snLimpiar.Name = "snLimpiar";
            this.snLimpiar.Size = new System.Drawing.Size(81, 24);
            this.snLimpiar.TabIndex = 7;
            this.snLimpiar.Text = "Limpiar";
            this.snLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCargarArchivos
            // 
            this.btnCargarArchivos.Location = new System.Drawing.Point(113, 11);
            this.btnCargarArchivos.Name = "btnCargarArchivos";
            this.btnCargarArchivos.Size = new System.Drawing.Size(208, 29);
            this.btnCargarArchivos.TabIndex = 6;
            this.btnCargarArchivos.Text = "Cargar Archivos";
            this.btnCargarArchivos.UseVisualStyleBackColor = true;
            this.btnCargarArchivos.Click += new System.EventHandler(this.btnCargarArchivos_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(921, 11);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(94, 29);
            this.btnCopiar.TabIndex = 10;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // SNBorrarAnteriores
            // 
            this.SNBorrarAnteriores.AutoSize = true;
            this.SNBorrarAnteriores.Location = new System.Drawing.Point(728, 16);
            this.SNBorrarAnteriores.Name = "SNBorrarAnteriores";
            this.SNBorrarAnteriores.Size = new System.Drawing.Size(187, 24);
            this.SNBorrarAnteriores.TabIndex = 11;
            this.SNBorrarAnteriores.Text = "Borrar  fotos en destino";
            this.SNBorrarAnteriores.UseVisualStyleBackColor = true;
            this.SNBorrarAnteriores.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Seleccionador Fotos";
            ((System.ComponentModel.ISupportInitialize)(this.dataArchivos)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileOrigen;
        private System.Windows.Forms.Button btnFileOrigen;
        private System.Windows.Forms.DataGridView dataArchivos;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnSeleccionarDetino;
        private System.Windows.Forms.TextBox txtSufijo;
        private System.Windows.Forms.TextBox txtPrefijo;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.FolderBrowserDialog folderOrigen;
        private System.Windows.Forms.FolderBrowserDialog folderDestino;
        private System.Windows.Forms.HelpProvider helpPrfijo;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.CheckBox snLimpiar;
        private System.Windows.Forms.Button btnCargarArchivos;
        private System.Windows.Forms.Button btnIngSel;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.CheckBox SNBorrarAnteriores;
    }
}

