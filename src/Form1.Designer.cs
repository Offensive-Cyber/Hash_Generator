
namespace HashCreator
{
    partial class FormMain
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
            this.Paraphrase = new System.Windows.Forms.TextBox();
            this.HashType = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Paraphrase
            // 
            this.Paraphrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Paraphrase.Location = new System.Drawing.Point(85, 100);
            this.Paraphrase.Name = "Paraphrase";
            this.Paraphrase.Size = new System.Drawing.Size(246, 22);
            this.Paraphrase.TabIndex = 0;
            this.Paraphrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HashType
            // 
            this.HashType.FormattingEnabled = true;
            this.HashType.Items.AddRange(new object[] {
            "MD5",
            "SHA-128",
            "SHA-256",
            "SHA-512"});
            this.HashType.Location = new System.Drawing.Point(149, 73);
            this.HashType.Name = "HashType";
            this.HashType.Size = new System.Drawing.Size(117, 21);
            this.HashType.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Start.FlatAppearance.BorderSize = 3;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Red;
            this.Start.Location = new System.Drawing.Point(85, 158);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(246, 84);
            this.Start.TabIndex = 2;
            this.Start.Text = "Hash it!";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(78, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hash Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Paraphrase:";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.Black;
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Result.ForeColor = System.Drawing.Color.Lime;
            this.Result.Location = new System.Drawing.Point(13, 248);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(395, 98);
            this.Result.TabIndex = 5;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(108, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Offensive_Cyber";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(419, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.HashType);
            this.Controls.Add(this.Paraphrase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.Text = "Hash_Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Paraphrase;
        private System.Windows.Forms.ComboBox HashType;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label3;
    }
}

