namespace RSATreciasDarbas
{
    partial class Form2
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
            textBoxP = new TextBox();
            textBoxQ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonEncrypt = new Button();
            textBoxOutput = new RichTextBox();
            label3 = new Label();
            textBoxInput = new RichTextBox();
            label4 = new Label();
            buttonDecrypt = new Button();
            textBoxDecrypted = new TextBox();
            buttonSaveFile = new Button();
            buttonRead = new Button();
            textPrivateKey = new TextBox();
            SuspendLayout();
            // 
            // textBoxP
            // 
            textBoxP.Location = new Point(82, 7);
            textBoxP.Name = "textBoxP";
            textBoxP.Size = new Size(708, 23);
            textBoxP.TabIndex = 0;
            // 
            // textBoxQ
            // 
            textBoxQ.Location = new Point(82, 43);
            textBoxQ.Name = "textBoxQ";
            textBoxQ.Size = new Size(708, 23);
            textBoxQ.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Value of P:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Value of Q:";
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new Point(82, 220);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(247, 23);
            buttonEncrypt.TabIndex = 4;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(82, 258);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(708, 180);
            textBoxOutput.TabIndex = 5;
            textBoxOutput.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 258);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Output:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(82, 72);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(708, 142);
            textBoxInput.TabIndex = 7;
            textBoxInput.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 8;
            label4.Text = "Text:";
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Location = new Point(1072, 41);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(229, 23);
            buttonDecrypt.TabIndex = 9;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // textBoxDecrypted
            // 
            textBoxDecrypted.Location = new Point(1072, 12);
            textBoxDecrypted.Name = "textBoxDecrypted";
            textBoxDecrypted.Size = new Size(229, 23);
            textBoxDecrypted.TabIndex = 10;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Location = new Point(1120, 408);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(75, 23);
            buttonSaveFile.TabIndex = 11;
            buttonSaveFile.Text = "Save To File";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(1201, 408);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(100, 23);
            buttonRead.TabIndex = 12;
            buttonRead.Text = "Read from File";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // textPrivateKey
            // 
            textPrivateKey.Location = new Point(814, 409);
            textPrivateKey.Name = "textPrivateKey";
            textPrivateKey.Size = new Size(100, 23);
            textPrivateKey.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 443);
            Controls.Add(textPrivateKey);
            Controls.Add(buttonRead);
            Controls.Add(buttonSaveFile);
            Controls.Add(textBoxDecrypted);
            Controls.Add(buttonDecrypt);
            Controls.Add(label4);
            Controls.Add(textBoxInput);
            Controls.Add(label3);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonEncrypt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxQ);
            Controls.Add(textBoxP);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private TextBox textBoxP;
        private TextBox textBoxQ;
        private Label label1;
        private Label label2;
        private Button buttonEncrypt;
        private RichTextBox textBoxOutput;
        private Label label3;
        private RichTextBox textBoxInput;
        private Label label4;
        private Button buttonDecrypt;
        private TextBox textBoxDecrypted;
        private Button buttonSaveFile;
        private Button buttonRead;
        private TextBox textPrivateKey;
    }
}