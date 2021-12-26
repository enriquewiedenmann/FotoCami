
namespace FotoCami4._0.Front
{
    partial class FotoCami
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lDestino = new System.Windows.Forms.Label();
            this.lOrigen = new System.Windows.Forms.Label();
            this.lPrefijo = new System.Windows.Forms.Label();
            this.lSufijo = new System.Windows.Forms.Label();
            this.lLog = new System.Windows.Forms.Label();
            this.lNros = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtPrefijo = new System.Windows.Forms.TextBox();
            this.txtSufijo = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnOrigen = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnAuxData = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.RichTextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnAuxLista = new System.Windows.Forms.Button();
            this.folderBrowserOrigen = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.snOrdenLista = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAuxData);
            this.splitContainer1.Panel1.Controls.Add(this.btnDestino);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrigen);
            this.splitContainer1.Panel1.Controls.Add(this.txtLog);
            this.splitContainer1.Panel1.Controls.Add(this.txtSufijo);
            this.splitContainer1.Panel1.Controls.Add(this.txtPrefijo);
            this.splitContainer1.Panel1.Controls.Add(this.txtDestino);
            this.splitContainer1.Panel1.Controls.Add(this.txtOrigen);
            this.splitContainer1.Panel1.Controls.Add(this.lLog);
            this.splitContainer1.Panel1.Controls.Add(this.lSufijo);
            this.splitContainer1.Panel1.Controls.Add(this.lPrefijo);
            this.splitContainer1.Panel1.Controls.Add(this.lDestino);
            this.splitContainer1.Panel1.Controls.Add(this.lOrigen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.snOrdenLista);
            this.splitContainer1.Panel2.Controls.Add(this.btnAuxLista);
            this.splitContainer1.Panel2.Controls.Add(this.btnProcesar);
            this.splitContainer1.Panel2.Controls.Add(this.txtLista);
            this.splitContainer1.Panel2.Controls.Add(this.lNros);
            this.splitContainer1.Size = new System.Drawing.Size(1003, 670);
            this.splitContainer1.SplitterDistance = 672;
            this.splitContainer1.TabIndex = 0;
            // 
            // lDestino
            // 
            this.lDestino.AutoSize = true;
            this.lDestino.Location = new System.Drawing.Point(18, 58);
            this.lDestino.Name = "lDestino";
            this.lDestino.Size = new System.Drawing.Size(56, 17);
            this.lDestino.TabIndex = 1;
            this.lDestino.Text = "Destino";
            this.lDestino.Click += new System.EventHandler(this.lDestino_Click);
            // 
            // lOrigen
            // 
            this.lOrigen.AutoSize = true;
            this.lOrigen.Location = new System.Drawing.Point(18, 9);
            this.lOrigen.Name = "lOrigen";
            this.lOrigen.Size = new System.Drawing.Size(51, 17);
            this.lOrigen.TabIndex = 0;
            this.lOrigen.Text = "Origen";
            this.lOrigen.Click += new System.EventHandler(this.label1_Click);
            // 
            // lPrefijo
            // 
            this.lPrefijo.AutoSize = true;
            this.lPrefijo.Location = new System.Drawing.Point(18, 91);
            this.lPrefijo.Name = "lPrefijo";
            this.lPrefijo.Size = new System.Drawing.Size(48, 17);
            this.lPrefijo.TabIndex = 2;
            this.lPrefijo.Text = "Prefijo";
            // 
            // lSufijo
            // 
            this.lSufijo.AutoSize = true;
            this.lSufijo.Location = new System.Drawing.Point(257, 91);
            this.lSufijo.Name = "lSufijo";
            this.lSufijo.Size = new System.Drawing.Size(43, 17);
            this.lSufijo.TabIndex = 3;
            this.lSufijo.Text = "Sufijo";
            // 
            // lLog
            // 
            this.lLog.AutoSize = true;
            this.lLog.Location = new System.Drawing.Point(18, 121);
            this.lLog.Name = "lLog";
            this.lLog.Size = new System.Drawing.Size(32, 17);
            this.lLog.TabIndex = 4;
            this.lLog.Text = "Log";
            // 
            // lNros
            // 
            this.lNros.AutoSize = true;
            this.lNros.Location = new System.Drawing.Point(3, 9);
            this.lNros.Name = "lNros";
            this.lNros.Size = new System.Drawing.Size(92, 17);
            this.lNros.TabIndex = 0;
            this.lNros.Text = "Lista de Nros";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Enabled = false;
            this.txtOrigen.Location = new System.Drawing.Point(75, 4);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(460, 22);
            this.txtOrigen.TabIndex = 5;
            this.txtOrigen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(75, 53);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(460, 22);
            this.txtDestino.TabIndex = 6;
            // 
            // txtPrefijo
            // 
            this.txtPrefijo.Location = new System.Drawing.Point(75, 86);
            this.txtPrefijo.Name = "txtPrefijo";
            this.txtPrefijo.Size = new System.Drawing.Size(178, 22);
            this.txtPrefijo.TabIndex = 7;
            // 
            // txtSufijo
            // 
            this.txtSufijo.Location = new System.Drawing.Point(307, 86);
            this.txtSufijo.Name = "txtSufijo";
            this.txtSufijo.Size = new System.Drawing.Size(228, 22);
            this.txtSufijo.TabIndex = 8;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(18, 147);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtLog.Size = new System.Drawing.Size(628, 501);
            this.txtLog.TabIndex = 9;
            this.txtLog.Text = "";
            // 
            // btnOrigen
            // 
            this.btnOrigen.Location = new System.Drawing.Point(542, 3);
            this.btnOrigen.Name = "btnOrigen";
            this.btnOrigen.Size = new System.Drawing.Size(104, 23);
            this.btnOrigen.TabIndex = 10;
            this.btnOrigen.Text = "Seleccionar";
            this.btnOrigen.UseVisualStyleBackColor = true;
            this.btnOrigen.Click += new System.EventHandler(this.btnOrigen_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(542, 52);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(104, 23);
            this.btnDestino.TabIndex = 11;
            this.btnDestino.Text = "Seleccionar";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnAuxData
            // 
            this.btnAuxData.Location = new System.Drawing.Point(542, 85);
            this.btnAuxData.Name = "btnAuxData";
            this.btnAuxData.Size = new System.Drawing.Size(104, 23);
            this.btnAuxData.TabIndex = 13;
            this.btnAuxData.Text = "?";
            this.btnAuxData.UseVisualStyleBackColor = true;
            this.btnAuxData.Click += new System.EventHandler(this.btnAuxData_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(12, 37);
            this.txtLista.Name = "txtLista";
            this.txtLista.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtLista.Size = new System.Drawing.Size(297, 562);
            this.txtLista.TabIndex = 1;
            this.txtLista.Text = "";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(12, 605);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(297, 43);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnAuxLista
            // 
            this.btnAuxLista.Location = new System.Drawing.Point(102, 3);
            this.btnAuxLista.Name = "btnAuxLista";
            this.btnAuxLista.Size = new System.Drawing.Size(38, 23);
            this.btnAuxLista.TabIndex = 3;
            this.btnAuxLista.Text = "?";
            this.btnAuxLista.UseVisualStyleBackColor = true;
            this.btnAuxLista.Click += new System.EventHandler(this.btnAuxLista_Click);
            // 
            // snOrdenLista
            // 
            this.snOrdenLista.AutoSize = true;
            this.snOrdenLista.Location = new System.Drawing.Point(151, 5);
            this.snOrdenLista.Name = "snOrdenLista";
            this.snOrdenLista.Size = new System.Drawing.Size(158, 21);
            this.snOrdenLista.TabIndex = 4;
            this.snOrdenLista.Text = "Mantiene orden lista";
            this.snOrdenLista.UseVisualStyleBackColor = true;
            // 
            // FotoCami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 670);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FotoCami";
            this.Text = "FotoCami";
            this.Load += new System.EventHandler(this.FotoCami_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lOrigen;
        private System.Windows.Forms.Label lDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lLog;
        private System.Windows.Forms.Label lSufijo;
        private System.Windows.Forms.Label lPrefijo;
        private System.Windows.Forms.Label lNros;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnOrigen;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtSufijo;
        private System.Windows.Forms.TextBox txtPrefijo;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnAuxData;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.RichTextBox txtLista;
        private System.Windows.Forms.Button btnAuxLista;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserOrigen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDestino;
        private System.Windows.Forms.CheckBox snOrdenLista;
    }
}