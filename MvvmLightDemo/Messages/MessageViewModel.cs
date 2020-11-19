using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightDemo.Messages
{
    public class MessageViewModel : MessageBase
    {
        public string MyMessage { get; set; }
    }
}
