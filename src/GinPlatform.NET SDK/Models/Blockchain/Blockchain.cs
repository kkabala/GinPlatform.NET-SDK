using System.Collections.Generic;

namespace GinPlatform.NET_SDK.Models.Blockchain
{
    public class Blockchain
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ticker { get; set; }
        public List<int> Collaterals { get; set; }
        public string Img { get; set; }
        public string ImgLarge { get; set; }
        public string Website { get; set; }
        public string Explorer { get; set; }
        public List<Exchange> Exchanges { get; set; }
        public string Github { get; set; }
        public string Discord { get; set; }
        public string Telegram { get; set; }
        public string Twitter { get; set; }
        public bool Disabled { get; set; }
        public double Roi { get; set; }
        public int Masternodes { get; set; }
        public double Price { get; set; }
    }
}