﻿namespace laba3_29
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.масивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одномірніМасивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двовимірніМасивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масивиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // масивиToolStripMenuItem
            // 
            this.масивиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одномірніМасивиToolStripMenuItem,
            this.двовимірніМасивиToolStripMenuItem});
            this.масивиToolStripMenuItem.Name = "масивиToolStripMenuItem";
            this.масивиToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.масивиToolStripMenuItem.Text = "Масиви";
            // 
            // одномірніМасивиToolStripMenuItem
            // 
            this.одномірніМасивиToolStripMenuItem.Name = "одномірніМасивиToolStripMenuItem";
            this.одномірніМасивиToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.одномірніМасивиToolStripMenuItem.Text = "Одномірні масиви";
            this.одномірніМасивиToolStripMenuItem.Click += new System.EventHandler(this.одномірніМасивиToolStripMenuItem_Click);
            // 
            // двовимірніМасивиToolStripMenuItem
            // 
            this.двовимірніМасивиToolStripMenuItem.Name = "двовимірніМасивиToolStripMenuItem";
            this.двовимірніМасивиToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.двовимірніМасивиToolStripMenuItem.Text = "Двовимірні масиви";
            this.двовимірніМасивиToolStripMenuItem.Click += new System.EventHandler(this.двовимірніМасивиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem масивиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одномірніМасивиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двовимірніМасивиToolStripMenuItem;
    }
}

