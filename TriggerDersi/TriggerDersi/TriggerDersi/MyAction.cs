using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TriggerDersi
{
    public class MyAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            if (!string.IsNullOrEmpty(sender.Text))
            {
                sender.BackgroundColor = Color.Orange;
                sender.TextColor = Color.White;
                sender.FontSize = 35;
            }
            else
            {
                sender.BackgroundColor = Color.White;
                sender.TextColor = Color.Black;
                sender.FontSize = 20;
            }
        }
    }
}
