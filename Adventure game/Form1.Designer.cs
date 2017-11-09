namespace Adventure_game
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.debugLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(438, 207);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "you are a bear what do you want to do go to river or the woods";
            // 
            // label1
            // 
            this.label1.Image = global::Adventure_game.Properties.Resources.blue_50x50;
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 62);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Image = global::Adventure_game.Properties.Resources.red_50x50;
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 62);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Image = global::Adventure_game.Properties.Resources.green_50x50;
            this.label3.Location = new System.Drawing.Point(185, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 62);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Image = global::Adventure_game.Properties.Resources.yellow_50x50;
            this.label4.Location = new System.Drawing.Point(185, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 62);
            this.label4.TabIndex = 4;
            // 
            // blueLabel
            // 
            this.blueLabel.Location = new System.Drawing.Point(94, 216);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(85, 62);
            this.blueLabel.TabIndex = 5;
            this.blueLabel.Text = "woods B";
            // 
            // redLabel
            // 
            this.redLabel.Location = new System.Drawing.Point(93, 308);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(85, 62);
            this.redLabel.TabIndex = 6;
            this.redLabel.Text = "river M";
            // 
            // greenLabel
            // 
            this.greenLabel.Location = new System.Drawing.Point(266, 216);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(85, 62);
            this.greenLabel.TabIndex = 7;
            // 
            // yellowLabel
            // 
            this.yellowLabel.Location = new System.Drawing.Point(266, 308);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(85, 62);
            this.yellowLabel.TabIndex = 8;
            // 
            // debugLabel
            // 
            this.debugLabel.ForeColor = System.Drawing.Color.Red;
            this.debugLabel.Location = new System.Drawing.Point(370, 347);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(100, 23);
            this.debugLabel.TabIndex = 9;
            this.debugLabel.Text = "0";
            this.debugLabel.Visible = false;
            // 
            // dayLabel
            // 
            this.dayLabel.ForeColor = System.Drawing.Color.Red;
            this.dayLabel.Location = new System.Drawing.Point(14, 193);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(100, 23);
            this.dayLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 379);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Label dayLabel;
    }
}

