using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok
{
    enum Audience
    {
        world,
        group,
        special
    }
    class TikTok
    {
        private static int _ID;
        public string Originator { get; }
        public int Length { get; }
        public string HashTag { get; }
        public Audience Audience { get; }
        public string Id { get; }

        public TikTok(string originator, int length, string hashTag, Audience audience)
        {
            Originator = originator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;
            Id = _ID.ToString();
            _ID++;
        }

        private TikTok(string id, string originator, int length, string hashTag, Audience audience)
        {

            Id = id;
            Originator = originator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;
        }
        public override string ToString()
        {
            return $"ID:{Id}\tOriginator:{Originator}\tLength:{Length}\tHashTag:{HashTag}\tAudience:{Audience}";
        }

        public static TikTok Parse(string line)
        {
            string[] values = line.Split('\t');
            string ID = values[0];
            string Originator = values[1];
            int Length = Convert.ToInt32(values[2]);
            string HashTag = values[3];
            string Audience = values[4];

            TikTok objects = new TikTok(values[0], values[1], values[2], values[3], values[4]);

            return objects;

        }
    }
}
