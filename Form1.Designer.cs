﻿
namespace Lab7
{
    partial class fMain
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnTools = new System.Windows.Forms.Panel();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnDownFar = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRightFar = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftFar = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnUpFar = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.cbCircles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            this.pnTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Controls.Add(this.panel2);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(800, 450);
            this.pnMain.TabIndex = 0;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(540, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 426);
            this.panel2.TabIndex = 1;
            // 
            // pnTools
            // 
            this.pnTools.Controls.Add(this.label1);
            this.pnTools.Controls.Add(this.btnCollapse);
            this.pnTools.Controls.Add(this.btnExpand);
            this.pnTools.Controls.Add(this.btnDownFar);
            this.pnTools.Controls.Add(this.btnDown);
            this.pnTools.Controls.Add(this.btnRightFar);
            this.pnTools.Controls.Add(this.btnRight);
            this.pnTools.Controls.Add(this.btnLeft);
            this.pnTools.Controls.Add(this.btnLeftFar);
            this.pnTools.Controls.Add(this.btnUp);
            this.pnTools.Controls.Add(this.btnUpFar);
            this.pnTools.Controls.Add(this.btnShow);
            this.pnTools.Controls.Add(this.btnHide);
            this.pnTools.Controls.Add(this.btnCreateNew);
            this.pnTools.Controls.Add(this.cbCircles);
            this.pnTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTools.Location = new System.Drawing.Point(544, 0);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(256, 450);
            this.pnTools.TabIndex = 1;
            this.pnTools.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTools_Paint);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCollapse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCollapse.Location = new System.Drawing.Point(104, 305);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(47, 20);
            this.btnCollapse.TabIndex = 13;
            this.btnCollapse.Text = "-";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExpand.Location = new System.Drawing.Point(104, 284);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(47, 21);
            this.btnExpand.TabIndex = 12;
            this.btnExpand.Text = "+";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnDownFar
            // 
            this.btnDownFar.Image = global::Lab7.Properties.Resources.png_transparent_computer_icons_arrow_symbol_encapsulated_postscript_double_arrow_angle_text_triangle__2_;
            this.btnDownFar.Location = new System.Drawing.Point(104, 378);
            this.btnDownFar.Name = "btnDownFar";
            this.btnDownFar.Size = new System.Drawing.Size(47, 41);
            this.btnDownFar.TabIndex = 11;
            this.btnDownFar.UseVisualStyleBackColor = true;
            this.btnDownFar.Click += new System.EventHandler(this.btnDownFar_Click);
            // 
            // btnDown
            // 
            this.btnDown.Image = global::Lab7.Properties.Resources.arrow__2_;
            this.btnDown.Location = new System.Drawing.Point(104, 331);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(47, 41);
            this.btnDown.TabIndex = 10;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRightFar
            // 
            this.btnRightFar.Image = global::Lab7.Properties.Resources.png_transparent_computer_icons_arrow_symbol_encapsulated_postscript_double_arrow_angle_text_triangle__1_;
            this.btnRightFar.Location = new System.Drawing.Point(204, 284);
            this.btnRightFar.Name = "btnRightFar";
            this.btnRightFar.Size = new System.Drawing.Size(47, 41);
            this.btnRightFar.TabIndex = 9;
            this.btnRightFar.UseVisualStyleBackColor = true;
            this.btnRightFar.Click += new System.EventHandler(this.btnRightFar_Click);
            // 
            // btnRight
            // 
            this.btnRight.Image = global::Lab7.Properties.Resources.arrow;
            this.btnRight.Location = new System.Drawing.Point(151, 284);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(47, 41);
            this.btnRight.TabIndex = 8;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Image = global::Lab7.Properties.Resources.arrow__3_;
            this.btnLeft.Location = new System.Drawing.Point(55, 284);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(47, 41);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnLeftFar
            // 
            this.btnLeftFar.Image = global::Lab7.Properties.Resources.png_transparent_computer_icons_arrow_symbol_encapsulated_postscript_double_arrow_angle_text_triangle_1;
            this.btnLeftFar.Location = new System.Drawing.Point(3, 284);
            this.btnLeftFar.Name = "btnLeftFar";
            this.btnLeftFar.Size = new System.Drawing.Size(46, 41);
            this.btnLeftFar.TabIndex = 6;
            this.btnLeftFar.UseVisualStyleBackColor = true;
            this.btnLeftFar.Click += new System.EventHandler(this.btnLeftFar_Click);
            // 
            // btnUp
            // 
            this.btnUp.Image = global::Lab7.Properties.Resources.arrow__1_;
            this.btnUp.Location = new System.Drawing.Point(106, 239);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(45, 41);
            this.btnUp.TabIndex = 5;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpFar
            // 
            this.btnUpFar.Image = global::Lab7.Properties.Resources.png_transparent_computer_icons_arrow_symbol_encapsulated_postscript_double_arrow_angle_text_triangle__3_;
            this.btnUpFar.Location = new System.Drawing.Point(106, 191);
            this.btnUpFar.Name = "btnUpFar";
            this.btnUpFar.Size = new System.Drawing.Size(45, 42);
            this.btnUpFar.TabIndex = 4;
            this.btnUpFar.UseVisualStyleBackColor = true;
            this.btnUpFar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(41, 162);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(175, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Показати об\'єкт";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(41, 133);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(175, 23);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Приховати об\'єкт";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(41, 104);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(175, 23);
            this.btnCreateNew.TabIndex = 1;
            this.btnCreateNew.Text = "Створити новий об\'єкт";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // cbCircles
            // 
            this.cbCircles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCircles.FormattingEnabled = true;
            this.cbCircles.Location = new System.Drawing.Point(41, 54);
            this.cbCircles.Name = "cbCircles";
            this.cbCircles.Size = new System.Drawing.Size(175, 21);
            this.cbCircles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Перелік об\'єктів";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnTools);
            this.Controls.Add(this.pnMain);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnMain.ResumeLayout(false);
            this.pnTools.ResumeLayout(false);
            this.pnTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.ComboBox cbCircles;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnDownFar;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRightFar;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftFar;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnUpFar;
        private System.Windows.Forms.Label label1;
    }
}

