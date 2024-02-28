namespace practiceWinforms
{
    partial class Form3
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
            labelCountMessages = new Label();
            textBox1 = new TextBox();
            countBox = new TextBox();
            timingBox = new TextBox();
            timing = new Label();
            label2 = new Label();
            retry = new CheckBox();
            sendMessage = new Button();
            dataGridView1 = new DataGridView();
            idMessage = new DataGridViewTextBoxColumn();
            message = new DataGridViewTextBoxColumn();
            lenght = new DataGridViewTextBoxColumn();
            sizeInByte = new DataGridViewTextBoxColumn();
            ipName = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            countMessages = new TextBox();
            countBites = new TextBox();
            labelCountBites = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            portName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelCountMessages
            // 
            labelCountMessages.Anchor = AnchorStyles.None;
            labelCountMessages.AutoSize = true;
            labelCountMessages.Font = new Font("Segoe UI", 11.25F);
            labelCountMessages.Location = new Point(175, 329);
            labelCountMessages.Name = "labelCountMessages";
            labelCountMessages.Size = new Size(138, 20);
            labelCountMessages.TabIndex = 41;
            labelCountMessages.Text = "Итого сообщений:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(175, 404);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 120);
            textBox1.TabIndex = 40;
            textBox1.Text = "Сообщение";
            // 
            // countBox
            // 
            countBox.Anchor = AnchorStyles.None;
            countBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countBox.Location = new Point(479, 625);
            countBox.Name = "countBox";
            countBox.Size = new Size(45, 27);
            countBox.TabIndex = 39;
            // 
            // timingBox
            // 
            timingBox.Anchor = AnchorStyles.None;
            timingBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timingBox.Location = new Point(479, 597);
            timingBox.Name = "timingBox";
            timingBox.Size = new Size(45, 27);
            timingBox.TabIndex = 38;
            // 
            // timing
            // 
            timing.Anchor = AnchorStyles.None;
            timing.AutoSize = true;
            timing.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timing.Location = new Point(543, 600);
            timing.Name = "timing";
            timing.Size = new Size(75, 20);
            timing.TabIndex = 37;
            timing.Text = "задержка";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(530, 628);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 36;
            label2.Text = "количество";
            // 
            // retry
            // 
            retry.Anchor = AnchorStyles.None;
            retry.AutoSize = true;
            retry.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            retry.Location = new Point(395, 614);
            retry.Name = "retry";
            retry.Size = new Size(78, 24);
            retry.TabIndex = 35;
            retry.Text = "повтор";
            retry.UseVisualStyleBackColor = true;
            // 
            // sendMessage
            // 
            sendMessage.Anchor = AnchorStyles.None;
            sendMessage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sendMessage.Location = new Point(175, 606);
            sendMessage.Name = "sendMessage";
            sendMessage.Size = new Size(98, 38);
            sendMessage.TabIndex = 34;
            sendMessage.Text = "Отправить";
            sendMessage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idMessage, message, lenght, sizeInByte });
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(175, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 266);
            dataGridView1.TabIndex = 33;
            // 
            // idMessage
            // 
            idMessage.HeaderText = "id";
            idMessage.Name = "idMessage";
            // 
            // message
            // 
            message.HeaderText = "Сообщение";
            message.Name = "message";
            // 
            // lenght
            // 
            lenght.HeaderText = "Длина";
            lenght.Name = "lenght";
            // 
            // sizeInByte
            // 
            sizeInByte.HeaderText = "Количество байтов";
            sizeInByte.Name = "sizeInByte";
            // 
            // ipName
            // 
            ipName.Anchor = AnchorStyles.Left;
            ipName.AutoSize = true;
            ipName.Font = new Font("Segoe UI", 11.25F);
            ipName.Location = new Point(175, 27);
            ipName.Name = "ipName";
            ipName.Size = new Size(22, 20);
            ipName.TabIndex = 32;
            ipName.Text = "ip";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(139, 404);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 260);
            panel1.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(countMessages);
            panel2.Controls.Add(countBites);
            panel2.Controls.Add(labelCountBites);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(portName);
            panel2.Location = new Point(139, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 365);
            panel2.TabIndex = 43;
            // 
            // countMessages
            // 
            countMessages.Anchor = AnchorStyles.None;
            countMessages.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countMessages.Location = new Point(339, 446);
            countMessages.Name = "countMessages";
            countMessages.ReadOnly = true;
            countMessages.Size = new Size(59, 27);
            countMessages.TabIndex = 26;
            // 
            // countBites
            // 
            countBites.Anchor = AnchorStyles.None;
            countBites.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countBites.Location = new Point(579, 446);
            countBites.Name = "countBites";
            countBites.ReadOnly = true;
            countBites.Size = new Size(59, 27);
            countBites.TabIndex = 27;
            // 
            // labelCountBites
            // 
            labelCountBites.Anchor = AnchorStyles.None;
            labelCountBites.AutoSize = true;
            labelCountBites.Font = new Font("Segoe UI", 11.25F);
            labelCountBites.Location = new Point(484, 449);
            labelCountBites.Name = "labelCountBites";
            labelCountBites.Size = new Size(89, 20);
            labelCountBites.TabIndex = 15;
            labelCountBites.Text = "Итого байт:";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(579, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(59, 27);
            textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(223, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(59, 27);
            textBox2.TabIndex = 28;
            // 
            // portName
            // 
            portName.Anchor = AnchorStyles.None;
            portName.AutoSize = true;
            portName.Font = new Font("Segoe UI", 11.25F);
            portName.Location = new Point(536, 147);
            portName.Name = "portName";
            portName.Size = new Size(37, 20);
            portName.TabIndex = 1;
            portName.Text = "port";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(794, 785);
            Controls.Add(labelCountMessages);
            Controls.Add(textBox1);
            Controls.Add(countBox);
            Controls.Add(timingBox);
            Controls.Add(timing);
            Controls.Add(label2);
            Controls.Add(retry);
            Controls.Add(sendMessage);
            Controls.Add(dataGridView1);
            Controls.Add(ipName);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCountMessages;
        private TextBox textBox1;
        private TextBox countBox;
        private TextBox timingBox;
        private Label timing;
        private Label label2;
        private CheckBox retry;
        private Button sendMessage;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idMessage;
        private DataGridViewTextBoxColumn message;
        private DataGridViewTextBoxColumn lenght;
        private DataGridViewTextBoxColumn sizeInByte;
        private Label ipName;
        private Panel panel1;
        private Panel panel2;
        private TextBox countMessages;
        private TextBox countBites;
        private Label labelCountBites;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label portName;
    }
}