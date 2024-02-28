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
            panel1 = new Panel();
            sendMessage = new Button();
            retry = new CheckBox();
            label2 = new Label();
            timing = new Label();
            timingBox = new TextBox();
            countBox = new TextBox();
            textBox1 = new TextBox();
            ipName = new Label();
            sizeInByte = new DataGridViewTextBoxColumn();
            lenght = new DataGridViewTextBoxColumn();
            message = new DataGridViewTextBoxColumn();
            idMessage = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            labelCountMessages = new Label();
            portName = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            labelCountBites = new Label();
            countBites = new TextBox();
            countMessages = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(139, 404);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 260);
            panel1.TabIndex = 42;
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
            // timingBox
            // 
            timingBox.Anchor = AnchorStyles.None;
            timingBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timingBox.Location = new Point(479, 597);
            timingBox.Name = "timingBox";
            timingBox.Size = new Size(45, 27);
            timingBox.TabIndex = 38;
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
            // sizeInByte
            // 
            sizeInByte.HeaderText = "Количество байтов";
            sizeInByte.Name = "sizeInByte";
            // 
            // lenght
            // 
            lenght.HeaderText = "Длина";
            lenght.Name = "lenght";
            // 
            // message
            // 
            message.HeaderText = "Сообщение";
            message.Name = "message";
            // 
            // idMessage
            // 
            idMessage.HeaderText = "id";
            idMessage.Name = "idMessage";
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
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(223, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(59, 27);
            textBox2.TabIndex = 28;
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

        private Panel panel1;
        private Button sendMessage;
        private CheckBox retry;
        private Label label2;
        private Label timing;
        private TextBox timingBox;
        private TextBox countBox;
        private TextBox textBox1;
        private Label ipName;
        private DataGridViewTextBoxColumn sizeInByte;
        private DataGridViewTextBoxColumn lenght;
        private DataGridViewTextBoxColumn message;
        private DataGridViewTextBoxColumn idMessage;
        private DataGridView dataGridView1;
        private Label labelCountMessages;
        private Label portName;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelCountBites;
        private TextBox countBites;
        private TextBox countMessages;
        private Panel panel2;
    }
}