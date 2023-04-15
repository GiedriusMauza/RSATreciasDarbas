namespace RSATreciasDarbas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            boxKeyValue = new RichTextBox();
            boxTextValue = new RichTextBox();
            btnDecypt = new Button();
            btnEncypt = new Button();
            label1 = new Label();
            label2 = new Label();
            boxOutputValue = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // boxKeyValue
            // 
            boxKeyValue.Location = new Point(68, 12);
            boxKeyValue.Name = "boxKeyValue";
            boxKeyValue.Size = new Size(412, 101);
            boxKeyValue.TabIndex = 1;
            boxKeyValue.Text = "";
            // 
            // boxTextValue
            // 
            boxTextValue.Location = new Point(68, 119);
            boxTextValue.Name = "boxTextValue";
            boxTextValue.Size = new Size(412, 123);
            boxTextValue.TabIndex = 2;
            boxTextValue.Text = "";
            // 
            // btnDecypt
            // 
            btnDecypt.Location = new Point(405, 248);
            btnDecypt.Name = "btnDecypt";
            btnDecypt.Size = new Size(75, 23);
            btnDecypt.TabIndex = 3;
            btnDecypt.Text = "Decrypt";
            btnDecypt.UseVisualStyleBackColor = true;
            btnDecypt.Click += btnDecypt_Click;
            // 
            // btnEncypt
            // 
            btnEncypt.Location = new Point(68, 248);
            btnEncypt.Name = "btnEncypt";
            btnEncypt.Size = new Size(75, 23);
            btnEncypt.TabIndex = 4;
            btnEncypt.Text = "Encrypt";
            btnEncypt.UseVisualStyleBackColor = true;
            btnEncypt.Click += btnEncypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Key Field";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 119);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Text Field";
            // 
            // boxOutputValue
            // 
            boxOutputValue.Location = new Point(553, 463);
            boxOutputValue.Name = "boxOutputValue";
            boxOutputValue.Size = new Size(709, 250);
            boxOutputValue.TabIndex = 7;
            boxOutputValue.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 463);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Output";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-2, 357);
            label4.Name = "label4";
            label4.Size = new Size(1277, 15);
            label4.TabIndex = 9;
            label4.Text = resources.GetString("label4.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 725);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(boxOutputValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEncypt);
            Controls.Add(btnDecypt);
            Controls.Add(boxTextValue);
            Controls.Add(boxKeyValue);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "RSA Encyption Application";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox boxKeyValue;
        private RichTextBox boxTextValue;
        private Button btnDecypt;
        private Button btnEncypt;
        private Label label1;
        private Label label2;
        private RichTextBox boxOutputValue;
        private Label label3;
        private Label label4;
    }
}