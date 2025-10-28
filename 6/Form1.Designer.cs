
namespace Laba6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            colorDialog1 = new ColorDialog();
            btnChooseColor = new Button();
            btnChooseFont = new Button();
            txtChooseFont = new TextBox();
            Calk = new Button();
            saveFileDialog1 = new SaveFileDialog();
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            textBoxN = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnChooseColor
            // 
            btnChooseColor.Location = new Point(52, 56);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(160, 40);
            btnChooseColor.TabIndex = 0;
            btnChooseColor.Text = "Выбор цвета";
            btnChooseColor.UseVisualStyleBackColor = true;
            btnChooseColor.Click += btnChooseColor_Click;
            // 
            // btnChooseFont
            // 
            btnChooseFont.Location = new Point(52, 190);
            btnChooseFont.Name = "btnChooseFont";
            btnChooseFont.Size = new Size(160, 40);
            btnChooseFont.TabIndex = 2;
            btnChooseFont.Text = "Выбор шрифта";
            btnChooseFont.UseVisualStyleBackColor = true;
            btnChooseFont.Click += btnChooseFont_Click;
            // 
            // txtChooseFont
            // 
            txtChooseFont.Location = new Point(315, 346);
            txtChooseFont.Name = "txtChooseFont";
            txtChooseFont.Size = new Size(200, 23);
            txtChooseFont.TabIndex = 7;
            // 
            // Calk
            // 
            Calk.Location = new Point(52, 346);
            Calk.Name = "Calk";
            Calk.Size = new Size(160, 40);
            Calk.TabIndex = 11;
            Calk.Text = "Рассчитать";
            Calk.UseVisualStyleBackColor = true;
            Calk.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(335, 56);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 40);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save as";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 185);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 13;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 185);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 14;
            label3.Text = "Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(782, 190);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 15;
            label4.Text = "N";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(390, 182);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 16;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(622, 185);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 17;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(857, 182);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(100, 23);
            textBoxN.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(299, 248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 66);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxN);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(Calk);
            Controls.Add(txtChooseFont);
            Controls.Add(btnChooseFont);
            Controls.Add(btnChooseColor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ColorDialog colorDialog1;
        private Button btnChooseColor;
        private Label label1;
        private Button btnChooseFont;
        private Button button3;
        private TextBox txtChooseFont;
        private TextBox textBox1;
        private Button Calk;
        private SaveFileDialog saveFileDialog1;
        private Button btnSave;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private TextBox textBoxN;
        private PictureBox pictureBox1;
    }
}
