using System;
using System.ComponentModel.DataAnnotations;

namespace Project
{
    public class Map
    {
        public int MapId {get; set;}
        public string Name {get; set;}
        public string GameMode {get; set;}
        public string Location {get; set;}
    }
}