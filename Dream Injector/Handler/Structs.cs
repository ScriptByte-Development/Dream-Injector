using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream_Injector.Handler
{
    public static class Structs
    {
        public static bool Idle;
        public static bool Injected;
        public static bool SelectingDLL;
        public static bool SelectedDLL;
        public static bool DLLInjecting;

        public static void Idling()
        {
            Idle = true;
        }

        public static void Inject()
        {
            Injected = true;
        }

        public static void Selecting()
        {
            SelectingDLL = true;
        }

        public static void Selected()
        {
            SelectedDLL = true;
        }

        public static void Injecting()
        {
            DLLInjecting = true;
        }

        public static void Reset()
        {
            Idle = false;
            DLLInjecting = false;
            SelectingDLL = false;
        }

        public static void ResetAll()
        {
            Idle = false;
            Injected = false;
            SelectingDLL = false;
            SelectedDLL = false;
            DLLInjecting = false;
        }
    }
}
