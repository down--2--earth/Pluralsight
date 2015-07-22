namespace GenerateLessonPlan
{
    partial class frmGenerateLessonPlan
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
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.lessonTime = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lessonPlan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.CustomFormat = "dd/MMMM/yyyy";
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(12, 37);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(234, 26);
            this.startDate.TabIndex = 0;
            // 
            // lessonTime
            // 
            this.lessonTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.lessonTime.Location = new System.Drawing.Point(278, 35);
            this.lessonTime.Name = "lessonTime";
            this.lessonTime.Size = new System.Drawing.Size(200, 26);
            this.lessonTime.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(494, 35);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(112, 34);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lessonPlan
            // 
            this.lessonPlan.Location = new System.Drawing.Point(5, 85);
            this.lessonPlan.Multiline = true;
            this.lessonPlan.Name = "lessonPlan";
            this.lessonPlan.Size = new System.Drawing.Size(611, 231);
            this.lessonPlan.TabIndex = 3;
            // 
            // frmGenerateLessonPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 328);
            this.Controls.Add(this.lessonPlan);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lessonTime);
            this.Controls.Add(this.startDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerateLessonPlan";
            this.Text = "Generate Lesson Plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker lessonTime;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox lessonPlan;
    }
}

