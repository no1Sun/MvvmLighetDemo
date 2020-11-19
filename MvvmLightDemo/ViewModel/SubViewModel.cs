using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MvvmLightDemo.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightDemo.ViewModel
{
    public class SubViewModel : ViewModelBase
    {
        private string subName;

        public string SubName
        {
            get { return subName; }
            set { subName = value; RaisePropertyChanged(() => SubName); }
        }

        public RelayCommand OnClickCommand { get; set; }

        public SubViewModel()
        {
            OnClickCommand = new RelayCommand(OnClickAction, null);
        }

        private void OnClickAction()
        {
            string today = "Sub " + DateTime.Now.ToString("HH:mm:ss");
            SubName = today;

            var msg = new MessageViewModel()
            {
                MyMessage = today
            };

            Messenger.Default.Send(msg);
        }

    }
}
