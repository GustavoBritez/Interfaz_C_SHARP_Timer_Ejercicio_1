namespace Ejercicio_Timer
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.LB_Temperatura = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PIC = new System.Windows.Forms.PictureBox();
            this.BTN_COMENZAR = new System.Windows.Forms.Button();
            this.LB_Estable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(55, 81);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(120, 95);
            this.Lista.TabIndex = 0;
            this.Lista.Visible = false;
            // 
            // LB_Temperatura
            // 
            this.LB_Temperatura.AutoSize = true;
            this.LB_Temperatura.Location = new System.Drawing.Point(77, 65);
            this.LB_Temperatura.Name = "LB_Temperatura";
            this.LB_Temperatura.Size = new System.Drawing.Size(72, 13);
            this.LB_Temperatura.TabIndex = 1;
            this.LB_Temperatura.Text = "Temperaturas";
            this.LB_Temperatura.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PIC
            // 
            this.PIC.Location = new System.Drawing.Point(227, 126);
            this.PIC.Name = "PIC";
            this.PIC.Size = new System.Drawing.Size(100, 50);
            this.PIC.TabIndex = 2;
            this.PIC.TabStop = false;
            // 
            // BTN_COMENZAR
            // 
            this.BTN_COMENZAR.Location = new System.Drawing.Point(129, 23);
            this.BTN_COMENZAR.Name = "BTN_COMENZAR";
            this.BTN_COMENZAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_COMENZAR.TabIndex = 3;
            this.BTN_COMENZAR.Text = "Comenzar";
            this.BTN_COMENZAR.UseVisualStyleBackColor = true;
            this.BTN_COMENZAR.Click += new System.EventHandler(this.BTN_COMENZAR_Click);
            // 
            // LB_Estable
            // 
            this.LB_Estable.AutoSize = true;
            this.LB_Estable.Location = new System.Drawing.Point(251, 110);
            this.LB_Estable.Name = "LB_Estable";
            this.LB_Estable.Size = new System.Drawing.Size(35, 13);
            this.LB_Estable.TabIndex = 4;
            this.LB_Estable.Text = "label1";
            this.LB_Estable.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 188);
            this.Controls.Add(this.LB_Estable);
            this.Controls.Add(this.BTN_COMENZAR);
            this.Controls.Add(this.PIC);
            this.Controls.Add(this.LB_Temperatura);
            this.Controls.Add(this.Lista);
            this.Name = "Form1";
            this.Text = "EjercicioTimer";
            ((System.ComponentModel.ISupportInitialize)(this.PIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Label LB_Temperatura;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PIC;
        private System.Windows.Forms.Button BTN_COMENZAR;
        private System.Windows.Forms.Label LB_Estable;
    }
}

