using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Tiktok
{
    static class Tiktokmanager
    {
        private static List<TikTok> TIKTOKS;
        private static string filename = "tiktoklist.txt";
        static Tiktokmanager()
        {
            TIKTOKS = new List<TikTok>();
            TextReader reader = new StreamReader(filename);
            string line = reader.ReadLine();
            while (line != null)
            {
                string ID = values[0];
                string Originator = values[1];
                int Length = Convert.ToInt32(values[2]);
                string HashTag = values[3];
                Audience Audience = values[4];
                TIKTOKS.Add(TikTok.Parse(values));
                line = reader.ReadLine();
            }
            reader.Close();
        }
        public static void Initialize()
        {
            TIKTOKS.Add(new TikTok("Rose", 300, "duet", Audience.special));
            TIKTOKS.Add(new TikTok("Liam", 400, "food", Audience.group));
            TIKTOKS.Add(new TikTok("Noah", 500, "trending", Audience.world));
            TIKTOKS.Add(new TikTok("Olivia", 100, "comedy", Audience.group));
            TIKTOKS.Add(new TikTok("John", 200, "funny", Audience.world));
        }

        public static void Show()
        {
            foreach (TikTok objects in TIKTOKS)
            {
                Console.WriteLine(objects);
            }
        }

        public static void Show(string hashtag)
        {
            foreach (TikTok objects in TIKTOKS)
            {
                if (objects.HashTag == hashtag)
                {
                    Console.WriteLine(objects);
                }
            }
        }

        public static void Show(int length)
        {
            foreach (TikTok objects in TIKTOKS)
            {
                if (objects.Length > length)
                {
                    Console.WriteLine(objects);
                }
            }
        }
        public static void Show(Audience audience)
        {
            foreach (TikTok objects in TIKTOKS)
            {
                if (objects.Audience == audience)
                {
                    Console.WriteLine(objects);
                }
            }
        }
    }
}

