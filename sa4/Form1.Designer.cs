namespace sa4
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
            this.matrixView = new System.Windows.Forms.DataGridView();
            this.okButton = new System.Windows.Forms.Button();
            this.topsCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.edgesCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.outputView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputView)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixView
            // 
            this.matrixView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrixView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrixView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrixView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.matrixView.Location = new System.Drawing.Point(12, 30);
            this.matrixView.Name = "matrixView";
            this.matrixView.Size = new System.Drawing.Size(465, 421);
            this.matrixView.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(893, 473);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // topsCount
            // 
            this.topsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.topsCount.Location = new System.Drawing.Point(674, 476);
            this.topsCount.Name = "topsCount";
            this.topsCount.Size = new System.Drawing.Size(54, 20);
            this.topsCount.TabIndex = 2;
            this.topsCount.ValueChanged += new System.EventHandler(this.topsCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Мощность графа";
            // 
            // edgesCount
            // 
            this.edgesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edgesCount.Location = new System.Drawing.Point(821, 476);
            this.edgesCount.Name = "edgesCount";
            this.edgesCount.Size = new System.Drawing.Size(53, 20);
            this.edgesCount.TabIndex = 4;
            this.edgesCount.ValueChanged += new System.EventHandler(this.edgesCount_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кол-во ребер";
            // 
            // outputView
            // 
            this.outputView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.outputView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.outputView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.outputView.Location = new System.Drawing.Point(503, 30);
            this.outputView.Name = "outputView";
            this.outputView.Size = new System.Drawing.Size(465, 421);
            this.outputView.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Матрица расстояний между смежными вершинами";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Матрица кратчайших путей между вершинами";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edgesCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topsCount);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.matrixView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Минимизация путей в графе";
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrixView;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.NumericUpDown topsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edgesCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView outputView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

