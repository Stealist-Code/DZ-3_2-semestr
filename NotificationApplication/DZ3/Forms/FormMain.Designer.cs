namespace NotificationApplication
{
    partial class FormMain
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
            textBoxInput = new TextBox();
            comboBoxSelectNotification = new ComboBox();
            buttonSendNotification = new Button();
            richTextBox = new RichTextBox();
            labelTextBox = new Label();
            label1 = new Label();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(340, 154);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(207, 27);
            textBoxInput.TabIndex = 0;
            // 
            // comboBoxSelectNotification
            // 
            comboBoxSelectNotification.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectNotification.FormattingEnabled = true;
            comboBoxSelectNotification.Location = new Point(340, 233);
            comboBoxSelectNotification.Name = "comboBoxSelectNotification";
            comboBoxSelectNotification.Size = new Size(207, 28);
            comboBoxSelectNotification.TabIndex = 1;
            // 
            // buttonSendNotification
            // 
            buttonSendNotification.Location = new Point(340, 310);
            buttonSendNotification.Name = "buttonSendNotification";
            buttonSendNotification.Size = new Size(177, 29);
            buttonSendNotification.TabIndex = 2;
            buttonSendNotification.Text = "Отправить сообщение";
            buttonSendNotification.UseVisualStyleBackColor = true;
            buttonSendNotification.Click += buttonSendNotification_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(12, 115);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(296, 318);
            richTextBox.TabIndex = 4;
            richTextBox.Text = "";
            // 
            // labelTextBox
            // 
            labelTextBox.AutoSize = true;
            labelTextBox.Location = new Point(340, 131);
            labelTextBox.Name = "labelTextBox";
            labelTextBox.Size = new Size(149, 20);
            labelTextBox.TabIndex = 5;
            labelTextBox.Text = "Введите сообщение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 210);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 6;
            label1.Text = "Выберите тип уведомления";
            // 
            // pictureBox
            // 
            pictureBox.InitialImage = null;
            pictureBox.Location = new Point(598, 28);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(286, 485);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 7;
            pictureBox.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 549);
            Controls.Add(pictureBox);
            Controls.Add(label1);
            Controls.Add(labelTextBox);
            Controls.Add(richTextBox);
            Controls.Add(buttonSendNotification);
            Controls.Add(comboBoxSelectNotification);
            Controls.Add(textBoxInput);
            Name = "FormMain";
            Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private ComboBox comboBoxSelectNotification;
        private Button buttonSendNotification;
        private RichTextBox richTextBox;
        private Label labelTextBox;
        private Label label1;
        internal PictureBox pictureBox;
    }
}
