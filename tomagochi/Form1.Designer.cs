
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
            this.components = new System.ComponentModel.Container();
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pbQ1 = new System.Windows.Forms.PictureBox();
            this.pbQ2 = new System.Windows.Forms.PictureBox();
            this.pbQ3 = new System.Windows.Forms.PictureBox();
            this.pbQ4 = new System.Windows.Forms.PictureBox();
            this.pbQ5 = new System.Windows.Forms.PictureBox();
            this.pbQ6 = new System.Windows.Forms.PictureBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QTimer = new System.Windows.Forms.Timer(this.components);
            this.pbStack1 = new System.Windows.Forms.PictureBox();
            this.pbStack2 = new System.Windows.Forms.PictureBox();
            this.pbStack3 = new System.Windows.Forms.PictureBox();
            this.pbStack4 = new System.Windows.Forms.PictureBox();
            this.pbStack5 = new System.Windows.Forms.PictureBox();
            this.pbStack6 = new System.Windows.Forms.PictureBox();
            this.btnStack = new System.Windows.Forms.Button();
            this.STACK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack6)).BeginInit();
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
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
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
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
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
            this.btnHappy.Click += new System.EventHandler(this.btnHappy_Click);
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
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.lblEatMax.Size = new System.Drawing.Size(0, 13);
            this.lblEatMax.TabIndex = 4;
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
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameOver.Location = new System.Drawing.Point(169, 389);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(411, 42);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "Он умер , это ужасно:(";
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // pbQ1
            // 
            this.pbQ1.Location = new System.Drawing.Point(657, 56);
            this.pbQ1.Name = "pbQ1";
            this.pbQ1.Size = new System.Drawing.Size(46, 41);
            this.pbQ1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQ1.TabIndex = 6;
            this.pbQ1.TabStop = false;
            // 
            // pbQ2
            // 
            this.pbQ2.Location = new System.Drawing.Point(657, 114);
            this.pbQ2.Name = "pbQ2";
            this.pbQ2.Size = new System.Drawing.Size(46, 41);
            this.pbQ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQ2.TabIndex = 6;
            this.pbQ2.TabStop = false;
            // 
            // pbQ3
            // 
            this.pbQ3.Location = new System.Drawing.Point(657, 172);
            this.pbQ3.Name = "pbQ3";
            this.pbQ3.Size = new System.Drawing.Size(46, 41);
            this.pbQ3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQ3.TabIndex = 6;
            this.pbQ3.TabStop = false;
            // 
            // pbQ4
            // 
            this.pbQ4.Location = new System.Drawing.Point(657, 231);
            this.pbQ4.Name = "pbQ4";
            this.pbQ4.Size = new System.Drawing.Size(46, 41);
            this.pbQ4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQ4.TabIndex = 6;
            this.pbQ4.TabStop = false;
            // 
            // pbQ5
            // 
            this.pbQ5.Location = new System.Drawing.Point(657, 289);
            this.pbQ5.Name = "pbQ5";
            this.pbQ5.Size = new System.Drawing.Size(46, 41);
            this.pbQ5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQ5.TabIndex = 6;
            this.pbQ5.TabStop = false;
            // 
            // pbQ6
            // 
            this.pbQ6.Location = new System.Drawing.Point(657, 345);
            this.pbQ6.Name = "pbQ6";
            this.pbQ6.Size = new System.Drawing.Size(46, 41);
            this.pbQ6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQ6.TabIndex = 6;
            this.pbQ6.TabStop = false;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(640, 392);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(80, 38);
            this.btnAction.TabIndex = 7;
            this.btnAction.Text = "Сделать";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(632, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Очередь";
            // 
            // QTimer
            // 
            this.QTimer.Tick += new System.EventHandler(this.QTimer_Tick);
            // 
            // pbStack1
            // 
            this.pbStack1.Location = new System.Drawing.Point(755, 56);
            this.pbStack1.Name = "pbStack1";
            this.pbStack1.Size = new System.Drawing.Size(46, 41);
            this.pbStack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStack1.TabIndex = 6;
            this.pbStack1.TabStop = false;
            // 
            // pbStack2
            // 
            this.pbStack2.Location = new System.Drawing.Point(755, 114);
            this.pbStack2.Name = "pbStack2";
            this.pbStack2.Size = new System.Drawing.Size(46, 41);
            this.pbStack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStack2.TabIndex = 6;
            this.pbStack2.TabStop = false;
            // 
            // pbStack3
            // 
            this.pbStack3.Location = new System.Drawing.Point(755, 172);
            this.pbStack3.Name = "pbStack3";
            this.pbStack3.Size = new System.Drawing.Size(46, 41);
            this.pbStack3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStack3.TabIndex = 6;
            this.pbStack3.TabStop = false;
            // 
            // pbStack4
            // 
            this.pbStack4.Location = new System.Drawing.Point(755, 231);
            this.pbStack4.Name = "pbStack4";
            this.pbStack4.Size = new System.Drawing.Size(46, 41);
            this.pbStack4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStack4.TabIndex = 6;
            this.pbStack4.TabStop = false;
            // 
            // pbStack5
            // 
            this.pbStack5.Location = new System.Drawing.Point(755, 289);
            this.pbStack5.Name = "pbStack5";
            this.pbStack5.Size = new System.Drawing.Size(46, 41);
            this.pbStack5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStack5.TabIndex = 6;
            this.pbStack5.TabStop = false;
            // 
            // pbStack6
            // 
            this.pbStack6.Location = new System.Drawing.Point(755, 345);
            this.pbStack6.Name = "pbStack6";
            this.pbStack6.Size = new System.Drawing.Size(46, 41);
            this.pbStack6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStack6.TabIndex = 6;
            this.pbStack6.TabStop = false;
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(739, 392);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(80, 38);
            this.btnStack.TabIndex = 7;
            this.btnStack.Text = "Сделать";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // STACK
            // 
            this.STACK.AutoSize = true;
            this.STACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STACK.Location = new System.Drawing.Point(750, 28);
            this.STACK.Name = "STACK";
            this.STACK.Size = new System.Drawing.Size(59, 25);
            this.STACK.TabIndex = 8;
            this.STACK.Text = "Стэк";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.STACK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.pbQ6);
            this.Controls.Add(this.pbQ5);
            this.Controls.Add(this.pbQ4);
            this.Controls.Add(this.pbQ3);
            this.Controls.Add(this.pbQ2);
            this.Controls.Add(this.pbStack6);
            this.Controls.Add(this.pbStack5);
            this.Controls.Add(this.pbStack4);
            this.Controls.Add(this.pbStack3);
            this.Controls.Add(this.pbStack2);
            this.Controls.Add(this.pbStack1);
            this.Controls.Add(this.pbQ1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack6)).EndInit();
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
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pbQ1;
        private System.Windows.Forms.PictureBox pbQ2;
        private System.Windows.Forms.PictureBox pbQ3;
        private System.Windows.Forms.PictureBox pbQ4;
        private System.Windows.Forms.PictureBox pbQ5;
        private System.Windows.Forms.PictureBox pbQ6;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer QTimer;
        private System.Windows.Forms.PictureBox pbStack1;
        private System.Windows.Forms.PictureBox pbStack2;
        private System.Windows.Forms.PictureBox pbStack3;
        private System.Windows.Forms.PictureBox pbStack4;
        private System.Windows.Forms.PictureBox pbStack5;
        private System.Windows.Forms.PictureBox pbStack6;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Label STACK;
    }
}

