namespace DigitCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Reset = new System.Windows.Forms.Button();
            this.Digit4 = new System.Windows.Forms.TextBox();
            this.Digit3 = new System.Windows.Forms.TextBox();
            this.Digit2 = new System.Windows.Forms.TextBox();
            this.Digit1 = new System.Windows.Forms.TextBox();
            this.Digit4Add = new System.Windows.Forms.Button();
            this.Digit3Add = new System.Windows.Forms.Button();
            this.Digit2Add = new System.Windows.Forms.Button();
            this.Digit1Add = new System.Windows.Forms.Button();
            this.Cardinal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(271, 56);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(153, 52);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Digit4
            // 
            this.Digit4.Location = new System.Drawing.Point(29, 25);
            this.Digit4.Name = "Digit4";
            this.Digit4.ReadOnly = true;
            this.Digit4.Size = new System.Drawing.Size(51, 25);
            this.Digit4.TabIndex = 1;
            this.Digit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Digit3
            // 
            this.Digit3.Location = new System.Drawing.Point(86, 25);
            this.Digit3.Name = "Digit3";
            this.Digit3.ReadOnly = true;
            this.Digit3.Size = new System.Drawing.Size(51, 25);
            this.Digit3.TabIndex = 2;
            this.Digit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Digit2
            // 
            this.Digit2.Location = new System.Drawing.Point(143, 25);
            this.Digit2.Name = "Digit2";
            this.Digit2.ReadOnly = true;
            this.Digit2.Size = new System.Drawing.Size(51, 25);
            this.Digit2.TabIndex = 3;
            this.Digit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Digit1
            // 
            this.Digit1.Location = new System.Drawing.Point(200, 25);
            this.Digit1.Name = "Digit1";
            this.Digit1.ReadOnly = true;
            this.Digit1.Size = new System.Drawing.Size(51, 25);
            this.Digit1.TabIndex = 4;
            this.Digit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Digit4Add
            // 
            this.Digit4Add.Location = new System.Drawing.Point(29, 56);
            this.Digit4Add.Name = "Digit4Add";
            this.Digit4Add.Size = new System.Drawing.Size(52, 26);
            this.Digit4Add.TabIndex = 5;
            this.Digit4Add.Text = "+";
            this.Digit4Add.UseVisualStyleBackColor = true;
            this.Digit4Add.Click += new System.EventHandler(this.Digit4Add_Click);
            // 
            // Digit3Add
            // 
            this.Digit3Add.Location = new System.Drawing.Point(87, 56);
            this.Digit3Add.Name = "Digit3Add";
            this.Digit3Add.Size = new System.Drawing.Size(52, 26);
            this.Digit3Add.TabIndex = 6;
            this.Digit3Add.Text = "+";
            this.Digit3Add.UseVisualStyleBackColor = true;
            this.Digit3Add.Click += new System.EventHandler(this.Digit3Add_Click);
            // 
            // Digit2Add
            // 
            this.Digit2Add.Location = new System.Drawing.Point(142, 56);
            this.Digit2Add.Name = "Digit2Add";
            this.Digit2Add.Size = new System.Drawing.Size(52, 26);
            this.Digit2Add.TabIndex = 7;
            this.Digit2Add.Text = "+";
            this.Digit2Add.UseVisualStyleBackColor = true;
            this.Digit2Add.Click += new System.EventHandler(this.Digit2Add_Click);
            // 
            // Digit1Add
            // 
            this.Digit1Add.Location = new System.Drawing.Point(200, 56);
            this.Digit1Add.Name = "Digit1Add";
            this.Digit1Add.Size = new System.Drawing.Size(52, 26);
            this.Digit1Add.TabIndex = 8;
            this.Digit1Add.Text = "+";
            this.Digit1Add.UseVisualStyleBackColor = true;
            this.Digit1Add.Click += new System.EventHandler(this.Digit1Add_Click);
            // 
            // Cardinal
            // 
            this.Cardinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cardinal.FormattingEnabled = true;
            this.Cardinal.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2"});
            this.Cardinal.Location = new System.Drawing.Point(271, 24);
            this.Cardinal.Name = "Cardinal";
            this.Cardinal.Size = new System.Drawing.Size(83, 26);
            this.Cardinal.TabIndex = 9;
            this.Cardinal.SelectedIndexChanged += new System.EventHandler(this.Cardinal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "進数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cardinal);
            this.Controls.Add(this.Digit1Add);
            this.Controls.Add(this.Digit2Add);
            this.Controls.Add(this.Digit3Add);
            this.Controls.Add(this.Digit4Add);
            this.Controls.Add(this.Digit1);
            this.Controls.Add(this.Digit2);
            this.Controls.Add(this.Digit3);
            this.Controls.Add(this.Digit4);
            this.Controls.Add(this.Reset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox Digit4;
        private System.Windows.Forms.TextBox Digit3;
        private System.Windows.Forms.TextBox Digit2;
        private System.Windows.Forms.TextBox Digit1;
        private System.Windows.Forms.Button Digit4Add;
        private System.Windows.Forms.Button Digit3Add;
        private System.Windows.Forms.Button Digit2Add;
        private System.Windows.Forms.Button Digit1Add;
        private System.Windows.Forms.ComboBox Cardinal;
        private System.Windows.Forms.Label label1;
    }
}

