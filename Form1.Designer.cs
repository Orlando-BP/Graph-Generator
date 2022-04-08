
namespace Generador_de_Grafos
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
            this.pictureBoxGrafo = new System.Windows.Forms.PictureBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonKruskal = new System.Windows.Forms.Button();
            this.buttonInformacion = new System.Windows.Forms.Button();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonArista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrafo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxGrafo
            // 
            this.pictureBoxGrafo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxGrafo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxGrafo.Name = "pictureBoxGrafo";
            this.pictureBoxGrafo.Size = new System.Drawing.Size(776, 426);
            this.pictureBoxGrafo.TabIndex = 0;
            this.pictureBoxGrafo.TabStop = false;
            this.pictureBoxGrafo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGrafo_MouseDoubleClick);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalir.Location = new System.Drawing.Point(12, 444);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(130, 40);
            this.buttonSalir.TabIndex = 1;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonKruskal
            // 
            this.buttonKruskal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKruskal.Location = new System.Drawing.Point(680, 444);
            this.buttonKruskal.Name = "buttonKruskal";
            this.buttonKruskal.Size = new System.Drawing.Size(314, 40);
            this.buttonKruskal.TabIndex = 2;
            this.buttonKruskal.Text = "Mostrar Kruskal";
            this.buttonKruskal.UseVisualStyleBackColor = true;
            this.buttonKruskal.Click += new System.EventHandler(this.buttonKruskal_Click);
            // 
            // buttonInformacion
            // 
            this.buttonInformacion.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInformacion.Location = new System.Drawing.Point(332, 444);
            this.buttonInformacion.Name = "buttonInformacion";
            this.buttonInformacion.Size = new System.Drawing.Size(151, 40);
            this.buttonInformacion.TabIndex = 3;
            this.buttonInformacion.Text = "Informacion";
            this.buttonInformacion.UseVisualStyleBackColor = true;
            this.buttonInformacion.Click += new System.EventHandler(this.buttonInformacion_Click);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(6, 43);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownA.TabIndex = 4;
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(125, 43);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vertice A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vertice B";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonArista);
            this.groupBox1.Controls.Add(this.numericUpDownB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(794, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir Arista";
            // 
            // buttonArista
            // 
            this.buttonArista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonArista.Location = new System.Drawing.Point(6, 72);
            this.buttonArista.Name = "buttonArista";
            this.buttonArista.Size = new System.Drawing.Size(188, 55);
            this.buttonArista.TabIndex = 8;
            this.buttonArista.Text = "Agregar Arista de A a B";
            this.buttonArista.UseVisualStyleBackColor = true;
            this.buttonArista.Click += new System.EventHandler(this.buttonArista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonInformacion);
            this.Controls.Add(this.buttonKruskal);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.pictureBoxGrafo);
            this.Name = "Form1";
            this.Text = "Generador de Grafos - Arboles KRUSKAL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrafo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGrafo;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonKruskal;
        private System.Windows.Forms.Button buttonInformacion;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonArista;
    }
}

