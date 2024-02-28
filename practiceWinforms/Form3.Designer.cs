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
            timing = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            sendMessage = new Button();
            countBox = new TextBox();
            retry = new CheckBox();
            timingBox = new TextBox();
            dataGridView1 = new DataGridView();
            idMessage = new DataGridViewTextBoxColumn();
            message = new DataGridViewTextBoxColumn();
            lenght = new DataGridViewTextBoxColumn();
            sizeInByte = new DataGridViewTextBoxColumn();
            portName = new Label();
            ipName = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            labelCountBites = new Label();
            countBites = new TextBox();
            countMessages = new TextBox();
            portValue = new TextBox();
            ipValue = new TextBox();
            label1 = new Label();
            labelCountMessages = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(timing);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(sendMessage);
            panel1.Controls.Add(countBox);
            panel1.Controls.Add(retry);
            panel1.Controls.Add(timingBox);
            panel1.Location = new Point(0, 419);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 387);
            panel1.TabIndex = 42;
            // 
            // timing
            // 
            timing.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            timing.AutoSize = true;
            timing.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timing.Location = new Point(542, 265);
            timing.Name = "timing";
            timing.Size = new Size(75, 20);
            timing.TabIndex = 44;
            timing.Text = "задержка";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(529, 293);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 43;
            label2.Text = "количество";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(176, 69);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(439, 120);
            textBox1.TabIndex = 47;
            textBox1.Text = "Сообщение";
            // 
            // sendMessage
            // 
            sendMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sendMessage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sendMessage.Location = new Point(174, 271);
            sendMessage.Name = "sendMessage";
            sendMessage.Size = new Size(98, 38);
            sendMessage.TabIndex = 41;
            sendMessage.Text = "Отправить";
            sendMessage.UseVisualStyleBackColor = true;
            // 
            // countBox
            // 
            countBox.Anchor = AnchorStyles.Right;
            countBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countBox.Location = new Point(478, 290);
            countBox.Name = "countBox";
            countBox.Size = new Size(45, 27);
            countBox.TabIndex = 46;
            // 
            // retry
            // 
            retry.Anchor = AnchorStyles.Right;
            retry.AutoSize = true;
            retry.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            retry.Location = new Point(394, 279);
            retry.Name = "retry";
            retry.Size = new Size(78, 24);
            retry.TabIndex = 42;
            retry.Text = "повтор";
            retry.UseVisualStyleBackColor = true;
            // 
            // timingBox
            // 
            timingBox.Anchor = AnchorStyles.Right;
            timingBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timingBox.Location = new Point(478, 262);
            timingBox.Name = "timingBox";
            timingBox.Size = new Size(45, 27);
            timingBox.TabIndex = 45;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idMessage, message, lenght, sizeInByte });
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(182, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(439, 266);
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
            // portName
            // 
            portName.Anchor = AnchorStyles.None;
            portName.AutoSize = true;
            portName.Font = new Font("Segoe UI", 11.25F);
            portName.Location = new Point(534, -49);
            portName.Name = "portName";
            portName.Size = new Size(37, 20);
            portName.TabIndex = 1;
            portName.Text = "port";
            // 
            // ipName
            // 
            ipName.Anchor = AnchorStyles.Left;
            ipName.AutoSize = true;
            ipName.Font = new Font("Segoe UI", 11.25F);
            ipName.Location = new Point(178, 32);
            ipName.Name = "ipName";
            ipName.Size = new Size(22, 20);
            ipName.TabIndex = 32;
            ipName.Text = "ip";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(221, -56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(59, 27);
            textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(577, -56);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(59, 27);
            textBox3.TabIndex = 29;
            // 
            // labelCountBites
            // 
            labelCountBites.Anchor = AnchorStyles.None;
            labelCountBites.AutoSize = true;
            labelCountBites.Font = new Font("Segoe UI", 11.25F);
            labelCountBites.Location = new Point(463, 341);
            labelCountBites.Name = "labelCountBites";
            labelCountBites.Size = new Size(89, 20);
            labelCountBites.TabIndex = 15;
            labelCountBites.Text = "Итого байт:";
            // 
            // countBites
            // 
            countBites.Anchor = AnchorStyles.None;
            countBites.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countBites.Location = new Point(558, 338);
            countBites.Name = "countBites";
            countBites.ReadOnly = true;
            countBites.Size = new Size(59, 27);
            countBites.TabIndex = 27;
            // 
            // countMessages
            // 
            countMessages.Anchor = AnchorStyles.None;
            countMessages.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countMessages.Location = new Point(318, 338);
            countMessages.Name = "countMessages";
            countMessages.ReadOnly = true;
            countMessages.Size = new Size(59, 27);
            countMessages.TabIndex = 26;
            // 
            // portValue
            // 
            portValue.Anchor = AnchorStyles.Right;
            portValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            portValue.Location = new Point(562, 29);
            portValue.Name = "portValue";
            portValue.Size = new Size(59, 27);
            portValue.TabIndex = 35;
            portValue.TextChanged += portValue_TextChanged;
            // 
            // ipValue
            // 
            ipValue.Anchor = AnchorStyles.Left;
            ipValue.BackColor = SystemColors.ControlLightLight;
            ipValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ipValue.Location = new Point(206, 29);
            ipValue.Name = "ipValue";
            ipValue.Size = new Size(59, 27);
            ipValue.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(519, 32);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 34;
            label1.Text = "port";

            // 
            // labelCountMessages
            // 
            labelCountMessages.Anchor = AnchorStyles.None;
            labelCountMessages.AutoSize = true;
            labelCountMessages.Font = new Font("Segoe UI", 11.25F);
            labelCountMessages.Location = new Point(180, 341);
            labelCountMessages.Name = "labelCountMessages";
            labelCountMessages.Size = new Size(138, 20);
            labelCountMessages.TabIndex = 42;
            labelCountMessages.Text = "Итого сообщений:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(labelCountMessages);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ipValue);
            panel2.Controls.Add(portValue);
            panel2.Controls.Add(countMessages);
            panel2.Controls.Add(countBites);
            panel2.Controls.Add(labelCountBites);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(ipName);
            panel2.Controls.Add(portName);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(807, 392);
            panel2.TabIndex = 43;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(824, 785);
            panel3.TabIndex = 44;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(821, 785);
            Controls.Add(panel3);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idMessage;
        private DataGridViewTextBoxColumn message;
        private DataGridViewTextBoxColumn lenght;
        private DataGridViewTextBoxColumn sizeInByte;
        private Label portName;
        private Label ipName;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelCountBites;
        private TextBox countBites;
        private TextBox countMessages;
        private TextBox portValue;
        private TextBox ipValue;
        private Label label1;
        private Label labelCountMessages;
        private Panel panel2;
        private Panel panel3;
        private Label timing;
        private Label label2;
        private TextBox textBox1;
        private Button sendMessage;
        private TextBox countBox;
        private CheckBox retry;
        private TextBox timingBox;
    }
}