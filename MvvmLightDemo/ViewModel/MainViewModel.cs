using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MvvmLightDemo.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        private string currentTime;

        public string CurrentTime
        {
            get { return currentTime; }
            set { currentTime = value; RaisePropertyChanged(() => CurrentTime); }
        }

        public RelayCommand relayCommand { get; set; }

        
        public MainViewModel()
        {
            relayCommand = new RelayCommand(OnClickCommand, null);
        }

        private void OnClickCommand()
        {
            CurrentTime = "Current Time : " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}