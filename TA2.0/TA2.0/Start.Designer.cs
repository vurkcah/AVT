
namespace TA2._0
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitprogramm = new System.Windows.Forms.Button();
            this.startprogramm = new System.Windows.Forms.Button();
            this.infoprogramm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exitprogramm
            // 
            this.exitprogramm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitprogramm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitprogramm.BackgroundImage")));
            this.exitprogramm.ForeColor = System.Drawing.SystemColors.Control;
            this.exitprogramm.Location = new System.Drawing.Point(379, 426);
            this.exitprogramm.Name = "exitprogramm";
            this.exitprogramm.Size = new System.Drawing.Size(200, 92);
            this.exitprogramm.TabIndex = 1;
            this.exitprogramm.UseVisualStyleBackColor = false;
            this.exitprogramm.Click += new System.EventHandler(this.exitprogramm_Click);
            // 
            // startprogramm
            // 
            this.startprogramm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startprogramm.BackgroundImage")));
            this.startprogramm.Location = new System.Drawing.Point(379, 84);
            this.startprogramm.Name = "startprogramm";
            this.startprogramm.Size = new System.Drawing.Size(200, 91);
            this.startprogramm.TabIndex = 2;
            this.startprogramm.UseVisualStyleBackColor = true;
            this.startprogramm.Click += new System.EventHandler(this.startprogramm_Click);
            // 
            // infoprogramm
            // 
            this.infoprogramm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoprogramm.BackgroundImage")));
            this.infoprogramm.Location = new System.Drawing.Point(379, 247);
            this.infoprogramm.Name = "infoprogramm";
            this.infoprogramm.Size = new System.Drawing.Size(200, 92);
            this.infoprogramm.TabIndex = 3;
            this.infoprogramm.UseVisualStyleBackColor = true;
            this.infoprogramm.Click += new System.EventHandler(this.infoprogramm_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 565);
            this.Controls.Add(this.infoprogramm);
            this.Controls.Add(this.startprogramm);
            this.Controls.Add(this.exitprogramm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Start";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitprogramm;
        private System.Windows.Forms.Button startprogramm;
        private System.Windows.Forms.Button infoprogramm;
    }
}

