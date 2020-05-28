using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCsharp
{
    public class ScheduleTrain
    {
        private string DestinationStation;
        private string NumberTrain;
        private DateTime DepartureTime;
        private DateTime ArrivalTime;
        private double TravelPrice;
        
        public ScheduleTrain()
        {

        }
        
        public ScheduleTrain(string DestinationStation, string NumberTrain, DateTime DepartureTime,
        DateTime ArrivalTime, double TravelPrice)
        {
            this.DestinationStation = DestinationStation;
            this.NumberTrain = NumberTrain;
            this.DepartureTime = DepartureTime;
            this.ArrivalTime = ArrivalTime;
            this.TravelPrice = TravelPrice;
        }

        public void setDestinationStation(String DestinationStation)
        {
            this.DestinationStation = DestinationStation;
        }

        public string getDestinationStation()
        {
            return DestinationStation;
        }

        public void setNumberTrain(String NumberTrain)
        {
            if (NumberTrain.Length <= 5)
            {
                this.NumberTrain = NumberTrain;
            }
        }

        public string getNumberTrain()
        {
            return NumberTrain;
        }

        public void setDepartureTime(DateTime DepartureTime)
        {
            this.DepartureTime = DepartureTime;
        }

        public DateTime getDepartureTime()
        {
            return DepartureTime;
        }

        public void setArrivalTime(DateTime ArrivalTime)
        {
            this.ArrivalTime = ArrivalTime;
        }

        public DateTime getArrivalTime()
        {
            return ArrivalTime;
        }

        public void setTravelPrice(double TravelPrice)
        {
            this.TravelPrice = TravelPrice;
        }

        public double getTravelPrice()
        {
            return TravelPrice;
        }

    };
}
