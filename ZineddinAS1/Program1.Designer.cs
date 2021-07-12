namespace ZineddinProgram1
{
    partial class Program1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeadActor = new System.Windows.Forms.Button();
            this.btnDirector = new System.Windows.Forms.Button();
            this.btnLeadActress = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(341, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titanic";
            // 
            // btnLeadActor
            // 
            this.btnLeadActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLeadActor.Location = new System.Drawing.Point(82, 102);
            this.btnLeadActor.Name = "btnLeadActor";
            this.btnLeadActor.Size = new System.Drawing.Size(122, 31);
            this.btnLeadActor.TabIndex = 1;
            this.btnLeadActor.Text = "Lead Actor";
            this.btnLeadActor.UseVisualStyleBackColor = true;
            this.btnLeadActor.Click += new System.EventHandler(this.btnLeadActor_Click);
            // 
            // btnDirector
            // 
            this.btnDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDirector.Location = new System.Drawing.Point(558, 102);
            this.btnDirector.Name = "btnDirector";
            this.btnDirector.Size = new System.Drawing.Size(122, 31);
            this.btnDirector.TabIndex = 2;
            this.btnDirector.Text = "Director";
            this.btnDirector.UseVisualStyleBackColor = true;
            this.btnDirector.Click += new System.EventHandler(this.btnDirector_Click);
            // 
            // btnLeadActress
            // 
            this.btnLeadActress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLeadActress.Location = new System.Drawing.Point(320, 102);
            this.btnLeadActress.Name = "btnLeadActress";
            this.btnLeadActress.Size = new System.Drawing.Size(122, 31);
            this.btnLeadActress.TabIndex = 3;
            this.btnLeadActress.Text = "Lead Actress";
            this.btnLeadActress.UseVisualStyleBackColor = true;
            this.btnLeadActress.Click += new System.EventHandler(this.btnLeadActress_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(82, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblResult.Location = new System.Drawing.Point(286, 205);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(195, 37);
            this.lblResult.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Developed by: Ahmad Z";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLeadActress);
            this.Controls.Add(this.btnDirector);
            this.Controls.Add(this.btnLeadActor);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Program1";
            this.Text = "Program1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeadActor;
        private System.Windows.Forms.Button btnDirector;
        private System.Windows.Forms.Button btnLeadActress;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
    }
}