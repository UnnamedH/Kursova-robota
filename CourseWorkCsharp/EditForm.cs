using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CourseWorkCsharp
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(validateAllFields())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        bool validateIsNotEmpty(String value, String title)
        {
            if (value.Length == 0)
            {
                MessageBox.Show("Поле " + title + " не заполнено");
                return false;
            }
            
            return true;
        }

        bool validateFieldDestinationStation(TextBox textBox)
        {
            bool value = false;
            if (validateIsNotEmpty(textBox.Text, "Конечная станция"))
            {
                value = true;
            }
            return value;
        }

        bool validateFieldTravelPrice(TextBox textBox)
        {
            String title = "Стоимость проезда";
            if (!validateIsNotEmpty(textBox.Text, title))
            {
                return false;
            }

            double value = 0.0;
            bool isDouble = Double.TryParse(textBox.Text, out value);
            if (!isDouble)
            {
                MessageBox.Show("Поле " + title + " должно быть числом");
                return false;
            }

            if (value <= 0)
            {
                MessageBox.Show("Поле " + title + " должно быть положительным числом");
                return false;
            }
            
            return true;
        }

        bool validateTime(MaskedTextBox departureTime, MaskedTextBox arrivalTime)
        {
            if (!validateIsNotEmpty(departureTime.Text, "Время отправления"))
            {
                return false;
            }
            
            if (!validateIsNotEmpty(arrivalTime.Text, "Время прибытия"))
            {
                return false;
            }

            DateTime dateTimeBefore = DateTime.MinValue;
            if (!DateTime.TryParseExact(departureTime.Text, "dd.MM.yyyy HH:mm", 
                CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTimeBefore))
            {
                MessageBox.Show("В поле Время отправления должна быть указана корректная дата и время");
                return false;
            }

            DateTime dateTimeAfter = DateTime.MinValue;
            if (!DateTime.TryParseExact(departureTime.Text, "dd.MM.yyyy HH:mm",
                CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTimeAfter))
            {
                MessageBox.Show("В поле Время прибытия должна быть указана корректная дата и время");
                return false;
            }

            TimeSpan difference = dateTimeAfter.Subtract(dateTimeBefore);
            if (difference.TotalSeconds <= 0)
            {
                MessageBox.Show("Время прибытия должно быть больше времени отправления");
                return false;
            }
            
            return true;
        }

        bool validateNumberTrain(TextBox textBox)
        {
            if (!validateIsNotEmpty(textBox.Text, "№ поезда"))
            {
                return false;
            }
            
            return true;
        }

        bool validateAllFields()
        {
            return validateFieldDestinationStation(FieldDestinationStation)
                && validateNumberTrain(FieldNumberTrain)
                && validateTime(FieldDepartureTime, FieldArrivalTime)
                && validateFieldTravelPrice(FieldTravelPrice);
        }
    }
}
