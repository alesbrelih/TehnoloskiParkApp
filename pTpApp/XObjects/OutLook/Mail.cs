using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace pTpApp.XObjects.OutLook
{
    public static class Mail
    {
        public static void Open(string recipient)
        {
            Outlook.Application mailApp = new Outlook.Application();
            Outlook.MailItem mailItem = (Outlook.MailItem)mailApp.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = "PTP";
            mailItem.To = recipient;
            mailItem.Body = "";
            mailItem.Importance = Outlook.OlImportance.olImportanceLow;
            mailItem.Display(false);
        }
    }
}
