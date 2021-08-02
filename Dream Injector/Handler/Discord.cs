using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using static Dream_Injector.Handler.Structs;

namespace Dream_Injector.Handler
{
    public static class Discord
    {
        public static DiscordRpcClient client;

        public static void Start()
        {
            client = new DiscordRpcClient("870442249287245864");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = $"{Application.ProductName} {Application.ProductVersion}",
                State = $"Idle",
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    LargeImageText = "Dream DLL Injector",
                }
            });
        }

        public static void Update()
        {
            if (Idle)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"{Application.ProductName} {Application.ProductVersion}",
                    State = $"Idle",
                    Assets = new Assets()
                    {
                        LargeImageKey = "logo",
                        LargeImageText = "Dream DLL Injector",
                    }
                });
            }
            else if (Injected)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"{Application.ProductName} {Application.ProductVersion}",
                    State = $"Injected DLL",
                    Assets = new Assets()
                    {
                        LargeImageKey = "logo",
                        LargeImageText = "Dream DLL Injector",
                    }
                });
            }
            else if (DLLInjecting)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"{Application.ProductName} {Application.ProductVersion}",
                    State = $"Injecting DLL",
                    Assets = new Assets()
                    {
                        LargeImageKey = "logo",
                        LargeImageText = "Dream DLL Injector",
                    }
                });
            }
            else if (SelectingDLL)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"{Application.ProductName} {Application.ProductVersion}",
                    State = $"Selecting DLL",
                    Assets = new Assets()
                    {
                        LargeImageKey = "logo",
                        LargeImageText = "Dream DLL Injector",
                    }
                });
            }
            else if (SelectedDLL)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"{Application.ProductName} {Application.ProductVersion}",
                    State = $"Selected DLL",
                    Assets = new Assets()
                    {
                        LargeImageKey = "logo",
                        LargeImageText = "Dream DLL Injector",
                    }
                });
            }
        }

        public static void ShutDown()
        {
            client.Dispose();
        }
    }
}
