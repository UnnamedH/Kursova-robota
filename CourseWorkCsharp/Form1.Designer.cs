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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonAddRow = new System.Windows.Forms.Button();
            this.ButtonDeleteRow = new System.Windows.Forms.Button();
            this.TrainDataView = new System.Windows.Forms.DataGridView();
            this.DestinationStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberTrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonLoadData = new System.Windows.Forms.Button();
            this.ButtonWriteData = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FieldInputValue = new System.Windows.Forms.MaskedTextBox();
            this.ButtonShowCurrentDataBase = new System.Windows.Forms.Button();
            this.comboBoxFilterColumns = new System.Windows.Forms.ComboBox();
            this.ButtonEditRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrainDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddRow
            // 
            this.ButtonAddRow.Location = new System.Drawing.Point(31, 21);
            this.ButtonAddRow.Name = "ButtonAddRow";
            this.ButtonAddRow.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddRow.TabIndex = 10;
            this.ButtonAddRow.Text = "Add";
            this.ButtonAddRow.UseVisualStyleBackColor = true;
            this.ButtonAddRow.Click += new System.EventHandler(this.ButtonAddRow_Click);
            // 
            // ButtonDeleteRow
            // 
            this.ButtonDeleteRow.Location = new System.Drawing.Point(196, 21);
            this.ButtonDeleteRow.Name = "ButtonDeleteRow";
            this.ButtonDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteRow.TabIndex = 11;
            this.ButtonDeleteRow.Text = "Delete";
            this.ButtonDeleteRow.UseVisualStyleBackColor = true;
            this.ButtonDeleteRow.Click += new System.EventHandler(this.ButtonDeleteRow_Click);
            // 
            // TrainDataView
            // 
            this.TrainDataView.AllowUserToAddRows = false;
            this.TrainDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DestinationStation,
            this.NumberTrain,
            this.DepartureTime,
            this.ArrivalTime,
            this.TravelPrice});
            this.TrainDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.TrainDataView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TrainDataView.Location = new System.Drawing.Point(31, 64);
            this.TrainDataView.Name = "TrainDataView";
            this.TrainDataView.ReadOnly = true;
            this.TrainDataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrainDataView.RowHeadersWidth = 51;
            this.TrainDataView.RowTemplate.Height = 24;
            this.TrainDataView.Size = new System.Drawing.Size(910, 306);
            this.TrainDataView.TabIndex = 13;
            // 
            // DestinationStation
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.DestinationStation.DefaultCellStyle = dataGridViewCellStyle3;
            this.DestinationStation.HeaderText = "DestinationStation";
            this.DestinationStation.MinimumWidth = 6;
            this.DestinationStation.Name = "DestinationStation";
            this.DestinationStation.ReadOnly = true;
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
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.DepartureTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.DepartureTime.HeaderText = "DepartureTime";
            this.DepartureTime.MinimumWidth = 6;
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.ReadOnly = true;
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
            // ButtonLoadData
            // 
            this.ButtonLoadData.Location = new System.Drawing.Point(280, 21);
            this.ButtonLoadData.Name = "ButtonLoadData";
            this.ButtonLoadData.Size = new System.Drawing.Size(89, 23);
            this.ButtonLoadData.TabIndex = 17;
            this.ButtonLoadData.Text = "Load data";
            this.ButtonLoadData.UseVisualStyleBackColor = true;
            this.ButtonLoadData.Click += new System.EventHandler(this.ButtonLoadData_Click);
            // 
            // ButtonWriteData
            // 
            this.ButtonWriteData.Location = new System.Drawing.Point(370, 21);
            this.ButtonWriteData.Name = "ButtonWriteData";
            this.ButtonWriteData.Size = new System.Drawing.Size(89, 23);
            this.ButtonWriteData.TabIndex = 18;
            this.ButtonWriteData.Text = "Write data";
            this.ButtonWriteData.UseVisualStyleBackColor = true;
            this.ButtonWriteData.Click += new System.EventHandler(this.ButtonWriteData_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(774, 21);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(76, 23);
            this.ButtonSearch.TabIndex = 19;
            this.ButtonSearch.Text = "Filter";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Filter by:";
            // 
            // FieldInputValue
            // 
            this.FieldInputValue.Location = new System.Drawing.Point(666, 21);
            this.FieldInputValue.Name = "FieldInputValue";
            this.FieldInputValue.Size = new System.Drawing.Size(102, 22);
            this.FieldInputValue.TabIndex = 23;
            // 
            // ButtonShowCurrentDataBase
            // 
            this.ButtonShowCurrentDataBase.Location = new System.Drawing.Point(856, 21);
            this.ButtonShowCurrentDataBase.Name = "ButtonShowCurrentDataBase";
            this.ButtonShowCurrentDataBase.Size = new System.Drawing.Size(85, 23);
            this.ButtonShowCurrentDataBase.TabIndex = 24;
            this.ButtonShowCurrentDataBase.Text = "Clear filter";
            this.ButtonShowCurrentDataBase.UseVisualStyleBackColor = true;
            this.ButtonShowCurrentDataBase.Click += new System.EventHandler(this.ButtonShowCurrentDataBase_Click);
            // 
            // comboBoxFilterColumns
            // 
            this.comboBoxFilterColumns.FormattingEnabled = true;
            this.comboBoxFilterColumns.Location = new System.Drawing.Point(530, 21);
            this.comboBoxFilterColumns.Name = "comboBoxFilterColumns";
            this.comboBoxFilterColumns.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilterColumns.TabIndex = 25;
            // 
            // ButtonEditRow
            // 
            this.ButtonEditRow.Location = new System.Drawing.Point(112, 21);
            this.ButtonEditRow.Name = "ButtonEditRow";
            this.ButtonEditRow.Size = new System.Drawing.Size(75, 23);
            this.ButtonEditRow.TabIndex = 26;
            this.ButtonEditRow.Text = "Edit";
            this.ButtonEditRow.UseVisualStyleBackColor = true;
            this.ButtonEditRow.Click += new System.EventHandler(this.ButtonEditRow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.ButtonEditRow);
            this.Controls.Add(this.comboBoxFilterColumns);
            this.Controls.Add(this.ButtonShowCurrentDataBase);
            this.Controls.Add(this.FieldInputValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonWriteData);
            this.Controls.Add(this.ButtonLoadData);
            this.Controls.Add(this.TrainDataView);
            this.Controls.Add(this.ButtonDeleteRow);
            this.Controls.Add(this.ButtonAddRow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TrainDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonAddRow;
        private System.Windows.Forms.Button ButtonDeleteRow;
        private System.Windows.Forms.Button ButtonLoadData;
        private System.Windows.Forms.Button ButtonWriteData;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox FieldInputValue;
        private System.Windows.Forms.Button ButtonShowCurrentDataBase;
        protected System.Windows.Forms.DataGridView TrainDataView;
        private System.Windows.Forms.ComboBox comboBoxFilterColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberTrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelPrice;
        private System.Windows.Forms.Button ButtonEditRow;
    }
}

