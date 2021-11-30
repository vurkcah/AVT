
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.outtext = new System.Windows.Forms.TextBox();
            this.MaxLength = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputsubstring = new System.Windows.Forms.TextBox();
            this.inputOccurrences = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OverlappingOccurrences = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // outtext
            // 
            this.outtext.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.outtext.Location = new System.Drawing.Point(6, 19);
            this.outtext.Multiline = true;
            this.outtext.Name = "outtext";
            this.outtext.Size = new System.Drawing.Size(1105, 77);
            this.outtext.TabIndex = 0;
            // 
            // MaxLength
            // 
            this.MaxLength.Location = new System.Drawing.Point(182, 39);
            this.MaxLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxLength.Name = "MaxLength";
            this.MaxLength.Size = new System.Drawing.Size(46, 22);
            this.MaxLength.TabIndex = 1;
            this.MaxLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(9, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "генерация  случайной строки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(4, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "найти вхождения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Все вхождения образца:";
            // 
            // inputsubstring
            // 
            this.inputsubstring.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.inputsubstring.Location = new System.Drawing.Point(136, 132);
            this.inputsubstring.Multiline = true;
            this.inputsubstring.Name = "inputsubstring";
            this.inputsubstring.Size = new System.Drawing.Size(223, 32);
            this.inputsubstring.TabIndex = 5;
            // 
            // inputOccurrences
            // 
            this.inputOccurrences.Location = new System.Drawing.Point(189, 93);
            this.inputOccurrences.Multiline = true;
            this.inputOccurrences.Name = "inputOccurrences";
            this.inputOccurrences.Size = new System.Drawing.Size(517, 25);
            this.inputOccurrences.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имеются ли перекрывающиеся вхождения:";
            // 
            // OverlappingOccurrences
            // 
            this.OverlappingOccurrences.Location = new System.Drawing.Point(307, 36);
            this.OverlappingOccurrences.Multiline = true;
            this.OverlappingOccurrences.Name = "OverlappingOccurrences";
            this.OverlappingOccurrences.Size = new System.Drawing.Size(399, 25);
            this.OverlappingOccurrences.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outtext);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод строки:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.MaxLength);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.inputsubstring);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 430);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Входные данные:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "загрузка из файла";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите образец:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выберите длину строки: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OverlappingOccurrences);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.inputOccurrences);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(417, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 430);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выходные данные:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MaxLength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox outtext;
        private System.Windows.Forms.NumericUpDown MaxLength;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputsubstring;
        private System.Windows.Forms.TextBox inputOccurrences;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OverlappingOccurrences;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

