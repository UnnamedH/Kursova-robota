namespace CourseWorkCsharp
{
    partial class EditForm
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
            this.FieldTravelPrice = new System.Windows.Forms.TextBox();
            this.FieldArrivalTime = new System.Windows.Forms.MaskedTextBox();
            this.FieldDepartureTime = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FieldNumberTrain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FieldDestinationStation = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FieldTravelPrice
            // 
            this.FieldTravelPrice.Location = new System.Drawing.Point(179, 157);
            this.FieldTravelPrice.Name = "FieldTravelPrice";
            this.FieldTravelPrice.Size = new System.Drawing.Size(181, 22);
            this.FieldTravelPrice.TabIndex = 26;
            // 
            // FieldArrivalTime
            // 
            this.FieldArrivalTime.Location = new System.Drawing.Point(179, 124);
            this.FieldArrivalTime.Mask = "00/00/0000 90:00";
            this.FieldArrivalTime.Name = "FieldArrivalTime";
            this.FieldArrivalTime.Size = new System.Drawing.Size(181, 22);
            this.FieldArrivalTime.TabIndex = 25;
            this.FieldArrivalTime.ValidatingType = typeof(System.DateTime);
            // 
            // FieldDepartureTime
            // 
            this.FieldDepartureTime.Location = new System.Drawing.Point(179, 89);
            this.FieldDepartureTime.Mask = "00/00/0000 90:00";
            this.FieldDepartureTime.Name = "FieldDepartureTime";
            this.FieldDepartureTime.Size = new System.Drawing.Size(181, 22);
            this.FieldDepartureTime.TabIndex = 24;
            this.FieldDepartureTime.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Стоимость проезда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Время прибытия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Время отправления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "№ поезда";
            // 
            // FieldNumberTrain
            // 
            this.FieldNumberTrain.Location = new System.Drawing.Point(179, 54);
            this.FieldNumberTrain.Name = "FieldNumberTrain";
            this.FieldNumberTrain.Size = new System.Drawing.Size(181, 22);
            this.FieldNumberTrain.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Конечная станция";
            // 
            // FieldDestinationStation
            // 
            this.FieldDestinationStation.Location = new System.Drawing.Point(179, 23);
            this.FieldDestinationStation.Name = "FieldDestinationStation";
            this.FieldDestinationStation.Size = new System.Drawing.Size(181, 22);
            this.FieldDestinationStation.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(192, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(66, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(372, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FieldTravelPrice);
            this.Controls.Add(this.FieldArrivalTime);
            this.Controls.Add(this.FieldDepartureTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FieldNumberTrain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FieldDestinationStation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.ShowInTaskbar = false;
            this.Text = "Добавить/Изменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FieldTravelPrice;
        private System.Windows.Forms.MaskedTextBox FieldArrivalTime;
        private System.Windows.Forms.MaskedTextBox FieldDepartureTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FieldNumberTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FieldDestinationStation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}