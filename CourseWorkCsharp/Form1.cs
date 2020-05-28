using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkCsharp
{
 
    public partial class Form1 : Form
    {
        public List<ScheduleTrain> trains = new List<ScheduleTrain>();
        string[] countries = { "Destination station", "Number train", "Departure time",
                "Arrival time", "Travel price" };
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
            if (validateFieldDestinationStation(FieldDestinationStation) && validateFieldTravelPrice(FieldTravelPrice)
            && validateTime(FieldDepartureTime, FieldArrivalTime))
            {
                value = true;
            }
            return value;
        }

        void addNewRow()
        {
            DateTime TimeBefore = Convert.ToDateTime(FieldDepartureTime.Text);
            DateTime TimeAfter = Convert.ToDateTime(FieldArrivalTime.Text);
            double travelPrice = Double.Parse(FieldTravelPrice.Text);
            ScheduleTrain train = new ScheduleTrain(FieldDestinationStation.Text,
            FieldNumberTrain.Text, TimeBefore, TimeAfter, travelPrice);
            trains.Add(train);
            //int count = TrainDataView.Rows.Count;
            TrainDataView.Rows.Add(FieldDestinationStation.Text, FieldNumberTrain.Text,
                TimeBefore, TimeAfter, travelPrice);
        }

        void deleteRow()
        {
            int rowIndex = TrainDataView.CurrentCell.RowIndex;
            int columnIndex = TrainDataView.CurrentCell.ColumnIndex;
            if (TrainDataView.CurrentCell.Selected)
            {
                TrainDataView.CurrentCell.Value = "";
                switch (columnIndex)
                {
                    case 0:
                        trains[rowIndex].setDestinationStation("");
                        break;

                    case 1:
                        trains[rowIndex].setNumberTrain("");
                        break;

                    case 2:
                        trains[rowIndex].setDepartureTime(DateTime.MinValue);
                        break;

                    case 3:
                        trains[rowIndex].setArrivalTime(DateTime.MinValue);
                        break;

                    case 4:
                        trains[rowIndex].setTravelPrice(0.0);
                        break;
                    default:
                        break;
                }
            }
        }

        void deleteCurrentCell()
        {
            if (TrainDataView.Rows.Count > 0 && TrainDataView.CurrentRow.Selected)
            {
                int index = TrainDataView.CurrentRow.Index;
                TrainDataView.Rows.Remove(TrainDataView.CurrentRow);
                trains.RemoveAt(index);
            }
        }

        void initArrayTrains()
        {
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
        }

        void fillTableOfData()
        {
            for (int i = 0; i < trains.Count; i++)
            {
                TrainDataView.Rows.Add(trains[i].getDestinationStation(), trains[i].getNumberTrain(),
                    trains[i].getDepartureTime(), trains[i].getArrivalTime(), trains[i].getTravelPrice());
            }
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
                
                trains = ScheduleTrainFileLoader.loadFromFile(openFileDialog.FileName);

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
                openFileDialog.ShowDialog();
                if (!openFileDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    return;
                }
                string filename = openFileDialog.FileName;
                ScheduleTrainFileLoader.saveToFile(filename, trains);
            }
        }

        void initListBox()
        {
            ListBoxKeyWord.Items.AddRange(countries);
        }

        void searchByValue(int cellNumber)
        {

            for (int i = 0; i < TrainDataView.RowCount - 1; i++)
            {
                if (TrainDataView.Rows[i].Cells[cellNumber].Value.ToString() == FieldInputValue.Text)
                {
                    TrainDataView.Rows[i].Visible = true;
                }
            }
        }

        void searchByKeyField()
        {

            for (int i = 0; i < TrainDataView.RowCount - 1; i++)
            {
                TrainDataView.Rows[i].Visible = false;
            }
            for (int i = 0; i < TrainDataView.RowCount - 1; i++)
            {
                switch (ListBoxKeyWord.SelectedIndex)
                {
                    case 0:
                        searchByValue(0);
                        break;

                    case 1:
                        searchByValue(1);
                        break;

                    case 2:
                        searchByValue(2);
                        break;

                    case 3:
                        searchByValue(3);
                        break;

                    case 4:
                        searchByValue(4);
                        break;
                    default:
                        break;
                }
            }
        }

        void showCurrentDataBase()
        {
            for (int i = 0; i < TrainDataView.RowCount - 1; i++)
            {
                TrainDataView.Rows[i].Visible = true;
            }
        }

        void setCurrentCellValue()
        {
            int columnIndex = TrainDataView.CurrentCell.ColumnIndex;
            int rowIndex = TrainDataView.CurrentCell.RowIndex;
            switch (columnIndex)
            {
                case 0:
                    trains[rowIndex].setDestinationStation(TrainDataView.CurrentCell.Value.ToString());
                    break;

                case 1:
                    trains[rowIndex].setNumberTrain(TrainDataView.CurrentCell.Value.ToString());
                    break;

                case 2:
                    trains[rowIndex].setDepartureTime(Convert.ToDateTime
                    (TrainDataView.CurrentCell.Value.ToString()));
                    break;

                case 3:
                    trains[rowIndex].setArrivalTime(Convert.ToDateTime
                    (TrainDataView.CurrentCell.Value.ToString()));
                    break;

                case 4:
                    trains[rowIndex].setTravelPrice(Double.Parse
                    (TrainDataView.CurrentCell.Value.ToString()));
                    break;
                default:
                    break;
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
            initListBox();
            initArrayTrains();
            fillTableOfData();
        }

        private void ButtonAddRow_Click(object sender, EventArgs e)
        {
            if (validateAllFields())
            {
                addNewRow();
            }
        }

        private void ButtonDeleteRow_Click(object sender, EventArgs e)
        {
            deleteRow();
            deleteCurrentCell();
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

        private void TrainDataView_CellAndEdit(object sender, DataGridViewCellEventArgs e)
        {    
            setCurrentCellValue();
        }

        private void TrainDataView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CreatePasswordWindow();
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
