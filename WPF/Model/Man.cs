using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model
{
    public class Man : INotifyPropertyChanged
    {
        private string fIO;

        static int Count { get; set; } = 0;
        public int ID { get; private set; }
        public string FIO { get => fIO; set
            {
                System.Diagnostics.Debug.WriteLine("FIO changed");
                fIO = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FIO"));
            }
        }
        public string BirthDay { get; set; }
        public string EMail { get; set; }

        public string Phone { get; set; }

        public Man()
        {
            ID = Count++;
            FIO = "FIO";
            BirthDay = "11.01.2000";
            EMail = "mail.mail.com";
            Phone = "777-77-77";
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
