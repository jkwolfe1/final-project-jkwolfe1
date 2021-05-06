using System;
using System.ComponentModel.DataAnnotations;

namespace Project
{
    public class Hero
    {
        public int HeroId {get; set;}
        public string Name {get; set;}
        public string Role {get; set;}
        public int HitPoints {get; set;}
        public string Abilities {get; set;}
    }
}