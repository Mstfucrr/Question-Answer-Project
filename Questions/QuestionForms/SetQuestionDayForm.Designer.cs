namespace Question_Answer.Questions.QuestionForms
{
    partial class SetQuestionDayForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_DaysUpdate = new System.Windows.Forms.Button();
            this.textUpdate = new System.Windows.Forms.TextBox();
            this.textAdd = new System.Windows.Forms.TextBox();
            this.btn_DaysAdd = new System.Windows.Forms.Button();
            this.btn_dayUpdate = new System.Windows.Forms.Button();
            this.btn_dayDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "4",
            "5",
            "6",
            "6",
            "4",
            "1234",
            "as",
            "d",
            "asd"});
            this.listBox1.Location = new System.Drawing.Point(45, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(113, 202);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_DaysUpdate
            // 
            this.btn_DaysUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DaysUpdate.Location = new System.Drawing.Point(45, 236);
            this.btn_DaysUpdate.Name = "btn_DaysUpdate";
            this.btn_DaysUpdate.Size = new System.Drawing.Size(115, 30);
            this.btn_DaysUpdate.TabIndex = 1;
            this.btn_DaysUpdate.Text = "Güncelle";
            this.btn_DaysUpdate.UseVisualStyleBackColor = true;
            this.btn_DaysUpdate.Click += new System.EventHandler(this.btn_DaysUpdate_Click);
            // 
            // textUpdate
            // 
            this.textUpdate.Enabled = false;
            this.textUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textUpdate.Location = new System.Drawing.Point(198, 161);
            this.textUpdate.Name = "textUpdate";
            this.textUpdate.Size = new System.Drawing.Size(161, 29);
            this.textUpdate.TabIndex = 2;
            // 
            // textAdd
            // 
            this.textAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAdd.Location = new System.Drawing.Point(198, 28);
            this.textAdd.Name = "textAdd";
            this.textAdd.Size = new System.Drawing.Size(161, 29);
            this.textAdd.TabIndex = 4;
            // 
            // btn_DaysAdd
            // 
            this.btn_DaysAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DaysAdd.Location = new System.Drawing.Point(221, 75);
            this.btn_DaysAdd.Name = "btn_DaysAdd";
            this.btn_DaysAdd.Size = new System.Drawing.Size(115, 30);
            this.btn_DaysAdd.TabIndex = 3;
            this.btn_DaysAdd.Text = "Ekle";
            this.btn_DaysAdd.UseVisualStyleBackColor = true;
            this.btn_DaysAdd.Click += new System.EventHandler(this.btn_DaysAdd_Click);
            // 
            // btn_dayUpdate
            // 
            this.btn_dayUpdate.Enabled = false;
            this.btn_dayUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dayUpdate.Location = new System.Drawing.Point(173, 196);
            this.btn_dayUpdate.Name = "btn_dayUpdate";
            this.btn_dayUpdate.Size = new System.Drawing.Size(115, 34);
            this.btn_dayUpdate.TabIndex = 5;
            this.btn_dayUpdate.Text = "Süreyi değiştir";
            this.btn_dayUpdate.UseVisualStyleBackColor = true;
            this.btn_dayUpdate.Click += new System.EventHandler(this.btn_dayUpdate_Click);
            // 
            // btn_dayDelete
            // 
            this.btn_dayDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dayDelete.Location = new System.Drawing.Point(294, 198);
            this.btn_dayDelete.Name = "btn_dayDelete";
            this.btn_dayDelete.Size = new System.Drawing.Size(88, 30);
            this.btn_dayDelete.TabIndex = 6;
            this.btn_dayDelete.Text = "Sil";
            this.btn_dayDelete.UseVisualStyleBackColor = true;
            this.btn_dayDelete.Click += new System.EventHandler(this.btn_dayDelete_Click);
            // 
            // SetQuestionDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 302);
            this.Controls.Add(this.btn_dayDelete);
            this.Controls.Add(this.btn_dayUpdate);
            this.Controls.Add(this.textAdd);
            this.Controls.Add(this.btn_DaysAdd);
            this.Controls.Add(this.textUpdate);
            this.Controls.Add(this.btn_DaysUpdate);
            this.Controls.Add(this.listBox1);
            this.Name = "SetQuestionDayForm";
            this.Text = "SetQuestionDayForm";
            this.Load += new System.EventHandler(this.SetQuestionDayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_DaysUpdate;
        private System.Windows.Forms.TextBox textUpdate;
        private System.Windows.Forms.TextBox textAdd;
        private System.Windows.Forms.Button btn_DaysAdd;
        private System.Windows.Forms.Button btn_dayUpdate;
        private System.Windows.Forms.Button btn_dayDelete;
    }
}