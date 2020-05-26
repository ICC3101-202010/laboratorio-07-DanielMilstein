namespace Lab7
{
    partial class Calculadora
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.AC = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.subs = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.TextBox();
            this.panelCalc = new System.Windows.Forms.Panel();
            this.pre = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Button();
            this.panelHist = new System.Windows.Forms.Panel();
            this.HistoryList = new System.Windows.Forms.ListView();
            this.clear = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.panelCalc.SuspendLayout();
            this.panelHist.SuspendLayout();
            this.SuspendLayout();
            // 
            // AC
            // 
            this.AC.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AC.Location = new System.Drawing.Point(336, 89);
            this.AC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(102, 70);
            this.AC.TabIndex = 0;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = true;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(444, 91);
            this.del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(102, 70);
            this.del.TabIndex = 1;
            this.del.Text = "DEL";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Div.Location = new System.Drawing.Point(336, 165);
            this.Div.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(102, 70);
            this.Div.TabIndex = 2;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.op_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(444, 165);
            this.mult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(102, 70);
            this.mult.TabIndex = 3;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.op_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(336, 239);
            this.sum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(102, 70);
            this.sum.TabIndex = 4;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.op_Click);
            // 
            // subs
            // 
            this.subs.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subs.Location = new System.Drawing.Point(444, 239);
            this.subs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subs.Name = "subs";
            this.subs.Size = new System.Drawing.Size(102, 70);
            this.subs.TabIndex = 5;
            this.subs.Text = "-";
            this.subs.UseVisualStyleBackColor = true;
            this.subs.Click += new System.EventHandler(this.op_Click);
            // 
            // ans
            // 
            this.ans.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(336, 313);
            this.ans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(102, 70);
            this.ans.TabIndex = 6;
            this.ans.Text = "ANS";
            this.ans.UseVisualStyleBackColor = true;
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(444, 313);
            this.equal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(102, 70);
            this.equal.TabIndex = 7;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(228, 165);
            this.n6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(102, 70);
            this.n6.TabIndex = 11;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n_Click);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(120, 165);
            this.n5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(102, 70);
            this.n5.TabIndex = 10;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n_Click);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(228, 239);
            this.n3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(102, 70);
            this.n3.TabIndex = 9;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n_Click);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(120, 239);
            this.n2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(102, 70);
            this.n2.TabIndex = 8;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n_Click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(12, 165);
            this.n4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(102, 70);
            this.n4.TabIndex = 15;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n_Click);
            // 
            // comma
            // 
            this.comma.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comma.Location = new System.Drawing.Point(228, 313);
            this.comma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(102, 70);
            this.comma.TabIndex = 14;
            this.comma.Text = ".";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.n_Click);
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(12, 239);
            this.n1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(102, 70);
            this.n1.TabIndex = 13;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n_Click);
            // 
            // n9
            // 
            this.n9.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(228, 91);
            this.n9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(102, 70);
            this.n9.TabIndex = 12;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n_Click);
            // 
            // n0
            // 
            this.n0.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(120, 313);
            this.n0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(102, 70);
            this.n0.TabIndex = 19;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n_Click);
            // 
            // n8
            // 
            this.n8.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(120, 89);
            this.n8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(102, 70);
            this.n8.TabIndex = 17;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n_Click);
            // 
            // n7
            // 
            this.n7.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(12, 89);
            this.n7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(102, 70);
            this.n7.TabIndex = 16;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n_Click);
            // 
            // box
            // 
            this.box.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box.Location = new System.Drawing.Point(12, 2);
            this.box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(534, 74);
            this.box.TabIndex = 21;
            this.box.Text = "0";
            this.box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelCalc
            // 
            this.panelCalc.Controls.Add(this.pre);
            this.panelCalc.Controls.Add(this.history);
            this.panelCalc.Controls.Add(this.box);
            this.panelCalc.Controls.Add(this.n0);
            this.panelCalc.Controls.Add(this.n8);
            this.panelCalc.Controls.Add(this.n7);
            this.panelCalc.Controls.Add(this.n4);
            this.panelCalc.Controls.Add(this.comma);
            this.panelCalc.Controls.Add(this.n1);
            this.panelCalc.Controls.Add(this.n9);
            this.panelCalc.Controls.Add(this.n6);
            this.panelCalc.Controls.Add(this.n5);
            this.panelCalc.Controls.Add(this.n3);
            this.panelCalc.Controls.Add(this.n2);
            this.panelCalc.Controls.Add(this.equal);
            this.panelCalc.Controls.Add(this.ans);
            this.panelCalc.Controls.Add(this.subs);
            this.panelCalc.Controls.Add(this.sum);
            this.panelCalc.Controls.Add(this.mult);
            this.panelCalc.Controls.Add(this.Div);
            this.panelCalc.Controls.Add(this.del);
            this.panelCalc.Controls.Add(this.AC);
            this.panelCalc.Location = new System.Drawing.Point(12, 11);
            this.panelCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCalc.Name = "panelCalc";
            this.panelCalc.Size = new System.Drawing.Size(556, 396);
            this.panelCalc.TabIndex = 22;
            // 
            // pre
            // 
            this.pre.AutoSize = true;
            this.pre.BackColor = System.Drawing.SystemColors.Window;
            this.pre.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.pre.Location = new System.Drawing.Point(15, 5);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(0, 61);
            this.pre.TabIndex = 23;
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(12, 313);
            this.history.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(102, 70);
            this.history.TabIndex = 22;
            this.history.Text = "History";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // panelHist
            // 
            this.panelHist.Controls.Add(this.back);
            this.panelHist.Controls.Add(this.clear);
            this.panelHist.Controls.Add(this.HistoryList);
            this.panelHist.Location = new System.Drawing.Point(12, 12);
            this.panelHist.Name = "panelHist";
            this.panelHist.Size = new System.Drawing.Size(556, 395);
            this.panelHist.TabIndex = 23;
            this.panelHist.Visible = false;
            // 
            // HistoryList
            // 
            this.HistoryList.GridLines = true;
            this.HistoryList.HideSelection = false;
            this.HistoryList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.HistoryList.Location = new System.Drawing.Point(16, 14);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(530, 293);
            this.HistoryList.TabIndex = 0;
            this.HistoryList.UseCompatibleStateImageBehavior = false;
            this.HistoryList.View = System.Windows.Forms.View.Details;
            this.HistoryList.VisibleChanged += new System.EventHandler(this.HistoryList_VisibleChanged);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(256, 326);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(290, 54);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear History";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(26, 326);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(150, 55);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(582, 418);
            this.Controls.Add(this.panelCalc);
            this.Controls.Add(this.panelHist);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.ShowIcon = false;
            this.Text = "Calculadora";
            this.panelCalc.ResumeLayout(false);
            this.panelCalc.PerformLayout();
            this.panelHist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button subs;
        private System.Windows.Forms.Button ans;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.TextBox box;
        private System.Windows.Forms.Panel panelCalc;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Label pre;
        private System.Windows.Forms.Panel panelHist;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListView HistoryList;
    }
}

