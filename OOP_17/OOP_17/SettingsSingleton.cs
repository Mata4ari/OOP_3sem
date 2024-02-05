using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    public class SettingsSingleton
    {
        private static SettingsSingleton instance;
        public string BackgroundColor { get; set; }
        public string FontFamily { get; set; }
        public string FontStyle { get; set; }
        public string SizeX { get; set; }
        public string SizeY { get; set; }

        private SettingsSingleton() { }

        public static SettingsSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingsSingleton();
                }
                return instance;
            }
        }
    }
}
