namespace Habits
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.ResButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.UndoneButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 519);
            this.panel1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Location = new System.Drawing.Point(0, 283);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(607, 283);
            this.listBox2.TabIndex = 1;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            this.listBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox2_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "Habits";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(607, 283);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Habits";
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // CompleteButton
            // 
            this.CompleteButton.AutoSize = true;
            this.CompleteButton.Location = new System.Drawing.Point(634, 26);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(95, 43);
            this.CompleteButton.TabIndex = 3;
            this.CompleteButton.Text = "Complete";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // ResButton
            // 
            this.ResButton.AutoSize = true;
            this.ResButton.Location = new System.Drawing.Point(634, 149);
            this.ResButton.Name = "ResButton";
            this.ResButton.Size = new System.Drawing.Size(95, 43);
            this.ResButton.TabIndex = 4;
            this.ResButton.Text = "Reset";
            this.ResButton.UseVisualStyleBackColor = true;
            this.ResButton.Click += new System.EventHandler(this.ResButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(634, 326);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(95, 32);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(624, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(634, 364);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(95, 32);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // UndoneButton
            // 
            this.UndoneButton.Location = new System.Drawing.Point(634, 87);
            this.UndoneButton.Name = "UndoneButton";
            this.UndoneButton.Size = new System.Drawing.Size(95, 43);
            this.UndoneButton.TabIndex = 7;
            this.UndoneButton.Text = "Undone";
            this.UndoneButton.UseVisualStyleBackColor = true;
            this.UndoneButton.Click += new System.EventHandler(this.UndoneButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 519);
            this.Controls.Add(this.UndoneButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CompleteButton);
            this.Controls.Add(this.ResButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Habits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.Button ResButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button UndoneButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

