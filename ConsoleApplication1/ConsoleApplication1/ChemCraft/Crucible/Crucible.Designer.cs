namespace ChemCraft
{
    partial class Crucible
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxNewComp = new System.Windows.Forms.ComboBox();
            this.comboBoxComp = new System.Windows.Forms.ComboBox();
            this.buttonDestroy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNewComp = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxComp = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxElements = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(46, 144);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Synthesize";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxNewComp
            // 
            this.comboBoxNewComp.FormattingEnabled = true;
            this.comboBoxNewComp.Location = new System.Drawing.Point(12, 46);
            this.comboBoxNewComp.Name = "comboBoxNewComp";
            this.comboBoxNewComp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNewComp.TabIndex = 1;
            this.comboBoxNewComp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxComp
            // 
            this.comboBoxComp.FormattingEnabled = true;
            this.comboBoxComp.Location = new System.Drawing.Point(151, 46);
            this.comboBoxComp.Name = "comboBoxComp";
            this.comboBoxComp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComp.TabIndex = 2;
            this.comboBoxComp.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonDestroy
            // 
            this.buttonDestroy.Location = new System.Drawing.Point(171, 144);
            this.buttonDestroy.Name = "buttonDestroy";
            this.buttonDestroy.Size = new System.Drawing.Size(75, 23);
            this.buttonDestroy.TabIndex = 3;
            this.buttonDestroy.Text = "Decompose";
            this.buttonDestroy.UseVisualStyleBackColor = true;
            this.buttonDestroy.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chemical Formula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chemical Formula";
            // 
            // TextBoxNewComp
            // 
            this.TextBoxNewComp.Enabled = false;
            this.TextBoxNewComp.Location = new System.Drawing.Point(29, 118);
            this.TextBoxNewComp.Name = "TextBoxNewComp";
            this.TextBoxNewComp.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNewComp.TabIndex = 6;
            this.TextBoxNewComp.Text = "ERROR";
            // 
            // TextBoxComp
            // 
            this.TextBoxComp.Enabled = false;
            this.TextBoxComp.Location = new System.Drawing.Point(159, 118);
            this.TextBoxComp.Name = "TextBoxComp";
            this.TextBoxComp.Size = new System.Drawing.Size(100, 20);
            this.TextBoxComp.TabIndex = 7;
            this.TextBoxComp.Text = "ERROR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Possible Compounds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your Compounds";
            // 
            // comboBoxElements
            // 
            this.comboBoxElements.FormattingEnabled = true;
            this.comboBoxElements.Location = new System.Drawing.Point(278, 46);
            this.comboBoxElements.Name = "comboBoxElements";
            this.comboBoxElements.Size = new System.Drawing.Size(121, 21);
            this.comboBoxElements.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Your Elements";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(171, 202);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 14;
            this.buttonFinish.Text = "Close";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // Crucible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 249);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxElements);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxComp);
            this.Controls.Add(this.TextBoxNewComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDestroy);
            this.Controls.Add(this.comboBoxComp);
            this.Controls.Add(this.comboBoxNewComp);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Crucible";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxNewComp;
        private System.Windows.Forms.ComboBox comboBoxComp;
        private System.Windows.Forms.Button buttonDestroy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TextBoxNewComp;
        private System.Windows.Forms.MaskedTextBox TextBoxComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxElements;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFinish;
    }
}

