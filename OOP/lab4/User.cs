using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    public class User
    {
        public string Background { get; set; }
        public Font FontType { get; set; }
        public int FontSize { get; set; }

    }

    public class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        public User config;

        private Singleton()
        {
            config = new User
            {
                Background = "#E0E0E0",
                FontType = new Font("Arial", 9.0f),
                FontSize = 11
            };
        }

        public static Singleton GetInstance()
        {
            return lazy.Value;
        }
    }
}