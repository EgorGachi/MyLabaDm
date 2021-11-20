
namespace MyLabaDm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VertexDraw = new System.Windows.Forms.Button();
            this.EdgeDraw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(171, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 435);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // VertexDraw
            // 
            this.VertexDraw.Location = new System.Drawing.Point(879, 21);
            this.VertexDraw.Name = "VertexDraw";
            this.VertexDraw.Size = new System.Drawing.Size(43, 23);
            this.VertexDraw.TabIndex = 1;
            this.VertexDraw.Text = "V";
            this.VertexDraw.UseVisualStyleBackColor = true;
            this.VertexDraw.Click += new System.EventHandler(this.VertexButton_Click);
            // 
            // EdgeDraw
            // 
            this.EdgeDraw.Location = new System.Drawing.Point(928, 21);
            this.EdgeDraw.Name = "EdgeDraw";
            this.EdgeDraw.Size = new System.Drawing.Size(43, 23);
            this.EdgeDraw.TabIndex = 2;
            this.EdgeDraw.Text = "E";
            this.EdgeDraw.UseVisualStyleBackColor = true;
            this.EdgeDraw.Click += new System.EventHandler(this.EdgeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(895, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Узнать сумму степеней всех вершин";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SumEdge_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(895, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 65);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EdgeDraw);
            this.Controls.Add(this.VertexDraw);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button VertexDraw;
        private System.Windows.Forms.Button EdgeDraw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

