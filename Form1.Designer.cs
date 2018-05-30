namespace Colas_First_In_First_Off__FIFO_
{
    partial class Form1
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtQueu = new System.Windows.Forms.RichTextBox();
            this.txtCores = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCycles = new System.Windows.Forms.Label();
            this.numCores = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPendingProcess = new System.Windows.Forms.Label();
            this.lblProcessesComplete = new System.Windows.Forms.Label();
            this.lblQueueEmpty = new System.Windows.Forms.Label();
            this.lblPendingCycles = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSimulation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numCycles = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycles)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtQueu
            // 
            this.txtQueu.Location = new System.Drawing.Point(12, 46);
            this.txtQueu.Name = "txtQueu";
            this.txtQueu.Size = new System.Drawing.Size(175, 378);
            this.txtQueu.TabIndex = 0;
            this.txtQueu.Text = "";
            // 
            // txtCores
            // 
            this.txtCores.Location = new System.Drawing.Point(193, 46);
            this.txtCores.Name = "txtCores";
            this.txtCores.Size = new System.Drawing.Size(175, 378);
            this.txtCores.TabIndex = 1;
            this.txtCores.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cola:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Procesadores:";
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Location = new System.Drawing.Point(374, 65);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(384, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Renaudar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCycles
            // 
            this.lblCycles.AutoSize = true;
            this.lblCycles.Location = new System.Drawing.Point(384, 258);
            this.lblCycles.Name = "lblCycles";
            this.lblCycles.Size = new System.Drawing.Size(55, 20);
            this.lblCycles.TabIndex = 6;
            this.lblCycles.Text = "Ciclos:";
            // 
            // numCores
            // 
            this.numCores.Location = new System.Drawing.Point(486, 69);
            this.numCores.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCores.Name = "numCores";
            this.numCores.Size = new System.Drawing.Size(120, 26);
            this.numCores.TabIndex = 7;
            this.numCores.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número de cores:";
            // 
            // lblPendingProcess
            // 
            this.lblPendingProcess.AutoSize = true;
            this.lblPendingProcess.Location = new System.Drawing.Point(384, 376);
            this.lblPendingProcess.Name = "lblPendingProcess";
            this.lblPendingProcess.Size = new System.Drawing.Size(162, 20);
            this.lblPendingProcess.TabIndex = 10;
            this.lblPendingProcess.Text = "Procesos pendientes:";
            this.lblPendingProcess.Visible = false;
            // 
            // lblProcessesComplete
            // 
            this.lblProcessesComplete.AutoSize = true;
            this.lblProcessesComplete.Location = new System.Drawing.Point(384, 317);
            this.lblProcessesComplete.Name = "lblProcessesComplete";
            this.lblProcessesComplete.Size = new System.Drawing.Size(174, 20);
            this.lblProcessesComplete.TabIndex = 11;
            this.lblProcessesComplete.Text = "Procesos completados:";
            // 
            // lblQueueEmpty
            // 
            this.lblQueueEmpty.AutoSize = true;
            this.lblQueueEmpty.Location = new System.Drawing.Point(384, 289);
            this.lblQueueEmpty.Name = "lblQueueEmpty";
            this.lblQueueEmpty.Size = new System.Drawing.Size(128, 20);
            this.lblQueueEmpty.TabIndex = 12;
            this.lblQueueEmpty.Text = "Ciclos cola vacía:";
            // 
            // lblPendingCycles
            // 
            this.lblPendingCycles.AutoSize = true;
            this.lblPendingCycles.Location = new System.Drawing.Point(384, 406);
            this.lblPendingCycles.Name = "lblPendingCycles";
            this.lblPendingCycles.Size = new System.Drawing.Size(138, 20);
            this.lblPendingCycles.TabIndex = 13;
            this.lblPendingCycles.Text = "Ciclos pendientes:";
            this.lblPendingCycles.Visible = false;
            // 
            // btnPause
            // 
            this.btnPause.AutoSize = true;
            this.btnPause.Location = new System.Drawing.Point(496, 210);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(90, 30);
            this.btnPause.TabIndex = 14;
            this.btnPause.Text = "Pausar";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSimulation
            // 
            this.btnSimulation.AutoSize = true;
            this.btnSimulation.Location = new System.Drawing.Point(470, 12);
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.Size = new System.Drawing.Size(146, 30);
            this.btnSimulation.TabIndex = 15;
            this.btnSimulation.Text = "Simular 300 ciclos";
            this.btnSimulation.UseVisualStyleBackColor = true;
            this.btnSimulation.Click += new System.EventHandler(this.btnSimulation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Número de ciclos:";
            // 
            // numCycles
            // 
            this.numCycles.Location = new System.Drawing.Point(486, 136);
            this.numCycles.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numCycles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCycles.Name = "numCycles";
            this.numCycles.Size = new System.Drawing.Size(120, 26);
            this.numCycles.TabIndex = 16;
            this.numCycles.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 469);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numCycles);
            this.Controls.Add(this.btnSimulation);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblPendingCycles);
            this.Controls.Add(this.lblQueueEmpty);
            this.Controls.Add(this.lblProcessesComplete);
            this.Controls.Add(this.lblPendingProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCores);
            this.Controls.Add(this.lblCycles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCores);
            this.Controls.Add(this.txtQueu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numCores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RichTextBox txtQueu;
        private System.Windows.Forms.RichTextBox txtCores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCycles;
        private System.Windows.Forms.NumericUpDown numCores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPendingProcess;
        private System.Windows.Forms.Label lblProcessesComplete;
        private System.Windows.Forms.Label lblQueueEmpty;
        private System.Windows.Forms.Label lblPendingCycles;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnSimulation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCycles;
    }
}

