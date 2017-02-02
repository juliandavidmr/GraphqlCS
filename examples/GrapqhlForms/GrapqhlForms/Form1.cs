using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrapqhlForms {
  public partial class Form1 : Form {

    GraphqlCS ghl = new GraphqlCS();

    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
      String input = textBox1.Text.ToString();

      textBox3.Text = ghl.toSQL(input);
    }
  }
}
