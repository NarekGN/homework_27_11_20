
namespace Homework_27_11_20.Views
{
    partial class MainForm
    {
        /// <summary>
        /// ������������ ���������� ������������.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ���������� ��� ������������ �������.
        /// </summary>
        /// <param name="disposing">�������, ���� ����������� ������ ������ ���� ������; ����� �����.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region ���, ������������� ��������� ������������� ���� Windows

        /// <summary>
        /// ��������� ����� ��� ��������� ������������ � �� ��������� 
        /// ���������� ����� ������ � ������� ��������� ����.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupFormOpenButton = new System.Windows.Forms.Button();
            this.specialtiesFormOpenButton = new System.Windows.Forms.Button();
            this.studentFormOpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupFormOpenButton
            // 
            this.groupFormOpenButton.Location = new System.Drawing.Point(116, 12);
            this.groupFormOpenButton.Name = "groupFormOpenButton";
            this.groupFormOpenButton.Size = new System.Drawing.Size(106, 26);
            this.groupFormOpenButton.TabIndex = 0;
            this.groupFormOpenButton.Text = "������";
            this.groupFormOpenButton.UseVisualStyleBackColor = true;
            // 
            // specialtiesFormOpenButton
            // 
            this.specialtiesFormOpenButton.Location = new System.Drawing.Point(6, 12);
            this.specialtiesFormOpenButton.Name = "specialtiesFormOpenButton";
            this.specialtiesFormOpenButton.Size = new System.Drawing.Size(104, 26);
            this.specialtiesFormOpenButton.TabIndex = 1;
            this.specialtiesFormOpenButton.Text = "�������������";
            this.specialtiesFormOpenButton.UseVisualStyleBackColor = true;
            // 
            // studentFormOpenButton
            // 
            this.studentFormOpenButton.Location = new System.Drawing.Point(228, 12);
            this.studentFormOpenButton.Name = "studentFormOpenButton";
            this.studentFormOpenButton.Size = new System.Drawing.Size(94, 26);
            this.studentFormOpenButton.TabIndex = 2;
            this.studentFormOpenButton.Text = "��������";
            this.studentFormOpenButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 46);
            this.Controls.Add(this.studentFormOpenButton);
            this.Controls.Add(this.specialtiesFormOpenButton);
            this.Controls.Add(this.groupFormOpenButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "����";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button groupFormOpenButton;
        private System.Windows.Forms.Button specialtiesFormOpenButton;
        private System.Windows.Forms.Button studentFormOpenButton;
    }
}
