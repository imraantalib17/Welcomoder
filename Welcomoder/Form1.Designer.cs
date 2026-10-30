namespace Welcomoder;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        textBox1 = new TextBox();
        label1 = new Label();
        button1 = new Button();
        checkBox1 = new CheckBox();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new Point(12, 12);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(676, 27);
        textBox1.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(34, 71);
        label1.Name = "label1";
        label1.Size = new Size(371, 20);
        label1.TabIndex = 1;
        label1.Text = "Press the \"Go!\" button and the result will show up here!";
        // 
        // button1
        // 
        button1.Location = new Point(694, 10);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 2;
        button1.Text = "Go!";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(657, 71);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(131, 24);
        checkBox1.TabIndex = 3;
        checkBox1.Text = "Use dark mode";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(checkBox1);
        Controls.Add(button1);
        Controls.Add(label1);
        Controls.Add(textBox1);
        Name = "Form1";
        Text = "Welcomoder";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBox1;
    private Label label1;
    private Button button1;
    private CheckBox checkBox1;
}
