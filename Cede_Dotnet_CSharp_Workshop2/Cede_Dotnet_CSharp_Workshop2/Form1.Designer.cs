namespace Cede_Dotnet_CSharp_Workshop2
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grdPersons = new System.Windows.Forms.DataGridView();
            this.lblname = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.btnTranformJson = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(334, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 2;
            // 
            // grdPersons
            // 
            this.grdPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersons.Location = new System.Drawing.Point(36, 95);
            this.grdPersons.Name = "grdPersons";
            this.grdPersons.Size = new System.Drawing.Size(373, 171);
            this.grdPersons.TabIndex = 3;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(172, 30);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 13);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Nombre";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(36, 30);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 5;
            this.lblCedula.Text = "Cedula";
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(485, 95);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(356, 171);
            this.txtJson.TabIndex = 6;
            // 
            // btnTranformJson
            // 
            this.btnTranformJson.Location = new System.Drawing.Point(485, 46);
            this.btnTranformJson.Name = "btnTranformJson";
            this.btnTranformJson.Size = new System.Drawing.Size(134, 23);
            this.btnTranformJson.TabIndex = 7;
            this.btnTranformJson.Text = "Transformar a Json";
            this.btnTranformJson.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(36, 287);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 403);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnTranformJson);
            this.Controls.Add(this.txtJson);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.grdPersons);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView grdPersons;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.Button btnTranformJson;
        private System.Windows.Forms.Label lblMessage;
    }
}

