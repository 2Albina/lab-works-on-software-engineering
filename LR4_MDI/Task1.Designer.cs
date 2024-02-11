
namespace LR4_SDI
{
    partial class Task1
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
            this.solution1 = new System.Windows.Forms.Button();
            this.close1 = new System.Windows.Forms.Button();
            this.dG1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KolRow = new System.Windows.Forms.TextBox();
            this.KolCol = new System.Windows.Forms.TextBox();
            this.fill = new System.Windows.Forms.Button();
            this.cB1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).BeginInit();
            this.SuspendLayout();
            // 
            // solution1
            // 
            this.solution1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solution1.Location = new System.Drawing.Point(595, 207);
            this.solution1.Name = "solution1";
            this.solution1.Size = new System.Drawing.Size(167, 59);
            this.solution1.TabIndex = 1;
            this.solution1.Text = "Определить";
            this.solution1.UseVisualStyleBackColor = true;
            this.solution1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close1
            // 
            this.close1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close1.Location = new System.Drawing.Point(595, 272);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(167, 59);
            this.close1.TabIndex = 2;
            this.close1.Text = "Закрыть";
            this.close1.UseVisualStyleBackColor = true;
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // dG1
            // 
            this.dG1.AllowUserToAddRows = false;
            this.dG1.AllowUserToDeleteRows = false;
            this.dG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG1.Location = new System.Drawing.Point(38, 36);
            this.dG1.Name = "dG1";
            this.dG1.RowHeadersWidth = 30;
            this.dG1.RowTemplate.Height = 24;
            this.dG1.Size = new System.Drawing.Size(442, 294);
            this.dG1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(547, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Строк";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(547, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Столбцов";
            // 
            // KolRow
            // 
            this.KolRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KolRow.Location = new System.Drawing.Point(688, 37);
            this.KolRow.Name = "KolRow";
            this.KolRow.Size = new System.Drawing.Size(74, 30);
            this.KolRow.TabIndex = 6;
            this.KolRow.TextChanged += new System.EventHandler(this.KolRow_TextChanged);
            // 
            // KolCol
            // 
            this.KolCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KolCol.Location = new System.Drawing.Point(688, 73);
            this.KolCol.Name = "KolCol";
            this.KolCol.Size = new System.Drawing.Size(74, 30);
            this.KolCol.TabIndex = 7;
            this.KolCol.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fill
            // 
            this.fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fill.Location = new System.Drawing.Point(595, 142);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(167, 59);
            this.fill.TabIndex = 8;
            this.fill.Text = "Заполнить матрицу";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // cB1
            // 
            this.cB1.AutoSize = true;
            this.cB1.Location = new System.Drawing.Point(595, 115);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(108, 21);
            this.cB1.TabIndex = 9;
            this.cB1.Text = "Не простые";
            this.cB1.UseVisualStyleBackColor = true;
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 375);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.KolCol);
            this.Controls.Add(this.KolRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dG1);
            this.Controls.Add(this.close1);
            this.Controls.Add(this.solution1);
            this.Name = "Task1";
            this.Text = "Ввод данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Task1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button solution1;
        private System.Windows.Forms.Button close1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KolRow;
        private System.Windows.Forms.TextBox KolCol;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.CheckBox cB1;
        public System.Windows.Forms.DataGridView dG1;
    }
}