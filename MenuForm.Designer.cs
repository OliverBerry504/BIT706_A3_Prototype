﻿
namespace BIT706_A3_OliverBerry
{
    partial class MenuForm
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
            this.btn_mng_cst = new System.Windows.Forms.Button();
            this.btn_mng_accs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mng_cst
            // 
            this.btn_mng_cst.Location = new System.Drawing.Point(48, 55);
            this.btn_mng_cst.Name = "btn_mng_cst";
            this.btn_mng_cst.Size = new System.Drawing.Size(144, 23);
            this.btn_mng_cst.TabIndex = 0;
            this.btn_mng_cst.Text = "Manage Customers";
            this.btn_mng_cst.UseVisualStyleBackColor = true;
            this.btn_mng_cst.Click += new System.EventHandler(this.Btn_mng_cst_Click);
            // 
            // btn_mng_accs
            // 
            this.btn_mng_accs.Location = new System.Drawing.Point(48, 84);
            this.btn_mng_accs.Name = "btn_mng_accs";
            this.btn_mng_accs.Size = new System.Drawing.Size(144, 23);
            this.btn_mng_accs.TabIndex = 1;
            this.btn_mng_accs.Text = "Manage Accounts";
            this.btn_mng_accs.UseVisualStyleBackColor = true;
            this.btn_mng_accs.Click += new System.EventHandler(this.Btn_mng_accs_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 149);
            this.Controls.Add(this.btn_mng_accs);
            this.Controls.Add(this.btn_mng_cst);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Controls.SetChildIndex(this.btn_mng_cst, 0);
            this.Controls.SetChildIndex(this.btn_mng_accs, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mng_cst;
        private System.Windows.Forms.Button btn_mng_accs;
    }
}