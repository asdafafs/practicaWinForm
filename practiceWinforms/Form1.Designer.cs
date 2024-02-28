namespace practiceWinforms
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
            ipName = new Label();
            dataGridView1 = new DataGridView();
            idMessage = new DataGridViewTextBoxColumn();
            message = new DataGridViewTextBoxColumn();
            lenght = new DataGridViewTextBoxColumn();
            sizeInByte = new DataGridViewTextBoxColumn();
            sendMessage = new Button();
            retry = new CheckBox();
            label2 = new Label();
            timing = new Label();
            timingBox = new TextBox();
            countBox = new TextBox();
            textBox1 = new TextBox();
            labelCountMessages = new Label();
            portName = new Label();
            portValue = new TextBox();
            ipValue = new TextBox();
            labelCountBites = new Label();
            countBites = new TextBox();
            countMessages = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ipName
            // 
            ipName.Anchor = AnchorStyles.Left;
            ipName.AutoSize = true;
            ipName.Font = new Font("Segoe UI", 11.25F);
            ipName.Location = new Point(11, 9);
            ipName.Name = "ipName";
            ipName.Size = new Size(22, 20);
            ipName.TabIndex = 0;
            ipName.Text = "ip";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idMessage, message, lenght, sizeInByte });
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(0, 13);
            dataGridView1.MinimumSize = new Size(0, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(369, 253);
            dataGridView1.TabIndex = 4;
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
            // sendMessage
            // 
            sendMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sendMessage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sendMessage.Location = new Point(11, 10);
            sendMessage.Name = "sendMessage";
            sendMessage.Size = new Size(98, 38);
            sendMessage.TabIndex = 5;
            sendMessage.Text = "Отправить";
            sendMessage.UseVisualStyleBackColor = true;
            sendMessage.Click += sendMessage_Click;
            // 
            // retry
            // 
            retry.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            retry.AutoSize = true;
            retry.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            retry.Location = new Point(142, 17);
            retry.Name = "retry";
            retry.Size = new Size(78, 24);
            retry.TabIndex = 6;
            retry.Text = "повтор";
            retry.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(277, 36);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 7;
            label2.Text = "количество";
            // 
            // timing
            // 
            timing.Anchor = AnchorStyles.Right;
            timing.AutoSize = true;
            timing.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timing.Location = new Point(290, 6);
            timing.Name = "timing";
            timing.Size = new Size(75, 20);
            timing.TabIndex = 8;
            timing.Text = "задержка";
            // 
            // timingBox
            // 
            timingBox.Anchor = AnchorStyles.Right;
            timingBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timingBox.Location = new Point(226, 3);
            timingBox.Name = "timingBox";
            timingBox.Size = new Size(45, 27);
            timingBox.TabIndex = 9;
            // 
            // countBox
            // 
            countBox.Anchor = AnchorStyles.Right;
            countBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countBox.Location = new Point(226, 33);
            countBox.Name = "countBox";
            countBox.Size = new Size(45, 27);
            countBox.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(48, 390);
            textBox1.MinimumSize = new Size(0, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 161);
            textBox1.TabIndex = 11;
            textBox1.Text = "Сообщение";
            // 
            // labelCountMessages
            // 
            labelCountMessages.Anchor = AnchorStyles.Left;
            labelCountMessages.AutoSize = true;
            labelCountMessages.Font = new Font("Segoe UI", 11.25F);
            labelCountMessages.Location = new Point(0, 13);
            labelCountMessages.Name = "labelCountMessages";
            labelCountMessages.Size = new Size(138, 20);
            labelCountMessages.TabIndex = 13;
            labelCountMessages.Text = "Итого сообщений:";
            // 
            // portName
            // 
            portName.Anchor = AnchorStyles.Right;
            portName.AutoSize = true;
            portName.Font = new Font("Segoe UI", 11.25F);
            portName.Location = new Point(265, 9);
            portName.Name = "portName";
            portName.Size = new Size(37, 20);
            portName.TabIndex = 1;
            portName.Text = "port";
            // 
            // portValue
            // 
            portValue.Anchor = AnchorStyles.Right;
            portValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            portValue.Location = new Point(308, 6);
            portValue.Name = "portValue";
            portValue.Size = new Size(59, 27);
            portValue.TabIndex = 28;
            // 
            // ipValue
            // 
            ipValue.Anchor = AnchorStyles.Left;
            ipValue.BackColor = SystemColors.ControlLightLight;
            ipValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ipValue.Location = new Point(39, 5);
            ipValue.Name = "ipValue";
            ipValue.Size = new Size(59, 27);
            ipValue.TabIndex = 29;
            // 
            // labelCountBites
            // 
            labelCountBites.Anchor = AnchorStyles.Right;
            labelCountBites.AutoSize = true;
            labelCountBites.Font = new Font("Segoe UI", 11.25F);
            labelCountBites.Location = new Point(214, 13);
            labelCountBites.Name = "labelCountBites";
            labelCountBites.Size = new Size(89, 20);
            labelCountBites.TabIndex = 15;
            labelCountBites.Text = "Итого байт:";
            // 
            // countBites
            // 
            countBites.Anchor = AnchorStyles.Right;
            countBites.BackColor = SystemColors.ButtonHighlight;
            countBites.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countBites.Location = new Point(309, 10);
            countBites.Name = "countBites";
            countBites.ReadOnly = true;
            countBites.Size = new Size(59, 27);
            countBites.TabIndex = 27;
            // 
            // countMessages
            // 
            countMessages.Anchor = AnchorStyles.Left;
            countMessages.BackColor = SystemColors.ButtonHighlight;
            countMessages.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countMessages.Location = new Point(144, 10);
            countMessages.Name = "countMessages";
            countMessages.ReadOnly = true;
            countMessages.Size = new Size(59, 27);
            countMessages.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(portName);
            panel1.Controls.Add(ipValue);
            panel1.Controls.Add(portValue);
            panel1.Controls.Add(ipName);
            panel1.Location = new Point(48, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 39);
            panel1.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(labelCountBites);
            panel3.Controls.Add(labelCountMessages);
            panel3.Controls.Add(countBites);
            panel3.Controls.Add(countMessages);
            panel3.Location = new Point(48, 322);
            panel3.MinimumSize = new Size(370, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 45);
            panel3.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.Location = new Point(48, 373);
            panel4.Name = "panel4";
            panel4.Size = new Size(369, 181);
            panel4.TabIndex = 33;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(sendMessage);
            panel5.Controls.Add(countBox);
            panel5.Controls.Add(retry);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(timingBox);
            panel5.Controls.Add(timing);
            panel5.Location = new Point(48, 568);
            panel5.MinimumSize = new Size(370, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(370, 65);
            panel5.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(48, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 266);
            panel2.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(468, 781);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ipName;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idMessage;
        private DataGridViewTextBoxColumn message;
        private DataGridViewTextBoxColumn lenght;
        private DataGridViewTextBoxColumn sizeInByte;
        private Button sendMessage;
        private CheckBox retry;
        private Label label2;
        private Label timing;
        private TextBox timingBox;
        private TextBox countBox;
        private TextBox textBox1;
        private Label labelCountMessages;
        private Label portName;
        private TextBox portValue;
        private TextBox ipValue;
        private Label labelCountBites;
        private TextBox countBites;
        private TextBox countMessages;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel2;
    }
}
