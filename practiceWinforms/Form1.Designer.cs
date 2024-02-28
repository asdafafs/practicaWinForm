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
            sendMessage = new Button();
            retry = new CheckBox();
            label2 = new Label();
            timing = new Label();
            timingBox = new TextBox();
            countBox = new TextBox();
            textBox1 = new TextBox();
            portName = new Label();
            portValue = new TextBox();
            ipValue = new TextBox();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            idMessage = new DataGridViewTextBoxColumn();
            message = new DataGridViewTextBoxColumn();
            lenght = new DataGridViewTextBoxColumn();
            sizeInByte = new DataGridViewTextBoxColumn();
            labelCountMessages = new Label();
            countMessages = new TextBox();
            countBites = new TextBox();
            labelCountBites = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            // sendMessage
            // 
            sendMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sendMessage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sendMessage.Location = new Point(8, 13);
            sendMessage.Name = "sendMessage";
            sendMessage.Padding = new Padding(3);
            sendMessage.Size = new Size(196, 38);
            sendMessage.TabIndex = 5;
            sendMessage.Text = "Отправить";
            sendMessage.UseVisualStyleBackColor = true;
            sendMessage.Click += sendMessage_Click;
            // 
            // retry
            // 
            retry.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            retry.AutoSize = true;
            retry.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            retry.Location = new Point(243, 14);
            retry.Name = "retry";
            retry.Size = new Size(78, 24);
            retry.TabIndex = 6;
            retry.Text = "повтор";
            retry.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(378, 36);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 7;
            label2.Text = "количество";
            // 
            // timing
            // 
            timing.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            timing.AutoSize = true;
            timing.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timing.Location = new Point(391, 6);
            timing.Name = "timing";
            timing.Size = new Size(75, 20);
            timing.TabIndex = 8;
            timing.Text = "задержка";
            // 
            // timingBox
            // 
            timingBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            timingBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timingBox.Location = new Point(327, 3);
            timingBox.Name = "timingBox";
            timingBox.Size = new Size(45, 27);
            timingBox.TabIndex = 9;
            // 
            // countBox
            // 
            countBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            countBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countBox.Location = new Point(327, 33);
            countBox.Name = "countBox";
            countBox.Size = new Size(45, 27);
            countBox.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(0);
            textBox1.MinimumSize = new Size(0, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 60);
            textBox1.TabIndex = 11;
            textBox1.Text = "Сообщение";
            // 
            // portName
            // 
            portName.Anchor = AnchorStyles.Right;
            portName.AutoSize = true;
            portName.Font = new Font("Segoe UI", 11.25F);
            portName.Location = new Point(364, 9);
            portName.Name = "portName";
            portName.Size = new Size(37, 20);
            portName.TabIndex = 1;
            portName.Text = "port";
            // 
            // portValue
            // 
            portValue.Anchor = AnchorStyles.Right;
            portValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            portValue.Location = new Point(407, 6);
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
            // panel1
            // 
            panel1.Controls.Add(portName);
            panel1.Controls.Add(ipValue);
            panel1.Controls.Add(portValue);
            panel1.Controls.Add(ipName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 39);
            panel1.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(30, 560);
            panel4.Margin = new Padding(30, 30, 30, 80);
            panel4.MaximumSize = new Size(0, 240);
            panel4.MinimumSize = new Size(0, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(408, 60);
            panel4.TabIndex = 33;
            // 
            // panel5
            // 
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(sendMessage);
            panel5.Controls.Add(countBox);
            panel5.Controls.Add(retry);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(timingBox);
            panel5.Controls.Add(timing);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 716);
            panel5.MinimumSize = new Size(370, 65);
            panel5.Name = "panel5";
            panel5.Size = new Size(468, 65);
            panel5.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(30, 0);
            panel2.Margin = new Padding(30, 0, 30, 0);
            panel2.MinimumSize = new Size(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 427);
            panel2.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idMessage, message, lenght, sizeInByte });
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.MinimumSize = new Size(0, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(408, 346);
            dataGridView1.TabIndex = 25;
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
            // labelCountMessages
            // 
            labelCountMessages.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCountMessages.AutoSize = true;
            labelCountMessages.Font = new Font("Segoe UI", 11.25F);
            labelCountMessages.Location = new Point(-2, 5);
            labelCountMessages.Margin = new Padding(5, 5, 5, 0);
            labelCountMessages.Name = "labelCountMessages";
            labelCountMessages.Size = new Size(138, 20);
            labelCountMessages.TabIndex = 35;
            labelCountMessages.Text = "Итого сообщений:";
            // 
            // countMessages
            // 
            countMessages.Anchor = AnchorStyles.Left;
            countMessages.BackColor = SystemColors.ButtonHighlight;
            countMessages.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countMessages.Location = new Point(137, 2);
            countMessages.Margin = new Padding(5, 5, 5, 0);
            countMessages.Name = "countMessages";
            countMessages.ReadOnly = true;
            countMessages.Size = new Size(59, 27);
            countMessages.TabIndex = 36;
            // 
            // countBites
            // 
            countBites.Anchor = AnchorStyles.Right;
            countBites.BackColor = SystemColors.Window;
            countBites.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countBites.Location = new Point(347, 2);
            countBites.Margin = new Padding(5);
            countBites.Name = "countBites";
            countBites.ReadOnly = true;
            countBites.Size = new Size(59, 27);
            countBites.TabIndex = 37;
            // 
            // labelCountBites
            // 
            labelCountBites.Anchor = AnchorStyles.Right;
            labelCountBites.AutoSize = true;
            labelCountBites.Font = new Font("Segoe UI", 11.25F);
            labelCountBites.Location = new Point(255, 5);
            labelCountBites.Margin = new Padding(5, 5, 5, 0);
            labelCountBites.Name = "labelCountBites";
            labelCountBites.Size = new Size(89, 20);
            labelCountBites.TabIndex = 38;
            labelCountBites.Text = "Итого байт:";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(labelCountBites);
            panel3.Controls.Add(labelCountMessages);
            panel3.Controls.Add(countBites);
            panel3.Controls.Add(countMessages);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(30, 427);
            panel3.Margin = new Padding(30, 0, 30, 0);
            panel3.MinimumSize = new Size(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(408, 34);
            panel3.TabIndex = 34;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(0, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.46512F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5348835F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.Size = new Size(468, 781);
            tableLayoutPanel1.TabIndex = 35;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(468, 781);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(470, 420);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ipName;
        private Button sendMessage;
        private CheckBox retry;
        private Label label2;
        private Label timing;
        private TextBox timingBox;
        private TextBox countBox;
        private TextBox textBox1;
        private Label portName;
        private TextBox portValue;
        private TextBox ipValue;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel2;
        private Label labelCountMessages;
        private TextBox countMessages;
        private TextBox countBites;
        private Label labelCountBites;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idMessage;
        private DataGridViewTextBoxColumn message;
        private DataGridViewTextBoxColumn lenght;
        private DataGridViewTextBoxColumn sizeInByte;
    }
}
