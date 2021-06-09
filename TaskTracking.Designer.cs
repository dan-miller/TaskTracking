
namespace TaskTracking
{
    partial class TaskTracking
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
            this.b_Start = new System.Windows.Forms.Button();
            this.b_Stop = new System.Windows.Forms.Button();
            this.l_Time = new System.Windows.Forms.Label();
            this.c_TaskSelection = new System.Windows.Forms.ComboBox();
            this.l_WriteSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_Start
            // 
            this.b_Start.Location = new System.Drawing.Point(33, 143);
            this.b_Start.Name = "b_Start";
            this.b_Start.Size = new System.Drawing.Size(75, 23);
            this.b_Start.TabIndex = 0;
            this.b_Start.Text = "Start";
            this.b_Start.UseVisualStyleBackColor = true;
            this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
            // 
            // b_Stop
            // 
            this.b_Stop.Location = new System.Drawing.Point(119, 143);
            this.b_Stop.Name = "b_Stop";
            this.b_Stop.Size = new System.Drawing.Size(75, 23);
            this.b_Stop.TabIndex = 1;
            this.b_Stop.Text = "Stop";
            this.b_Stop.UseVisualStyleBackColor = true;
            this.b_Stop.Click += new System.EventHandler(this.b_Stop_Click);
            // 
            // l_Time
            // 
            this.l_Time.AutoSize = true;
            this.l_Time.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_Time.Location = new System.Drawing.Point(33, 26);
            this.l_Time.Name = "l_Time";
            this.l_Time.Size = new System.Drawing.Size(161, 32);
            this.l_Time.TabIndex = 2;
            this.l_Time.Text = "00:00:00.000";
            // 
            // c_TaskSelection
            // 
            this.c_TaskSelection.FormattingEnabled = true;
            this.c_TaskSelection.Location = new System.Drawing.Point(33, 98);
            this.c_TaskSelection.Name = "c_TaskSelection";
            this.c_TaskSelection.Size = new System.Drawing.Size(161, 23);
            this.c_TaskSelection.TabIndex = 3;
            // 
            // l_WriteSuccess
            // 
            this.l_WriteSuccess.AutoSize = true;
            this.l_WriteSuccess.Location = new System.Drawing.Point(33, 80);
            this.l_WriteSuccess.Name = "l_WriteSuccess";
            this.l_WriteSuccess.Size = new System.Drawing.Size(0, 15);
            this.l_WriteSuccess.TabIndex = 4;
            // 
            // TaskTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 181);
            this.Controls.Add(this.l_WriteSuccess);
            this.Controls.Add(this.c_TaskSelection);
            this.Controls.Add(this.l_Time);
            this.Controls.Add(this.b_Stop);
            this.Controls.Add(this.b_Start);
            this.KeyPreview = true;
            this.Name = "TaskTracking";
            this.Text = "Task Tracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Start;
        private System.Windows.Forms.Button b_Stop;
        private System.Windows.Forms.Label l_Time;
        private System.Windows.Forms.ComboBox c_TaskSelection;
        private System.Windows.Forms.Label l_WriteSuccess;
    }
}

