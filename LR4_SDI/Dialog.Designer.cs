
namespace LR4_SDI
{
    partial class Dialog
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
            this.gB1 = new System.Windows.Forms.GroupBox();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.OkDialog = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.Button();
            this.gB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB1
            // 
            this.gB1.Controls.Add(this.rB2);
            this.gB1.Controls.Add(this.rB1);
            this.gB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gB1.Location = new System.Drawing.Point(52, 64);
            this.gB1.Name = "gB1";
            this.gB1.Size = new System.Drawing.Size(784, 235);
            this.gB1.TabIndex = 1;
            this.gB1.TabStop = false;
            this.gB1.Text = "Выберите задание";
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB2.Location = new System.Drawing.Point(14, 158);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(750, 28);
            this.rB2.TabIndex = 3;
            this.rB2.TabStop = true;
            this.rB2.Text = "Найти среднее арифметическое элементов, лежащих выше главной диагонали";
            this.rB2.UseVisualStyleBackColor = true;
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB1.Location = new System.Drawing.Point(14, 77);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(588, 28);
            this.rB1.TabIndex = 2;
            this.rB1.TabStop = true;
            this.rB1.Text = "Определить, имеются ли в исходном массиве простые числа";
            this.rB1.UseVisualStyleBackColor = true;
            this.rB1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // OkDialog
            // 
            this.OkDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkDialog.Location = new System.Drawing.Point(329, 315);
            this.OkDialog.Name = "OkDialog";
            this.OkDialog.Size = new System.Drawing.Size(234, 66);
            this.OkDialog.TabIndex = 2;
            this.OkDialog.Text = "Ok";
            this.OkDialog.UseVisualStyleBackColor = true;
            this.OkDialog.Click += new System.EventHandler(this.OkDialog_Click);
            // 
            // CloseBut
            // 
            this.CloseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBut.Location = new System.Drawing.Point(602, 315);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(234, 66);
            this.CloseBut.TabIndex = 3;
            this.CloseBut.Text = "Закрыть";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 417);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.OkDialog);
            this.Controls.Add(this.gB1);
            this.Name = "Dialog";
            this.Text = "Dialog";
            this.gB1.ResumeLayout(false);
            this.gB1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gB1;
        private System.Windows.Forms.Button OkDialog;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.Button CloseBut;
    }
}