namespace GrapqhlForms {
  partial class Form1 {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 12);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(256, 425);
      this.textBox1.TabIndex = 0;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(274, 12);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(259, 179);
      this.textBox2.TabIndex = 1;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(274, 197);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(259, 240);
      this.textBox3.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(545, 449);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
  }
}

