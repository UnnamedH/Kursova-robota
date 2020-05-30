using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkCsharp
{
 
    public partial class Form1 : Form
    {
        public TextBox passwordBox = new TextBox();
        public Form form2 = new Form();
        bool validate(TextBox textBox)
        {
            bool value = false;
            if (textBox.Text.Length != 0)
            {
                value = true;
            }
            return value;
        }

        bool validateFieldDestinationStation(TextBox textBox)
        {
            bool value = false;
            if (validate(textBox) && textBox.TextLength <= 15)
            {
                value = true;
            }
            return value;
        }

        bool validateFieldTravelPrice(TextBox textBox)
        {
            double number = 0.0;
            bool value = false;
            bool isDouble = Double.TryParse(textBox.Text, out number) == true;
            if (validate(textBox) && (textBox.TextLength <= 10) &&
            (isDouble) && (Double.Parse(textBox.Text) > 0))
            {
                value = true;
            }
            return value;
        }

        bool validateTime(MaskedTextBox departureTime, MaskedTextBox arrivalTime)
        {
            bool value = false;
            DateTime dateTimeBefore = DateTime.ParseExact(departureTime.Text, "dd.MM.yyyy HH:mm",
                System.Globalization.CultureInfo.CurrentCulture);
            DateTime dateTimeAfter = DateTime.ParseExact(arrivalTime.Text, "dd.MM.yyyy HH:mm",
                System.Globalization.CultureInfo.CurrentCulture);
            TimeSpan difference = dateTimeAfter.Subtract(dateTimeBefore);
            TimeSpan timeSpan = new TimeSpan(00, 30, 00);
            if (difference > timeSpan)
            {
                value = true;
            }
            return value;
        }

        bool validateAllFields()
        {
            bool value = false;
            /*if (validateFieldDestinationStation(FieldDestinationStation) && validateFieldTravelPrice(FieldTravelPrice)
            && validateTime(FieldDepartureTime, FieldArrivalTime))
            {
                value = true;
            }*/
            return value;
        }

        void addNewRow()
        {
            ScheduleTrain train = openEditForm(null);
            if (train != null)
            {
                DataGridViewRow row = new DataGridViewRow();
                setRowData(row, train);
                TrainDataView.Rows.Add(row);
            }
        }

        void editCurrentRow()
        {
            if (TrainDataView.CurrentRow != null)
            {
                ScheduleTrain train = openEditForm(getRowData(TrainDataView.CurrentRow));
                if (train != null)
                {
                    setRowData(TrainDataView.CurrentRow, train);
                }
            }
        }

        void deleteCurrentRow()
        {
            if (TrainDataView.Rows.Count > 0 && TrainDataView.CurrentRow.Selected)
            {
                TrainDataView.Rows.Remove(TrainDataView.CurrentRow);
            }
        }

        List<ScheduleTrain> initArrayTrains()
        {
            List<ScheduleTrain> trains = new List<ScheduleTrain>();
            trains.Add(new ScheduleTrain("Княжево", "2341d", new DateTime(2020, 05, 28, 18, 00, 00),
                new DateTime(2020, 05, 28, 19, 25, 00), 15.5));
            trains.Add(new ScheduleTrain("Заболотное", "1231d", new DateTime(2020, 05, 28, 14, 00, 00),
                new DateTime(2020, 05, 28, 14, 30, 00), 25.5));
            trains.Add(new ScheduleTrain("Крыжополь", "3523d", new DateTime(2020, 05, 28, 11, 00, 00),
                new DateTime(2020, 05, 28, 13, 00, 00), 20.0));
            trains.Add(new ScheduleTrain("Крикливицы", "1238d", new DateTime(2020, 05, 28, 10, 00, 00),
                new DateTime(2020, 05, 28, 11, 25, 00), 15.0));
            trains.Add(new ScheduleTrain("Рудница", "2341d", new DateTime(2020, 05, 28, 13, 00, 00),
                new DateTime(2020, 05, 28, 14, 20, 00), 20.0));
            trains.Add(new ScheduleTrain("Попелюхи", "1242d", new DateTime(2020, 05, 28, 14, 00, 00),
                new DateTime(2020, 05, 28, 15, 00, 00), 30.5));
            trains.Add(new ScheduleTrain("Гоноворка", "3452d", new DateTime(2020, 05, 28, 14, 00, 00),
                new DateTime(2020, 05, 28, 15, 00, 00), 25.5));
            trains.Add(new ScheduleTrain("Пирижна", "2422d", new DateTime(2020, 05, 28, 14, 00, 00),
                new DateTime(2020, 05, 28, 14, 00, 00), 30.5));
            trains.Add(new ScheduleTrain("Кодыма", "242d", new DateTime(2020, 05, 28, 12, 00, 00),
                new DateTime(2020, 05, 28, 14, 00, 00), 20.5));
            trains.Add(new ScheduleTrain("Лысогорка", "2352d", new DateTime(2020, 05, 28, 15, 00, 00),
                new DateTime(2020, 05, 28, 17, 15, 00), 15.5));
            trains.Add(new ScheduleTrain("Александровка", "3452d", new DateTime(2020, 05, 28, 18, 00, 00),
                new DateTime(2020, 05, 28, 19, 30, 00), 15.5));
            trains.Add(new ScheduleTrain("Абамеликово", "4363d", new DateTime(2020, 05, 28, 14, 00, 00),
                new DateTime(2020, 05, 28, 15, 00, 00), 20.5));
            trains.Add(new ScheduleTrain("Котовск", "6789d", new DateTime(2020, 05, 28, 14, 00, 00),
                new DateTime(2020, 05, 28, 15, 00, 00), 35.0));
            trains.Add(new ScheduleTrain("Одесса", "2345d", new DateTime(2020, 05, 28, 14, 00, 00),
                new DateTime(2020, 05, 28, 17, 30, 00), 35.0));

            return trains;
        }

        void fillTableOfData()
        {
            putTrainsToTable(initArrayTrains());
        }

        void putTrainsToTable(List<ScheduleTrain> trains)
        {
            foreach (ScheduleTrain train in trains)
            {
                DataGridViewRow row = new DataGridViewRow();
                setRowData(row, train);
                TrainDataView.Rows.Add(row);
             }
        }

        private void setRowData(DataGridViewRow row, ScheduleTrain train)
        {
            if (row.Cells.Count == 0)
            {
                row.CreateCells(TrainDataView);
            }

            row.Cells[0].Value = train.getDestinationStation();
            row.Cells[1].Value = train.getNumberTrain();
            row.Cells[2].Value = train.getDepartureTime();
            row.Cells[3].Value = train.getArrivalTime();
            row.Cells[4].Value = train.getTravelPrice();
        }

        List<ScheduleTrain> getTrainsFromTable()
        {
            List<ScheduleTrain> trains = new List<ScheduleTrain>();
            foreach(DataGridViewRow row in TrainDataView.Rows)
            {
                trains.Add(getRowData(row));
            }

            return trains;
        }

        private ScheduleTrain getRowData(DataGridViewRow row)
        {
            ScheduleTrain train = new ScheduleTrain();
            train.setDestinationStation(row.Cells[0].Value.ToString());
            train.setNumberTrain(row.Cells[1].Value.ToString());
            train.setDepartureTime(Convert.ToDateTime(row.Cells[2].Value.ToString()));
            train.setArrivalTime(Convert.ToDateTime(row.Cells[3].Value.ToString()));
            train.setTravelPrice(Convert.ToDouble(row.Cells[4].Value.ToString()));
            return train;
        }

        void readDataFromFile()
        {
            var result = MessageBox.Show("Load data from file?", "", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (!openFileDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    return;
                }

                List<ScheduleTrain> trains = ScheduleTrainFileLoader.loadFromFile(openFileDialog.FileName);

                TrainDataView.Rows.Clear();

                foreach(ScheduleTrain train in trains) {
                    TrainDataView.Rows.Add(
                        train.getDestinationStation(),
                        train.getNumberTrain(),
                        train.getDepartureTime(),
                        train.getArrivalTime(),
                        train.getTravelPrice());
                }
            }
        }

        void writeDataToFile()
        {
            var result = MessageBox.Show("Write data to file?", "", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (!openFileDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    return;
                }
                string filename = openFileDialog.FileName;
                ScheduleTrainFileLoader.saveToFile(filename, getTrainsFromTable());
            }
        }

        void initComboBoxFilterColumns()
        { 
            comboBoxFilterColumns.Items.Add("Destination station");
            comboBoxFilterColumns.Items.Add("Number train");
            comboBoxFilterColumns.Items.Add("Departure time");
            comboBoxFilterColumns.Items.Add("Arrival time");
            comboBoxFilterColumns.Items.Add("Travel price");
        }

        void searchByValue(int cellNumber, String value)
        {
            for (int i = 0; i < TrainDataView.RowCount; i++)
            {
                TrainDataView.Rows[i].Visible = TrainDataView.Rows[i].Cells[cellNumber].Value.ToString() == value;
            }
        }

        void searchByKeyField()
        {
            if (comboBoxFilterColumns.SelectedIndex == -1)
            {
                return;
            }

            searchByValue(comboBoxFilterColumns.SelectedIndex, FieldInputValue.Text);
        }

        void showCurrentDataBase()
        {
            for (int i = 0; i < TrainDataView.RowCount; i++)
            {
                TrainDataView.Rows[i].Visible = true;
            }
        }

        void CreatePasswordWindow()
        {
            form2.ControlBox = false;
            form2.SetBounds(1000,700,200,150);
            Label passwordLabel = new Label();
            passwordLabel.Text = "Input password: ";
            passwordLabel.Location = new Point(40, 20);
            passwordBox.PasswordChar = '*';
            passwordBox.MaxLength = 5;
            passwordBox.Location = new Point(40,50);
            Button confirmButton = new Button();
            confirmButton.Location = new Point(40, 80);
            confirmButton.Text = "Confirm";
            confirmButton.Click += new EventHandler(this.MyButtonHandler);
            form2.Controls.Add(passwordLabel);
            form2.Controls.Add(passwordBox);
            form2.Controls.Add(confirmButton);
            form2.ShowDialog();
        }

        bool PasswordIsCorrect(TextBox passwordBox)
        {
            bool value = false;
            if (passwordBox.Text == "12345")
            {
                value = true;
            }
            return value;
        }

        public Form1()
        {
            InitializeComponent();
            initComboBoxFilterColumns();
            fillTableOfData();
        }

        ScheduleTrain openEditForm(ScheduleTrain train)
        {
            EditForm editDialog = new EditForm();

            if (train != null)
            {
                ((TextBox) editDialog.Controls["FieldDestinationStation"]).Text = train.getDestinationStation();
                ((TextBox) editDialog.Controls["FieldNumberTrain"]).Text = train.getNumberTrain();
                ((MaskedTextBox) editDialog.Controls["FieldDepartureTime"]).Text = train.getDepartureTime().ToString();
                ((MaskedTextBox) editDialog.Controls["FieldArrivalTime"]).Text = train.getArrivalTime().ToString();
                ((TextBox) editDialog.Controls["FieldTravelPrice"]).Text = train.getTravelPrice().ToString();
            }

            if (editDialog.ShowDialog(this) == DialogResult.OK)
            {
                ScheduleTrain result = new ScheduleTrain();

                result.setDestinationStation(((TextBox) editDialog.Controls["FieldDestinationStation"]).Text);
                result.setNumberTrain(((TextBox) editDialog.Controls["FieldNumberTrain"]).Text);
                result.setDepartureTime(Convert.ToDateTime(((MaskedTextBox) editDialog.Controls["FieldDepartureTime"]).Text));
                result.setArrivalTime(Convert.ToDateTime(((MaskedTextBox) editDialog.Controls["FieldArrivalTime"]).Text));
                result.setTravelPrice(Convert.ToDouble(((TextBox)editDialog.Controls["FieldTravelPrice"]).Text));

                return result;
            }

            return null;
        }

        private void ButtonAddRow_Click(object sender, EventArgs e)
        {
            addNewRow();
        }

        private void ButtonEditRow_Click(object sender, EventArgs e)
        {
            CreatePasswordWindow();
            editCurrentRow();
        }
        private void ButtonDeleteRow_Click(object sender, EventArgs e)
        {
            deleteCurrentRow();
        }

        private void ButtonLoadData_Click(object sender, EventArgs e)
        {
            readDataFromFile();
        }

        private void ButtonWriteData_Click(object sender, EventArgs e)
        {
            writeDataToFile();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            searchByKeyField();
        }

        private void ButtonShowCurrentDataBase_Click(object sender, EventArgs e)
        {
            showCurrentDataBase();
        }

        void MyButtonHandler(object sender, EventArgs e)
        {
 
            if (PasswordIsCorrect(passwordBox))//password 12345
            {
                form2.Close(); 
            }
        }

    }
}
