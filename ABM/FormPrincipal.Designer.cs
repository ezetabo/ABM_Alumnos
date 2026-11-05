namespace ABM
{
    partial class FormPrincipal
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
            lstPrincipal = new ListBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lstPrincipal
            // 
            lstPrincipal.FormattingEnabled = true;
            lstPrincipal.Location = new Point(33, 23);
            lstPrincipal.Name = "lstPrincipal";
            lstPrincipal.Size = new Size(381, 324);
            lstPrincipal.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(611, 45);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(lstPrincipal);
            Name = "FormPrincipal";
            Text = "Gestion de Alumnos";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPrincipal;
        private Button btnAgregar;
    }
}
