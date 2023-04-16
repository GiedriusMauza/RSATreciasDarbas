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
            boxTextValue = new RichTextBox();
            btnDecypt = new Button();
            btnEncypt = new Button();
            label1 = new Label();
            label2 = new Label();
            boxOutputValue = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            boxPublicKey = new RichTextBox();
            btnGenerate = new Button();
            label5 = new Label();
            boxPrivateKey = new RichTextBox();
            SuspendLayout();
            // 
            // boxTextValue
            // 
            boxTextValue.Location = new Point(67, 15);
            boxTextValue.Name = "boxTextValue";
            boxTextValue.Size = new Size(480, 291);
            boxTextValue.TabIndex = 2;
            boxTextValue.Text = "";
            // 
            // btnDecypt
            // 
            btnDecypt.Location = new Point(472, 312);
            btnDecypt.Name = "btnDecypt";
            btnDecypt.Size = new Size(75, 23);
            btnDecypt.TabIndex = 3;
            btnDecypt.Text = "Decrypt";
            btnDecypt.UseVisualStyleBackColor = true;
            btnDecypt.Click += btnDecypt_Click;
            // 
            // btnEncypt
            // 
            btnEncypt.Location = new Point(67, 312);
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
            label1.Location = new Point(602, 122);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 5;
            label1.Text = "Private Key Field";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 15);
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
            label4.Location = new Point(-1, 445);
            label4.Name = "label4";
            label4.Size = new Size(1277, 15);
            label4.TabIndex = 9;
            label4.Text = resources.GetString("label4.Text");
            // 
            // boxPublicKey
            // 
            boxPublicKey.Location = new Point(701, 12);
            boxPublicKey.Name = "boxPublicKey";
            boxPublicKey.Size = new Size(480, 101);
            boxPublicKey.TabIndex = 10;
            boxPublicKey.Text = "";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(701, 421);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate Keys";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(605, 15);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 12;
            label5.Text = "Public Key Field";
            // 
            // boxPrivateKey
            // 
            boxPrivateKey.Location = new Point(701, 119);
            boxPrivateKey.Name = "boxPrivateKey";
            boxPrivateKey.Size = new Size(480, 296);
            boxPrivateKey.TabIndex = 1;
            boxPrivateKey.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 725);
            Controls.Add(label5);
            Controls.Add(btnGenerate);
            Controls.Add(boxPublicKey);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(boxOutputValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEncypt);
            Controls.Add(btnDecypt);
            Controls.Add(boxTextValue);
            Controls.Add(boxPrivateKey);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "RSA Encyption Application";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox boxTextValue;
        private Button btnDecypt;
        private Button btnEncypt;
        private Label label1;
        private Label label2;
        private RichTextBox boxOutputValue;
        private Label label3;
        private Label label4;
        private RichTextBox boxPublicKey;
        private Button btnGenerate;
        private Label label5;
        private RichTextBox boxPrivateKey;
    }
}