using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 48);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "DATO 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 93);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "DATO 2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(112, 155);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 4;
            button1.Text = "ACEPTAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(112, 204);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 5;
            button2.Text = "CALCULO";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmIngreso
            // 
            ClientSize = new Size(315, 261);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmIngreso";
            Text = "INGRESO Y MUESTRA DE DATOS";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
