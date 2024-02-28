namespace practiceWinforms
{
    partial class Form2
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
            countBites = new TextBox();
            countMessages = new TextBox();
            labelCountBites = new Label();
            labelCountMessages = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            portName = new Label();
            sizeInByte = new DataGridViewTextBoxColumn();
            lenght = new DataGridViewTextBoxColumn();
            message = new DataGridViewTextBoxColumn();
            idMessage = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(countBites);
            panel1.Controls.Add(countMessages);
            panel1.Controls.Add(labelCountBites);
            panel1.Controls.Add(labelCountMessages);
            panel1.Location = new Point(12, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 35);
            panel1.TabIndex = 28;
            // 
            // countBites
            // 
            countBites.Anchor = AnchorStyles.Right;
            countBites.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countBites.Location = new Point(382, 4);
            countBites.Name = "countBites";
            countBites.ReadOnly = true;
            countBites.Size = new Size(61, 27);
            countBites.TabIndex = 26;
            // 
            // countMessages
            // 
            countMessages.Anchor = AnchorStyles.Left;
            countMessages.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countMessages.Location = new Point(147, 4);
            countMessages.Name = "countMessages";
            countMessages.ReadOnly = true;
            countMessages.Size = new Size(59, 27);
            countMessages.TabIndex = 25;
            // 
            // labelCountBites
            // 
            labelCountBites.Anchor = AnchorStyles.Right;
            labelCountBites.AutoSize = true;
            labelCountBites.Font = new Font("Segoe UI", 11.25F);
            labelCountBites.Location = new Point(287, 7);
            labelCountBites.Name = "labelCountBites";
            labelCountBites.Size = new Size(89, 20);
            labelCountBites.TabIndex = 24;
            labelCountBites.Text = "Итого байт:";
            // 
            // labelCountMessages
            // 
            labelCountMessages.Anchor = AnchorStyles.Left;
            labelCountMessages.AutoSize = true;
            labelCountMessages.Font = new Font("Segoe UI", 11.25F);
            labelCountMessages.Location = new Point(3, 7);
            labelCountMessages.Name = "labelCountMessages";
            labelCountMessages.Size = new Size(138, 20);
            labelCountMessages.TabIndex = 22;
            labelCountMessages.Text = "Итого сообщений:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(12, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 348);
            panel2.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(portName);
            panel3.Location = new Point(12, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(443, 43);
            panel3.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(46, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(59, 27);
            textBox1.TabIndex = 31;
            // 
            // portName
            // 
            portName.AutoSize = true;
            portName.Font = new Font("Segoe UI", 11.25F);
            portName.Location = new Point(3, 10);
            portName.Name = "portName";
            portName.Size = new Size(37, 20);
            portName.TabIndex = 30;
            portName.Text = "port";
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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idMessage, message, lenght, sizeInByte });
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 332);
            dataGridView1.TabIndex = 20;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 474);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label total;
        private Label ipValue;
        private Label ipName;
        private Panel panel1;
        private TextBox countBites;
        private TextBox countMessages;
        private Label labelCountBites;
        private Label labelCountMessages;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox1;
        private Label portName;
        private DataGridViewTextBoxColumn sizeInByte;
        private DataGridViewTextBoxColumn lenght;
        private DataGridViewTextBoxColumn message;
        private DataGridViewTextBoxColumn idMessage;
        private DataGridView dataGridView1;
    }
}