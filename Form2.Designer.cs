﻿namespace FileIODemo2
{
    partial class Form2
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
            this.lblDeptId = new System.Windows.Forms.Label();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXMLWrite = new System.Windows.Forms.Button();
            this.btnXMLRead = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Location = new System.Drawing.Point(45, 29);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(50, 16);
            this.lblDeptId.TabIndex = 0;
            this.lblDeptId.Text = "Dept Id";
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(45, 82);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(76, 16);
            this.lblDeptName.TabIndex = 1;
            this.lblDeptName.Text = "Dept Name";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(45, 133);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(58, 16);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(147, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(147, 133);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 5;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(416, 29);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(100, 23);
            this.btnBinaryWrite.TabIndex = 6;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(592, 29);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(98, 23);
            this.btnBinaryRead.TabIndex = 7;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnXMLWrite
            // 
            this.btnXMLWrite.Location = new System.Drawing.Point(416, 92);
            this.btnXMLWrite.Name = "btnXMLWrite";
            this.btnXMLWrite.Size = new System.Drawing.Size(100, 23);
            this.btnXMLWrite.TabIndex = 8;
            this.btnXMLWrite.Text = "XML Write";
            this.btnXMLWrite.UseVisualStyleBackColor = true;
            this.btnXMLWrite.Click += new System.EventHandler(this.btnXMLWrite_Click);
            // 
            // btnXMLRead
            // 
            this.btnXMLRead.Location = new System.Drawing.Point(592, 92);
            this.btnXMLRead.Name = "btnXMLRead";
            this.btnXMLRead.Size = new System.Drawing.Size(98, 23);
            this.btnXMLRead.TabIndex = 9;
            this.btnXMLRead.Text = "XML Read";
            this.btnXMLRead.UseVisualStyleBackColor = true;
            this.btnXMLRead.Click += new System.EventHandler(this.btnXMLRead_Click);
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(416, 158);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(100, 23);
            this.btnSOAPWrite.TabIndex = 10;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            this.btnSOAPWrite.Click += new System.EventHandler(this.btnSOAPWrite_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(592, 158);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(98, 23);
            this.btnSOAPRead.TabIndex = 11;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            this.btnSOAPRead.Click += new System.EventHandler(this.btnSOAPRead_Click);
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(416, 225);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(100, 23);
            this.btnJSONWrite.TabIndex = 12;
            this.btnJSONWrite.Text = "JSON Write";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            this.btnJSONWrite.Click += new System.EventHandler(this.btnJSONWrite_Click);
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(592, 225);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(98, 23);
            this.btnJSONRead.TabIndex = 13;
            this.btnJSONRead.Text = "JSON Read";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            this.btnJSONRead.Click += new System.EventHandler(this.btnJSONRead_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnXMLRead);
            this.Controls.Add(this.btnXMLWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.lblDeptId);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeptId;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXMLWrite;
        private System.Windows.Forms.Button btnXMLRead;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnJSONWrite;
        private System.Windows.Forms.Button btnJSONRead;
    }
}