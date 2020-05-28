namespace CourseWorkCsharp
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
            this.FieldDestinationStation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonAddRow = new System.Windows.Forms.Button();
            this.ButtonDeleteRow = new System.Windows.Forms.Button();
            this.TrainDataView = new System.Windows.Forms.DataGridView();
            this.DestinationStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberTrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldNumberTrain = new System.Windows.Forms.TextBox();
            this.FieldDepartureTime = new System.Windows.Forms.MaskedTextBox();
            this.FieldArrivalTime = new System.Windows.Forms.MaskedTextBox();
            this.FieldTravelPrice = new System.Windows.Forms.TextBox();
            this.ButtonLoadData = new System.Windows.Forms.Button();
            this.ButtonWriteData = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ListBoxKeyWord = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FieldInputValue = new System.Windows.Forms.MaskedTextBox();
            this.ButtonShowCurrentDataBase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrainDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // FieldDestinationStation
            // 
            this.FieldDestinationStation.Location = new System.Drawing.Point(33, 29);
            this.FieldDestinationStation.Name = "FieldDestinationStation";
            this.FieldDestinationStation.Size = new System.Drawing.Size(100, 22);
            this.FieldDestinationStation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DestinationStation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NumberTrain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "DepartureTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ArrivalTime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "TravelPrice";
            // 
            // ButtonAddRow
            // 
            this.ButtonAddRow.Location = new System.Drawing.Point(33, 70);
            this.ButtonAddRow.Name = "ButtonAddRow";
            this.ButtonAddRow.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddRow.TabIndex = 10;
            this.ButtonAddRow.Text = "Add";
            this.ButtonAddRow.UseVisualStyleBackColor = true;
            this.ButtonAddRow.Click += new System.EventHandler(this.ButtonAddRow_Click);
            // 
            // ButtonDeleteRow
            // 
            this.ButtonDeleteRow.Location = new System.Drawing.Point(134, 70);
            this.ButtonDeleteRow.Name = "ButtonDeleteRow";
            this.ButtonDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteRow.TabIndex = 11;
            this.ButtonDeleteRow.Text = "Delete";
            this.ButtonDeleteRow.UseVisualStyleBackColor = true;
            this.ButtonDeleteRow.Click += new System.EventHandler(this.ButtonDeleteRow_Click);
            // 
            // TrainDataView
            // 
            this.TrainDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DestinationStation,
            this.NumberTrain,
            this.DepartureTime,
            this.ArrivalTime,
            this.TravelPrice});
            this.TrainDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.TrainDataView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TrainDataView.Location = new System.Drawing.Point(33, 111);
            this.TrainDataView.Name = "TrainDataView";
            this.TrainDataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrainDataView.RowHeadersWidth = 51;
            this.TrainDataView.RowTemplate.Height = 24;
            this.TrainDataView.Size = new System.Drawing.Size(878, 306);
            this.TrainDataView.TabIndex = 13;
            this.TrainDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrainDataView_DoubleClick);
            this.TrainDataView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrainDataView_CellAndEdit);
            // 
            // DestinationStation
            // 
            this.DestinationStation.HeaderText = "DestinationStation";
            this.DestinationStation.MinimumWidth = 6;
            this.DestinationStation.Name = "DestinationStation";
            this.DestinationStation.Width = 125;
            // 
            // NumberTrain
            // 
            this.NumberTrain.HeaderText = "NumberTrain";
            this.NumberTrain.MinimumWidth = 6;
            this.NumberTrain.Name = "NumberTrain";
            this.NumberTrain.Width = 125;
            // 
            // DepartureTime
            // 
            this.DepartureTime.HeaderText = "DepartureTime";
            this.DepartureTime.MinimumWidth = 6;
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.Width = 150;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "ArrivalTime";
            this.ArrivalTime.MinimumWidth = 6;
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Width = 150;
            // 
            // TravelPrice
            // 
            this.TravelPrice.HeaderText = "TravelPrice";
            this.TravelPrice.MinimumWidth = 6;
            this.TravelPrice.Name = "TravelPrice";
            this.TravelPrice.Width = 150;
            // 
            // FieldNumberTrain
            // 
            this.FieldNumberTrain.Location = new System.Drawing.Point(176, 29);
            this.FieldNumberTrain.Name = "FieldNumberTrain";
            this.FieldNumberTrain.Size = new System.Drawing.Size(100, 22);
            this.FieldNumberTrain.TabIndex = 2;
            // 
            // FieldDepartureTime
            // 
            this.FieldDepartureTime.Location = new System.Drawing.Point(302, 29);
            this.FieldDepartureTime.Mask = "00/00/0000 90:00";
            this.FieldDepartureTime.Name = "FieldDepartureTime";
            this.FieldDepartureTime.Size = new System.Drawing.Size(100, 22);
            this.FieldDepartureTime.TabIndex = 14;
            this.FieldDepartureTime.ValidatingType = typeof(System.DateTime);
            // 
            // FieldArrivalTime
            // 
            this.FieldArrivalTime.Location = new System.Drawing.Point(449, 29);
            this.FieldArrivalTime.Mask = "00/00/0000 90:00";
            this.FieldArrivalTime.Name = "FieldArrivalTime";
            this.FieldArrivalTime.Size = new System.Drawing.Size(100, 22);
            this.FieldArrivalTime.TabIndex = 15;
            this.FieldArrivalTime.ValidatingType = typeof(System.DateTime);
            // 
            // FieldTravelPrice
            // 
            this.FieldTravelPrice.Location = new System.Drawing.Point(589, 29);
            this.FieldTravelPrice.Name = "FieldTravelPrice";
            this.FieldTravelPrice.Size = new System.Drawing.Size(100, 22);
            this.FieldTravelPrice.TabIndex = 16;
            // 
            // ButtonLoadData
            // 
            this.ButtonLoadData.Location = new System.Drawing.Point(236, 70);
            this.ButtonLoadData.Name = "ButtonLoadData";
            this.ButtonLoadData.Size = new System.Drawing.Size(89, 23);
            this.ButtonLoadData.TabIndex = 17;
            this.ButtonLoadData.Text = "Load data";
            this.ButtonLoadData.UseVisualStyleBackColor = true;
            this.ButtonLoadData.Click += new System.EventHandler(this.ButtonLoadData_Click);
            // 
            // ButtonWriteData
            // 
            this.ButtonWriteData.Location = new System.Drawing.Point(344, 70);
            this.ButtonWriteData.Name = "ButtonWriteData";
            this.ButtonWriteData.Size = new System.Drawing.Size(89, 23);
            this.ButtonWriteData.TabIndex = 18;
            this.ButtonWriteData.Text = "Write data";
            this.ButtonWriteData.UseVisualStyleBackColor = true;
            this.ButtonWriteData.Click += new System.EventHandler(this.ButtonWriteData_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(917, 263);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(141, 24);
            this.ButtonSearch.TabIndex = 19;
            this.ButtonSearch.Text = "Search by key word";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ListBoxKeyWord
            // 
            this.ListBoxKeyWord.FormattingEnabled = true;
            this.ListBoxKeyWord.ItemHeight = 16;
            this.ListBoxKeyWord.Location = new System.Drawing.Point(917, 176);
            this.ListBoxKeyWord.Name = "ListBoxKeyWord";
            this.ListBoxKeyWord.Size = new System.Drawing.Size(141, 36);
            this.ListBoxKeyWord.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(917, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Select key field:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(930, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Input value";
            // 
            // FieldInputValue
            // 
            this.FieldInputValue.Location = new System.Drawing.Point(917, 235);
            this.FieldInputValue.Name = "FieldInputValue";
            this.FieldInputValue.Size = new System.Drawing.Size(141, 22);
            this.FieldInputValue.TabIndex = 23;
            // 
            // ButtonShowCurrentDataBase
            // 
            this.ButtonShowCurrentDataBase.Location = new System.Drawing.Point(917, 293);
            this.ButtonShowCurrentDataBase.Name = "ButtonShowCurrentDataBase";
            this.ButtonShowCurrentDataBase.Size = new System.Drawing.Size(168, 24);
            this.ButtonShowCurrentDataBase.TabIndex = 24;
            this.ButtonShowCurrentDataBase.Text = "Show current data base";
            this.ButtonShowCurrentDataBase.UseVisualStyleBackColor = true;
            this.ButtonShowCurrentDataBase.Click += new System.EventHandler(this.ButtonShowCurrentDataBase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 450);
            this.Controls.Add(this.ButtonShowCurrentDataBase);
            this.Controls.Add(this.FieldInputValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ListBoxKeyWord);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonWriteData);
            this.Controls.Add(this.ButtonLoadData);
            this.Controls.Add(this.FieldTravelPrice);
            this.Controls.Add(this.FieldArrivalTime);
            this.Controls.Add(this.FieldDepartureTime);
            this.Controls.Add(this.TrainDataView);
            this.Controls.Add(this.ButtonDeleteRow);
            this.Controls.Add(this.ButtonAddRow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FieldNumberTrain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FieldDestinationStation);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TrainDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FieldDestinationStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonAddRow;
        private System.Windows.Forms.Button ButtonDeleteRow;
        private System.Windows.Forms.TextBox FieldNumberTrain;
        private System.Windows.Forms.MaskedTextBox FieldDepartureTime;
        private System.Windows.Forms.MaskedTextBox FieldArrivalTime;
        private System.Windows.Forms.TextBox FieldTravelPrice;
        private System.Windows.Forms.Button ButtonLoadData;
        private System.Windows.Forms.Button ButtonWriteData;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.ListBox ListBoxKeyWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox FieldInputValue;
        private System.Windows.Forms.Button ButtonShowCurrentDataBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberTrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelPrice;
        protected System.Windows.Forms.DataGridView TrainDataView;
    }
}

