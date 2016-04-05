namespace FoodPlanner.WinClients
{
    partial class Form1
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
            this.btnGetDishes = new System.Windows.Forms.Button();
            this.lstDishes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetDishes
            // 
            this.btnGetDishes.Location = new System.Drawing.Point(108, 192);
            this.btnGetDishes.Name = "btnGetDishes";
            this.btnGetDishes.Size = new System.Drawing.Size(75, 23);
            this.btnGetDishes.TabIndex = 0;
            this.btnGetDishes.Text = "Find";
            this.btnGetDishes.UseVisualStyleBackColor = true;
            this.btnGetDishes.Click += new System.EventHandler(this.btnGetDishes_Click);
            // 
            // lstDishes
            // 
            this.lstDishes.FormattingEnabled = true;
            this.lstDishes.Location = new System.Drawing.Point(0, 0);
            this.lstDishes.Name = "lstDishes";
            this.lstDishes.Size = new System.Drawing.Size(286, 186);
            this.lstDishes.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstDishes);
            this.Controls.Add(this.btnGetDishes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetDishes;
        private System.Windows.Forms.ListBox lstDishes;
    }
}

