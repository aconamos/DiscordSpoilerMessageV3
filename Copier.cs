using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;

namespace DiscordSpoilerMessageV3
{
    static class Copier
    {
        async public static void CopyText(string text)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                thread.SetApartmentState(ApartmentState.STA);
            }));

            await thread.Run(() =>
            {
                Clipboard.SetText(text);
            });
        }
    }
}
