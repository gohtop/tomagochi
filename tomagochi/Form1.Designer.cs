
namespace tomagochi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pbEat = new System.Windows.Forms.PictureBox();
            this.pbSleep = new System.Windows.Forms.PictureBox();
            this.pbHappy = new System.Windows.Forms.PictureBox();
            this.pbClear = new System.Windows.Forms.PictureBox();
            this.pbXp = new System.Windows.Forms.PictureBox();
            this.btnEat = new System.Windows.Forms.Button();
            this.btnHappy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.lbleatCur = new System.Windows.Forms.Label();
            this.lblEatMax = new System.Windows.Forms.Label();
            this.lblSleepCur = new System.Windows.Forms.Label();
            this.lblSleepMax = new System.Windows.Forms.Label();
            this.lblHappyCur = new System.Windows.Forms.Label();
            this.lblHappyMax = new System.Windows.Forms.Label();
            this.lblClearCur = new System.Windows.Forms.Label();
            this.lblClearMax = new System.Windows.Forms.Label();
            this.lblXpCur = new System.Windows.Forms.Label();
            this.lblXpMax = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImage.BackgroundImage")));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.Location = new System.Drawing.Point(107, 124);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(275, 262);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // pbEat
            // 
            this.pbEat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEat.BackgroundImage")));
            this.pbEat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEat.Location = new System.Drawing.Point(107, 39);
            this.pbEat.Name = "pbEat";
            this.pbEat.Size = new System.Drawing.Size(55, 52);
            this.pbEat.TabIndex = 1;
            this.pbEat.TabStop = false;
            // 
            // pbSleep
            // 
            this.pbSleep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSleep.BackgroundImage")));
            this.pbSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSleep.Location = new System.Drawing.Point(202, 39);
            this.pbSleep.Name = "pbSleep";
            this.pbSleep.Size = new System.Drawing.Size(55, 52);
            this.pbSleep.TabIndex = 1;
            this.pbSleep.TabStop = false;
            // 
            // pbHappy
            // 
            this.pbHappy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHappy.BackgroundImage")));
            this.pbHappy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHappy.Location = new System.Drawing.Point(301, 40);
            this.pbHappy.Name = "pbHappy";
            this.pbHappy.Size = new System.Drawing.Size(55, 52);
            this.pbHappy.TabIndex = 1;
            this.pbHappy.TabStop = false;
            // 
            // pbClear
            // 
            this.pbClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClear.BackgroundImage")));
            this.pbClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbClear.Location = new System.Drawing.Point(404, 40);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(55, 52);
            this.pbClear.TabIndex = 1;
            this.pbClear.TabStop = false;
            // 
            // pbXp
            // 
            this.pbXp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbXp.BackgroundImage")));
            this.pbXp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbXp.Location = new System.Drawing.Point(507, 39);
            this.pbXp.Name = "pbXp";
            this.pbXp.Size = new System.Drawing.Size(55, 52);
            this.pbXp.TabIndex = 1;
            this.pbXp.TabStop = false;
            this.pbXp.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // btnEat
            // 
            this.btnEat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEat.BackgroundImage")));
            this.btnEat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEat.Location = new System.Drawing.Point(404, 124);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(93, 112);
            this.btnEat.TabIndex = 2;
            this.btnEat.Text = " ";
            this.btnEat.UseVisualStyleBackColor = true;
            // 
            // btnHappy
            // 
            this.btnHappy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHappy.BackgroundImage")));
            this.btnHappy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHappy.Location = new System.Drawing.Point(404, 274);
            this.btnHappy.Name = "btnHappy";
            this.btnHappy.Size = new System.Drawing.Size(93, 112);
            this.btnHappy.TabIndex = 2;
            this.btnHappy.Text = " ";
            this.btnHappy.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.Location = new System.Drawing.Point(520, 274);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 112);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = " ";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSleep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSleep.BackgroundImage")));
            this.btnSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSleep.Location = new System.Drawing.Point(520, 124);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(93, 112);
            this.btnSleep.TabIndex = 2;
            this.btnSleep.Text = " ";
            this.btnSleep.UseVisualStyleBackColor = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // lbleatCur
            // 
            this.lbleatCur.AutoSize = true;
            this.lbleatCur.Location = new System.Drawing.Point(172, 41);
            this.lbleatCur.Name = "lbleatCur";
            this.lbleatCur.Size = new System.Drawing.Size(0, 13);
            this.lbleatCur.TabIndex = 3;
            // 
            // lblEatMax
            // 
            this.lblEatMax.AutoSize = true;
            this.lblEatMax.Location = new System.Drawing.Point(173, 68);
            this.lblEatMax.Name = "lblEatMax";
            this.lblEatMax.Size = new System.Drawing.Size(9, 13);
            this.lblEatMax.TabIndex = 4;
            this.lblEatMax.Text = "l";
            // 
            // lblSleepCur
            // 
            this.lblSleepCur.AutoSize = true;
            this.lblSleepCur.Location = new System.Drawing.Point(262, 41);
            this.lblSleepCur.Name = "lblSleepCur";
            this.lblSleepCur.Size = new System.Drawing.Size(35, 13);
            this.lblSleepCur.TabIndex = 3;
            this.lblSleepCur.Text = "label1";
            // 
            // lblSleepMax
            // 
            this.lblSleepMax.AutoSize = true;
            this.lblSleepMax.Location = new System.Drawing.Point(263, 68);
            this.lblSleepMax.Name = "lblSleepMax";
            this.lblSleepMax.Size = new System.Drawing.Size(35, 13);
            this.lblSleepMax.TabIndex = 4;
            this.lblSleepMax.Text = "label2";
            // 
            // lblHappyCur
            // 
            this.lblHappyCur.AutoSize = true;
            this.lblHappyCur.Location = new System.Drawing.Point(361, 41);
            this.lblHappyCur.Name = "lblHappyCur";
            this.lblHappyCur.Size = new System.Drawing.Size(35, 13);
            this.lblHappyCur.TabIndex = 3;
            this.lblHappyCur.Text = "label1";
            // 
            // lblHappyMax
            // 
            this.lblHappyMax.AutoSize = true;
            this.lblHappyMax.Location = new System.Drawing.Point(362, 68);
            this.lblHappyMax.Name = "lblHappyMax";
            this.lblHappyMax.Size = new System.Drawing.Size(35, 13);
            this.lblHappyMax.TabIndex = 4;
            this.lblHappyMax.Text = "label2";
            // 
            // lblClearCur
            // 
            this.lblClearCur.AutoSize = true;
            this.lblClearCur.Location = new System.Drawing.Point(461, 41);
            this.lblClearCur.Name = "lblClearCur";
            this.lblClearCur.Size = new System.Drawing.Size(35, 13);
            this.lblClearCur.TabIndex = 3;
            this.lblClearCur.Text = "label1";
            // 
            // lblClearMax
            // 
            this.lblClearMax.AutoSize = true;
            this.lblClearMax.Location = new System.Drawing.Point(462, 68);
            this.lblClearMax.Name = "lblClearMax";
            this.lblClearMax.Size = new System.Drawing.Size(35, 13);
            this.lblClearMax.TabIndex = 4;
            this.lblClearMax.Text = "label2";
            // 
            // lblXpCur
            // 
            this.lblXpCur.AutoSize = true;
            this.lblXpCur.Location = new System.Drawing.Point(567, 41);
            this.lblXpCur.Name = "lblXpCur";
            this.lblXpCur.Size = new System.Drawing.Size(35, 13);
            this.lblXpCur.TabIndex = 3;
            this.lblXpCur.Text = "label1";
            // 
            // lblXpMax
            // 
            this.lblXpMax.AutoSize = true;
            this.lblXpMax.Location = new System.Drawing.Point(568, 68);
            this.lblXpMax.Name = "lblXpMax";
            this.lblXpMax.Size = new System.Drawing.Size(35, 13);
            this.lblXpMax.TabIndex = 4;
            this.lblXpMax.Text = "label2";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Location = new System.Drawing.Point(127, 369);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 13);
            this.lblGameOver.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblXpMax);
            this.Controls.Add(this.lblXpCur);
            this.Controls.Add(this.lblClearMax);
            this.Controls.Add(this.lblClearCur);
            this.Controls.Add(this.lblHappyMax);
            this.Controls.Add(this.lblHappyCur);
            this.Controls.Add(this.lblSleepMax);
            this.Controls.Add(this.lblSleepCur);
            this.Controls.Add(this.lblEatMax);
            this.Controls.Add(this.lbleatCur);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHappy);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.pbXp);
            this.Controls.Add(this.pbClear);
            this.Controls.Add(this.pbHappy);
            this.Controls.Add(this.pbSleep);
            this.Controls.Add(this.pbEat);
            this.Controls.Add(this.pbImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbEat;
        private System.Windows.Forms.PictureBox pbSleep;
        private System.Windows.Forms.PictureBox pbHappy;
        private System.Windows.Forms.PictureBox pbClear;
        private System.Windows.Forms.PictureBox pbXp;
        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.Button btnHappy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Label lbleatCur;
        private System.Windows.Forms.Label lblEatMax;
        private System.Windows.Forms.Label lblSleepCur;
        private System.Windows.Forms.Label lblSleepMax;
        private System.Windows.Forms.Label lblHappyCur;
        private System.Windows.Forms.Label lblHappyMax;
        private System.Windows.Forms.Label lblClearCur;
        private System.Windows.Forms.Label lblClearMax;
        private System.Windows.Forms.Label lblXpCur;
        private System.Windows.Forms.Label lblXpMax;
        private System.Windows.Forms.Label lblGameOver;
    }
}

