using System;

namespace Tiktok
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiktokmanager.Initialize();
            Tiktokmanager.Show();
            Tiktokmanager.Show("duet");
            Tiktokmanager.Show(300);
            Tiktokmanager.Show(Audience.special);
        }
    }
}
