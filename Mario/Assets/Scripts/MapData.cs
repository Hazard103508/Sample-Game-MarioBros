using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData
{
    public string backgroundcolor { get; set; }
    public List<Layer> layers { get; set; }
    public class Layer
    {
        public List<int> data { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }
}
