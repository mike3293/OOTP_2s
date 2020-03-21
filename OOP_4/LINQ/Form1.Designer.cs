namespace LINQ
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
            this.label = new System.Windows.Forms.Label();
            this.textBoxColSize = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.listViewCol = new System.Windows.Forms.ListView();
            this.listViewOrdCol = new System.Windows.Forms.ListView();
            this.buttonOrderByAsc = new System.Windows.Forms.Button();
            this.buttonOrderByDesc = new System.Windows.Forms.Button();
            this.buttonLINQ1 = new System.Windows.Forms.Button();
            this.buttonLINQ2 = new System.Windows.Forms.Button();
            this.listViewLINQ3 = new System.Windows.Forms.ListView();
            this.listViewLINQ2 = new System.Windows.Forms.ListView();
            this.buttonLINQ3 = new System.Windows.Forms.Button();
            this.listViewLINQ1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(21, 31);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(242, 24);
            this.label.TabIndex = 0;
            this.label.Text = "Enter collection size(<20)";
            // 
            // textBoxColSize
            // 
            this.textBoxColSize.Location = new System.Drawing.Point(47, 62);
            this.textBoxColSize.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxColSize.Name = "textBoxColSize";
            this.textBoxColSize.Size = new System.Drawing.Size(212, 22);
            this.textBoxColSize.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(283, 31);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(156, 55);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create a collection";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // listViewCol
            // 
            this.listViewCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCol.Location = new System.Drawing.Point(23, 106);
            this.listViewCol.Margin = new System.Windows.Forms.Padding(4);
            this.listViewCol.Name = "listViewCol";
            this.listViewCol.Size = new System.Drawing.Size(397, 207);
            this.listViewCol.TabIndex = 3;
            this.listViewCol.UseCompatibleStateImageBehavior = false;
            this.listViewCol.View = System.Windows.Forms.View.List;
            // 
            // listViewOrdCol
            // 
            this.listViewOrdCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOrdCol.Location = new System.Drawing.Point(23, 409);
            this.listViewOrdCol.Margin = new System.Windows.Forms.Padding(4);
            this.listViewOrdCol.Name = "listViewOrdCol";
            this.listViewOrdCol.Size = new System.Drawing.Size(397, 207);
            this.listViewOrdCol.TabIndex = 4;
            this.listViewOrdCol.UseCompatibleStateImageBehavior = false;
            this.listViewOrdCol.View = System.Windows.Forms.View.List;
            // 
            // buttonOrderByAsc
            // 
            this.buttonOrderByAsc.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrderByAsc.Location = new System.Drawing.Point(47, 336);
            this.buttonOrderByAsc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrderByAsc.Name = "buttonOrderByAsc";
            this.buttonOrderByAsc.Size = new System.Drawing.Size(156, 55);
            this.buttonOrderByAsc.TabIndex = 5;
            this.buttonOrderByAsc.Text = "Order by ascending";
            this.buttonOrderByAsc.UseVisualStyleBackColor = true;
            this.buttonOrderByAsc.Click += new System.EventHandler(this.ButtonOrderByAsc_Click);
            // 
            // buttonOrderByDesc
            // 
            this.buttonOrderByDesc.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrderByDesc.Location = new System.Drawing.Point(245, 336);
            this.buttonOrderByDesc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrderByDesc.Name = "buttonOrderByDesc";
            this.buttonOrderByDesc.Size = new System.Drawing.Size(156, 55);
            this.buttonOrderByDesc.TabIndex = 6;
            this.buttonOrderByDesc.Text = "Order by descending";
            this.buttonOrderByDesc.UseVisualStyleBackColor = true;
            this.buttonOrderByDesc.Click += new System.EventHandler(this.ButtonOrderByDesc_Click);
            // 
            // buttonLINQ1
            // 
            this.buttonLINQ1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLINQ1.Location = new System.Drawing.Point(489, 49);
            this.buttonLINQ1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLINQ1.Name = "buttonLINQ1";
            this.buttonLINQ1.Size = new System.Drawing.Size(103, 65);
            this.buttonLINQ1.TabIndex = 7;
            this.buttonLINQ1.Text = "Age < 40";
            this.buttonLINQ1.UseVisualStyleBackColor = true;
            this.buttonLINQ1.Click += new System.EventHandler(this.buttonLINQ1_Click);
            // 
            // buttonLINQ2
            // 
            this.buttonLINQ2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLINQ2.Location = new System.Drawing.Point(489, 236);
            this.buttonLINQ2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLINQ2.Name = "buttonLINQ2";
            this.buttonLINQ2.Size = new System.Drawing.Size(103, 77);
            this.buttonLINQ2.TabIndex = 8;
            this.buttonLINQ2.Text = "Letters in name <5";
            this.buttonLINQ2.UseVisualStyleBackColor = true;
            this.buttonLINQ2.Click += new System.EventHandler(this.ButtonLINQ2_Click);
            // 
            // listViewLINQ3
            // 
            this.listViewLINQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLINQ3.Location = new System.Drawing.Point(632, 425);
            this.listViewLINQ3.Margin = new System.Windows.Forms.Padding(4);
            this.listViewLINQ3.Name = "listViewLINQ3";
            this.listViewLINQ3.Size = new System.Drawing.Size(212, 115);
            this.listViewLINQ3.TabIndex = 9;
            this.listViewLINQ3.UseCompatibleStateImageBehavior = false;
            this.listViewLINQ3.View = System.Windows.Forms.View.List;
            // 
            // listViewLINQ2
            // 
            this.listViewLINQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLINQ2.Location = new System.Drawing.Point(632, 236);
            this.listViewLINQ2.Margin = new System.Windows.Forms.Padding(4);
            this.listViewLINQ2.Name = "listViewLINQ2";
            this.listViewLINQ2.Size = new System.Drawing.Size(212, 115);
            this.listViewLINQ2.TabIndex = 10;
            this.listViewLINQ2.UseCompatibleStateImageBehavior = false;
            this.listViewLINQ2.View = System.Windows.Forms.View.List;
            // 
            // buttonLINQ3
            // 
            this.buttonLINQ3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLINQ3.Location = new System.Drawing.Point(489, 425);
            this.buttonLINQ3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLINQ3.Name = "buttonLINQ3";
            this.buttonLINQ3.Size = new System.Drawing.Size(103, 77);
            this.buttonLINQ3.TabIndex = 11;
            this.buttonLINQ3.Text = "Name starts with:";
            this.buttonLINQ3.UseVisualStyleBackColor = true;
            this.buttonLINQ3.Click += new System.EventHandler(this.ButtonLINQ3_Click);
            // 
            // listViewLINQ1
            // 
            this.listViewLINQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLINQ1.Location = new System.Drawing.Point(632, 49);
            this.listViewLINQ1.Margin = new System.Windows.Forms.Padding(4);
            this.listViewLINQ1.Name = "listViewLINQ1";
            this.listViewLINQ1.Size = new System.Drawing.Size(212, 115);
            this.listViewLINQ1.TabIndex = 12;
            this.listViewLINQ1.UseCompatibleStateImageBehavior = false;
            this.listViewLINQ1.View = System.Windows.Forms.View.List;
            this.listViewLINQ1.SelectedIndexChanged += new System.EventHandler(this.listViewLINQ1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(489, 518);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 22);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(456, -7);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 2675);
            this.textBox2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(865, 631);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listViewLINQ1);
            this.Controls.Add(this.buttonLINQ3);
            this.Controls.Add(this.listViewLINQ2);
            this.Controls.Add(this.listViewLINQ3);
            this.Controls.Add(this.buttonLINQ2);
            this.Controls.Add(this.buttonLINQ1);
            this.Controls.Add(this.buttonOrderByDesc);
            this.Controls.Add(this.buttonOrderByAsc);
            this.Controls.Add(this.listViewOrdCol);
            this.Controls.Add(this.listViewCol);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxColSize);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxColSize;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ListView listViewCol;
        private System.Windows.Forms.ListView listViewOrdCol;
        private System.Windows.Forms.Button buttonOrderByAsc;
        private System.Windows.Forms.Button buttonOrderByDesc;
        private System.Windows.Forms.Button buttonLINQ1;
        private System.Windows.Forms.Button buttonLINQ2;
        private System.Windows.Forms.ListView listViewLINQ3;
        private System.Windows.Forms.ListView listViewLINQ2;
        private System.Windows.Forms.Button buttonLINQ3;
        private System.Windows.Forms.ListView listViewLINQ1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}