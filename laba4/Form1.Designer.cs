
namespace laba4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_shape = new System.Windows.Forms.Label();
            this.label_color = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(824, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 286);
            this.label1.TabIndex = 1;
            this.label1.Text = "G - green\r\nB - blue\r\nY - yellow\r\nDelete - delete\r\n+ - resize+\r\n- - resize-\r\nUp - " +
    "move up\r\nDown - move down\r\nLeft - move left\r\nRight - move right\r\nC - circle\r\nS -" +
    " square\r\nT - triangle\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_shape
            // 
            this.label_shape.AutoSize = true;
            this.label_shape.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_shape.Location = new System.Drawing.Point(825, 323);
            this.label_shape.Name = "label_shape";
            this.label_shape.Size = new System.Drawing.Size(130, 36);
            this.label_shape.TabIndex = 2;
            this.label_shape.Text = "Текущая фигура -\r\nкруг";
            this.label_shape.Click += new System.EventHandler(this.label_shape_Click);
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_color.Location = new System.Drawing.Point(825, 373);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(115, 36);
            this.label_color.TabIndex = 3;
            this.label_color.Text = "Текущий цвет - \r\nсиний";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(984, 624);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.label_shape);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_shape;
        private System.Windows.Forms.Label label_color;
    }
}

