namespace Evaluation_Manager
{
    partial class frmEvaluation
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
            this.lblActivities = new System.Windows.Forms.Label();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Location = new System.Drawing.Point(40, 66);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(105, 25);
            this.lblActivities.TabIndex = 0;
            this.lblActivities.Text = "Aktivnosti";
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(45, 116);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(257, 33);
            this.cboActivities.TabIndex = 1;
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(341, 116);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(166, 31);
            this.txtMinForSignature.TabIndex = 2;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(549, 116);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(166, 31);
            this.txtMinForGrade.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uvjet za potpis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uvjet za ocjenu";
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(45, 225);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(670, 340);
            this.txtActivityDescription.TabIndex = 6;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(154, 659);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(166, 31);
            this.txtTeacher.TabIndex = 7;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(362, 659);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.ReadOnly = true;
            this.txtEvaluationDate.Size = new System.Drawing.Size(172, 31);
            this.txtEvaluationDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ocjenjivač";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum evaluacije";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 613);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bodovi";
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(584, 659);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(120, 31);
            this.numPoints.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(432, 736);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 48);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(587, 736);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 48);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 842);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.lblActivities);
            this.Name = "frmEvaluation";
            this.Text = "frmEvaluation";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}