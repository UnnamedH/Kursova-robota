using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCsharp
{
    class ScheduleTrainFileLoader
    {
        public static List<ScheduleTrain> loadFromFile(String fileName)
        {
            List<ScheduleTrain> trains = new List<ScheduleTrain>();
            using (System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(
            new System.IO.FileStream(fileName, System.IO.FileMode.Open)))
            {
                while (binaryReader.PeekChar() > -1)
                {
                    ScheduleTrain train = new ScheduleTrain();

                    train.setDestinationStation(binaryReader.ReadString());
                    train.setNumberTrain(binaryReader.ReadString());
                    train.setDepartureTime(Convert.ToDateTime(binaryReader.ReadString()));
                    train.setArrivalTime(Convert.ToDateTime(binaryReader.ReadString()));
                    train.setTravelPrice(binaryReader.ReadDouble());

                    trains.Add(train);
                }
            }
            
            return trains;
        }
        public static void saveToFile(String filename, List<ScheduleTrain> trains)
        {
            using (System.IO.BinaryWriter binaryWriter = new System.IO.BinaryWriter(
            new System.IO.FileStream(filename, System.IO.FileMode.Open)))
            {
                for (int i = 0; i < trains.Count; i++)
                {
                    binaryWriter.Write(trains[i].getDestinationStation());
                    binaryWriter.Write(trains[i].getNumberTrain());
                    binaryWriter.Write(trains[i].getDepartureTime().ToString());
                    binaryWriter.Write(trains[i].getArrivalTime().ToString());
                    binaryWriter.Write(trains[i].getTravelPrice());
                }
            }
        }

    }
}
