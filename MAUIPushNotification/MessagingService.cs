using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIPushNotification
{
    public partial class MessagingService : IMessagingService
    {
        public partial string GetToken();
        public partial bool IsMessagingAvailable();
        public partial void SetNewTokenCallback(Action<string> token_callback);
    }
}
