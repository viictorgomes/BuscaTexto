namespace BuscaTexto
{
    partial class Pesquisar
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
            this.lb_localizar = new System.Windows.Forms.Label();
            this.txtbox_pesquisar = new System.Windows.Forms.TextBox();
            this.rbtn_forca = new System.Windows.Forms.RadioButton();
            this.rbtn_rabin = new System.Windows.Forms.RadioButton();
            this.rbtn_kmp = new System.Windows.Forms.RadioButton();
            this.rbtn_boyer = new System.Windows.Forms.RadioButton();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_substituir = new System.Windows.Forms.Button();
            this.txtbox_substituir = new System.Windows.Forms.TextBox();
            this.lb_substituir = new System.Windows.Forms.Label();
            this.groupBox_modos = new System.Windows.Forms.GroupBox();
            this.checkbox_case = new System.Windows.Forms.CheckBox();
            this.groupBox_modos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_localizar
            // 
            this.lb_localizar.AutoSize = true;
            this.lb_localizar.Location = new System.Drawing.Point(31, 19);
            this.lb_localizar.Name = "lb_localizar";
            this.lb_localizar.Size = new System.Drawing.Size(52, 13);
            this.lb_localizar.TabIndex = 0;
            this.lb_localizar.Text = "Localizar:";
            // 
            // txtbox_pesquisar
            // 
            this.txtbox_pesquisar.Location = new System.Drawing.Point(89, 17);
            this.txtbox_pesquisar.Name = "txtbox_pesquisar";
            this.txtbox_pesquisar.Size = new System.Drawing.Size(342, 20);
            this.txtbox_pesquisar.TabIndex = 1;
            this.txtbox_pesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_pesquisar_KeyDown);
            // 
            // rbtn_forca
            // 
            this.rbtn_forca.AutoSize = true;
            this.rbtn_forca.Location = new System.Drawing.Point(15, 19);
            this.rbtn_forca.Name = "rbtn_forca";
            this.rbtn_forca.Size = new System.Drawing.Size(80, 17);
            this.rbtn_forca.TabIndex = 3;
            this.rbtn_forca.TabStop = true;
            this.rbtn_forca.Text = "Froça Bruta";
            this.rbtn_forca.UseVisualStyleBackColor = true;
            // 
            // rbtn_rabin
            // 
            this.rbtn_rabin.AutoSize = true;
            this.rbtn_rabin.Location = new System.Drawing.Point(15, 43);
            this.rbtn_rabin.Name = "rbtn_rabin";
            this.rbtn_rabin.Size = new System.Drawing.Size(78, 17);
            this.rbtn_rabin.TabIndex = 4;
            this.rbtn_rabin.TabStop = true;
            this.rbtn_rabin.Text = "Rabin-Karp";
            this.rbtn_rabin.UseVisualStyleBackColor = true;
            // 
            // rbtn_kmp
            // 
            this.rbtn_kmp.AutoSize = true;
            this.rbtn_kmp.Location = new System.Drawing.Point(15, 67);
            this.rbtn_kmp.Name = "rbtn_kmp";
            this.rbtn_kmp.Size = new System.Drawing.Size(48, 17);
            this.rbtn_kmp.TabIndex = 5;
            this.rbtn_kmp.TabStop = true;
            this.rbtn_kmp.Text = "KMP";
            this.rbtn_kmp.UseVisualStyleBackColor = true;
            // 
            // rbtn_boyer
            // 
            this.rbtn_boyer.AutoSize = true;
            this.rbtn_boyer.Location = new System.Drawing.Point(15, 91);
            this.rbtn_boyer.Name = "rbtn_boyer";
            this.rbtn_boyer.Size = new System.Drawing.Size(85, 17);
            this.rbtn_boyer.TabIndex = 6;
            this.rbtn_boyer.TabStop = true;
            this.rbtn_boyer.Text = "Boyer Moore";
            this.rbtn_boyer.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(437, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_substituir
            // 
            this.btn_substituir.Location = new System.Drawing.Point(437, 40);
            this.btn_substituir.Name = "btn_substituir";
            this.btn_substituir.Size = new System.Drawing.Size(75, 23);
            this.btn_substituir.TabIndex = 10;
            this.btn_substituir.Text = "Substituir";
            this.btn_substituir.UseVisualStyleBackColor = true;
            this.btn_substituir.Click += new System.EventHandler(this.btn_substituir_Click);
            // 
            // txtbox_substituir
            // 
            this.txtbox_substituir.Location = new System.Drawing.Point(89, 42);
            this.txtbox_substituir.Name = "txtbox_substituir";
            this.txtbox_substituir.Size = new System.Drawing.Size(342, 20);
            this.txtbox_substituir.TabIndex = 9;
            // 
            // lb_substituir
            // 
            this.lb_substituir.AutoSize = true;
            this.lb_substituir.Location = new System.Drawing.Point(12, 44);
            this.lb_substituir.Name = "lb_substituir";
            this.lb_substituir.Size = new System.Drawing.Size(71, 13);
            this.lb_substituir.TabIndex = 8;
            this.lb_substituir.Text = "Substituir por:";
            // 
            // groupBox_modos
            // 
            this.groupBox_modos.Controls.Add(this.rbtn_forca);
            this.groupBox_modos.Controls.Add(this.rbtn_rabin);
            this.groupBox_modos.Controls.Add(this.rbtn_kmp);
            this.groupBox_modos.Controls.Add(this.rbtn_boyer);
            this.groupBox_modos.Location = new System.Drawing.Point(12, 80);
            this.groupBox_modos.Name = "groupBox_modos";
            this.groupBox_modos.Size = new System.Drawing.Size(200, 113);
            this.groupBox_modos.TabIndex = 11;
            this.groupBox_modos.TabStop = false;
            this.groupBox_modos.Text = "Modo de Busca";
            // 
            // checkbox_case
            // 
            this.checkbox_case.AutoSize = true;
            this.checkbox_case.Location = new System.Drawing.Point(282, 99);
            this.checkbox_case.Name = "checkbox_case";
            this.checkbox_case.Size = new System.Drawing.Size(96, 17);
            this.checkbox_case.TabIndex = 12;
            this.checkbox_case.Text = "Case-Sensitive";
            this.checkbox_case.UseVisualStyleBackColor = true;
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 205);
            this.Controls.Add(this.checkbox_case);
            this.Controls.Add(this.groupBox_modos);
            this.Controls.Add(this.btn_substituir);
            this.Controls.Add(this.txtbox_substituir);
            this.Controls.Add(this.lb_substituir);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txtbox_pesquisar);
            this.Controls.Add(this.lb_localizar);
            this.Name = "Pesquisar";
            this.Text = "Pesquisar";
            this.groupBox_modos.ResumeLayout(false);
            this.groupBox_modos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_localizar;
        private System.Windows.Forms.TextBox txtbox_pesquisar;
        private System.Windows.Forms.RadioButton rbtn_forca;
        private System.Windows.Forms.RadioButton rbtn_rabin;
        private System.Windows.Forms.RadioButton rbtn_kmp;
        private System.Windows.Forms.RadioButton rbtn_boyer;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_substituir;
        private System.Windows.Forms.TextBox txtbox_substituir;
        private System.Windows.Forms.Label lb_substituir;
        private System.Windows.Forms.GroupBox groupBox_modos;
        private System.Windows.Forms.CheckBox checkbox_case;
    }
}