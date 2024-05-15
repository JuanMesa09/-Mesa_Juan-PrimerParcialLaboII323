namespace FmrAtencion
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
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            richTextBox1 = new RichTextBox();
            btnAtender = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 12);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(264, 289);
            lstMedicos.TabIndex = 0;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(317, 12);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(234, 289);
            lstPacientes.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 307);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(539, 96);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(583, 54);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(101, 61);
            btnAtender.TabIndex = 3;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(583, 267);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(101, 60);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(richTextBox1);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox richTextBox1;
        private Button btnAtender;
        private Button btnSalir;
    }
}
