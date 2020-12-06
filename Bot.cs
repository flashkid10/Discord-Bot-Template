using System;
using System.Threading;
using System.Threading.Tasks;

namespace Bot_Script
{
    public class Bot
    {
        public static Bot_Settings Settings { get; set; }

        public static void Main(string[] args)
        {
            //XML.Load();
            //Settings = new Bot_Settings();
            //Settings.Token = "---";
            //Settings.Channel_Main = 000;
            //XML.Write();

            //try { new Bot().MainAsync().GetAwaiter().GetResult(); } catch { Discord.Dispose(); }
        }

        public static CancellationTokenSource Cancel_Token = new CancellationTokenSource();

        public async Task MainAsync()
        {
            Chat_Commands.Add_All();
            Discord.Set();
            XML.Load();
            await Discord.Connect();
            await Task.Delay(-1, Cancel_Token.Token);
        }
    }
}
