namespace DGAssignment2
{
    partial class LevelDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelDesign));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbGreenBox = new System.Windows.Forms.PictureBox();
            this.pbRedBox = new System.Windows.Forms.PictureBox();
            this.pbNone = new System.Windows.Forms.PictureBox();
            this.pbGreenDoor = new System.Windows.Forms.PictureBox();
            this.pbRedDoor = new System.Windows.Forms.PictureBox();
            this.pbWall = new System.Windows.Forms.PictureBox();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblGame = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtColumns);
            this.panel1.Controls.Add(this.txtRows);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 84);
            this.panel1.TabIndex = 0;
            // 
            // txtColumns
            // 
            this.txtColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumns.Location = new System.Drawing.Point(274, 33);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(94, 24);
            this.txtColumns.TabIndex = 4;
            // 
            // txtRows
            // 
            this.txtRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRows.Location = new System.Drawing.Point(64, 33);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(94, 24);
            this.txtRows.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(440, 26);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(199, 39);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columns: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pbGreenBox);
            this.panel2.Controls.Add(this.pbRedBox);
            this.panel2.Controls.Add(this.pbNone);
            this.panel2.Controls.Add(this.pbGreenDoor);
            this.panel2.Controls.Add(this.pbRedDoor);
            this.panel2.Controls.Add(this.pbWall);
            this.panel2.Controls.Add(this.btnGreenBox);
            this.panel2.Controls.Add(this.btnRedBox);
            this.panel2.Controls.Add(this.btnGreenDoor);
            this.panel2.Controls.Add(this.btnRedDoor);
            this.panel2.Controls.Add(this.btnWall);
            this.panel2.Controls.Add(this.btnNone);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 629);
            this.panel2.TabIndex = 1;
            // 
            // pbGreenBox
            // 
            this.pbGreenBox.Image = global::DGAssignment2.Properties.Resources.greenBox;
            this.pbGreenBox.Location = new System.Drawing.Point(3, 535);
            this.pbGreenBox.Name = "pbGreenBox";
            this.pbGreenBox.Size = new System.Drawing.Size(70, 70);
            this.pbGreenBox.TabIndex = 16;
            this.pbGreenBox.TabStop = false;
            this.pbGreenBox.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // pbRedBox
            // 
            this.pbRedBox.Image = global::DGAssignment2.Properties.Resources.redBox;
            this.pbRedBox.Location = new System.Drawing.Point(3, 447);
            this.pbRedBox.Name = "pbRedBox";
            this.pbRedBox.Size = new System.Drawing.Size(70, 70);
            this.pbRedBox.TabIndex = 15;
            this.pbRedBox.TabStop = false;
            this.pbRedBox.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // pbNone
            // 
            this.pbNone.Image = ((System.Drawing.Image)(resources.GetObject("pbNone.Image")));
            this.pbNone.Location = new System.Drawing.Point(3, 95);
            this.pbNone.Name = "pbNone";
            this.pbNone.Size = new System.Drawing.Size(70, 70);
            this.pbNone.TabIndex = 14;
            this.pbNone.TabStop = false;
            this.pbNone.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // pbGreenDoor
            // 
            this.pbGreenDoor.Image = global::DGAssignment2.Properties.Resources.greenDoor;
            this.pbGreenDoor.Location = new System.Drawing.Point(3, 359);
            this.pbGreenDoor.Name = "pbGreenDoor";
            this.pbGreenDoor.Size = new System.Drawing.Size(70, 70);
            this.pbGreenDoor.TabIndex = 13;
            this.pbGreenDoor.TabStop = false;
            this.pbGreenDoor.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // pbRedDoor
            // 
            this.pbRedDoor.Image = global::DGAssignment2.Properties.Resources.redDoor;
            this.pbRedDoor.Location = new System.Drawing.Point(3, 271);
            this.pbRedDoor.Name = "pbRedDoor";
            this.pbRedDoor.Size = new System.Drawing.Size(70, 70);
            this.pbRedDoor.TabIndex = 12;
            this.pbRedDoor.TabStop = false;
            this.pbRedDoor.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // pbWall
            // 
            this.pbWall.Image = global::DGAssignment2.Properties.Resources.wall;
            this.pbWall.Location = new System.Drawing.Point(3, 183);
            this.pbWall.Name = "pbWall";
            this.pbWall.Size = new System.Drawing.Size(70, 70);
            this.pbWall.TabIndex = 11;
            this.pbWall.TabStop = false;
            this.pbWall.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGreenBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGreenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenBox.Location = new System.Drawing.Point(2, 529);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(168, 82);
            this.btnGreenBox.TabIndex = 10;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = false;
            this.btnGreenBox.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRedBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedBox.Location = new System.Drawing.Point(2, 441);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(168, 82);
            this.btnRedBox.TabIndex = 9;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = false;
            this.btnRedBox.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGreenDoor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGreenDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenDoor.Location = new System.Drawing.Point(2, 353);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(168, 82);
            this.btnGreenDoor.TabIndex = 8;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = false;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRedDoor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRedDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedDoor.Location = new System.Drawing.Point(2, 265);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(168, 82);
            this.btnRedDoor.TabIndex = 7;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = false;
            this.btnRedDoor.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // btnWall
            // 
            this.btnWall.BackColor = System.Drawing.Color.SteelBlue;
            this.btnWall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWall.Location = new System.Drawing.Point(2, 177);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(168, 82);
            this.btnWall.TabIndex = 6;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = false;
            this.btnWall.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // btnNone
            // 
            this.btnNone.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNone.Location = new System.Drawing.Point(2, 89);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(168, 82);
            this.btnNone.TabIndex = 5;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = false;
            this.btnNone.Click += new System.EventHandler(this.btnImageType_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toolbox";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // tblGame
            // 
            this.tblGame.ColumnCount = 2;
            this.tblGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGame.Location = new System.Drawing.Point(182, 122);
            this.tblGame.Name = "tblGame";
            this.tblGame.RowCount = 2;
            this.tblGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGame.Size = new System.Drawing.Size(951, 900);
            this.tblGame.TabIndex = 3;
            // 
            // LevelDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(790, 756);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tblGame);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LevelDesign";
            this.Text = "LevelDesign";
            this.Load += new System.EventHandler(this.LevelDesign_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tblGame;
        private System.Windows.Forms.PictureBox pbGreenBox;
        private System.Windows.Forms.PictureBox pbRedBox;
        private System.Windows.Forms.PictureBox pbNone;
        private System.Windows.Forms.PictureBox pbGreenDoor;
        private System.Windows.Forms.PictureBox pbRedDoor;
        private System.Windows.Forms.PictureBox pbWall;
    }
}