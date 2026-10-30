using System;
using System.Drawing;
using System.Windows.Forms;

namespace Welcomoder;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // 1. Lowercase 'b' method to satisfy line 50 of your designer file
    private void button1_Click(object sender, EventArgs e)
    {
        string userName = textBox1.Text;

        if (!string.IsNullOrWhiteSpace(userName))
        {
            label1.Text = $"Hello, {userName}! Welcome to Welcomoder.";
        }
        else
        {
            label1.Text = "Please enter your name first!";
        }
    }

    // 2. Capital 'B' method just in case the link flips back
    private void Button1_Click(object sender, EventArgs e)
    {
        button1_Click(sender, e);
    }

    // 3. Form_Load method to satisfy line 74 of your designer file
    private void Form1_Load(object sender, EventArgs e)
    {
        // Keeps it empty so it safely executes nothing on startup
    }

    // 4. Handles your Dark Mode color conversions flawlessly
    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked)
        {
            this.BackColor = Color.FromArgb(32, 32, 32);
            this.ForeColor = Color.White;

            textBox1.BackColor = Color.FromArgb(45, 45, 45);
            textBox1.ForeColor = Color.White;

            button1.BackColor = Color.FromArgb(60, 60, 60);
            button1.ForeColor = Color.White;
        }
        else
        {
            this.BackColor = SystemColors.Control;
            this.ForeColor = SystemColors.ControlText;

            textBox1.BackColor = SystemColors.Window;
            textBox1.ForeColor = SystemColors.WindowText;

            button1.BackColor = SystemColors.ControlLight;
            button1.ForeColor = SystemColors.ControlText;
        }
    }
}
