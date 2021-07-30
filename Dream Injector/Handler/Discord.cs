using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dream_Injector.Handler.Structs;
using DiscordRPC;

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
                Details = $"Dream Injector",
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
                    Details = $"Dream Injector",
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
                    Details = $"Dream Injector",
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
                    Details = $"Dream Injector",
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
                    Details = $"Dream Injector",
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
                    Details = $"Dream Injector",
                    State = $"Selected DLL",
                    Assets = new Assets()
                    {
                        LargeImageKey = "logo",
                        LargeImageText = "Dream DLL Injector",
                    }
                });
            }
        }
    }
}
