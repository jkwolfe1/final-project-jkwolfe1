using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OwContext(
                serviceProvider.GetRequiredService<DbContextOptions<OwContext>>()))
            {
                if (context.Heroes.Any())
                {
                    return;
                }

                context.Heroes.AddRange(
                    new Hero
                    {
                        Name = "D.Va",
                        Role = "Tank",
                        HitPoints = 600,
                        Abilities = "Fusion Cannons, Defensive Matrix, Boosters, Micro Missles, Self-Destruct"
                    },
                    new Hero
                    {
                        Name = "Orisa",
                        Role = "Tank",
                        HitPoints = 450,
                        Abilities = "Fusion Driver, Halt!, Fortify, Protective Barrier, Supercharger"
                    },
                    new Hero
                    {
                        Name = "Reinhardt",
                        Role = "Tank",
                        HitPoints = 500,
                        Abilities = "Steadfast, Rocket Hammer, Barrier Field, Charge, Fire Strike, Earthshatter"
                    },
                    new Hero
                    {
                        Name = "Roadhog",
                        Role = "Tank",
                        HitPoints = 600,
                        Abilities = "Scrap Gun, Take a Breather, Chain Hook, Whole Hog"
                    },
                    new Hero
                    {
                        Name = "Sigma",
                        Role = "Tank",
                        HitPoints = 400,
                        Abilities = "Hyperspheres, Experimental Barrier, Kinetic Grasp, Accretion, Gravitic Flux"
                    },
                    new Hero
                    {
                        Name = "Winston",
                        Role = "Tank",
                        HitPoints = 500,
                        Abilities = "Tesla Cannon, Jump Pack, Barrier Projector, Primal Rage"
                    },
                    new Hero
                    {
                        Name = "Wrecking Ball",
                        Role = "Tank",
                        HitPoints = 600,
                        Abilities = "Quad Cannons, Grappling Claw, Roll, Adaptive Shield, Piledriver, Mindfield"
                    },
                    new Hero
                    {
                        Name = "Zarya",
                        Role = "Tank",
                        HitPoints = 400,
                        Abilities = "Energy, Particle Cannon, Particle Barrier, Projected Barrier, Graviton Surge"
                    },
                    new Hero
                    {
                        Name = "Ashe",
                        Role = "Damage",
                        HitPoints = 200,
                        Abilities = "The Viper, Dynamite, Coach Gun, B.O.B."
                    },
                    new Hero
                    {
                        Name = "Bastion",
                        Role = "Damage",
                        HitPoints = 300,
                        Abilities = "Ironclad, Recon, Sentry, Self-Repair, Tank"
                    },
                    new Hero
                    {
                        Name = "Doomfist",
                        Role = "Damage",
                        HitPoints = 250,
                        Abilities = "The Best Defense..., Hand Cannon, Rising Uppercut, Seismic Slam, Rocket Punch, Meteor Strike"
                    },
                    new Hero
                    {
                        Name = "Echo",
                        Role = "Damage",
                        HitPoints = 200,
                        Abilities = "Glide, Tri-Shot, Sticky Bombs, Flight, Focusing Beam, Duplicate"
                    },
                    new Hero
                    {
                        Name = "Genji",
                        Role = "Damage",
                        HitPoints = 200,
                        Abilities = "Cyber-Agility, Shuriken, Swift Strike, Deflect, Dragonblade"
                    },
                    new Hero
                    {
                        Name = "Hanzo",
                        Role = "Damage",
                        HitPoints = 200,
                        Abilities = "Wall Climb, Storm Bow, Sonic Arrow, Storm Arrows, Lunge, Dragonstrike"
                    },
                    new Hero
                    {
                        Name = "Junkrat",
                        Role = "Damage",
                        HitPoints = 200,
                        Abilities = "Frag Launcher, Concussion Mine, Steel Trap, RIP-Tire"
                    },
                    new Hero
                    {
                        Name = "McCree",
                        Role = "Damage",
                        HitPoints = 225,
                        Abilities = "Peacekeeper, Combat Roll, Flashbang, Deadeye"
                    },
                    new Hero
                    {
                        Name = "Mei",
                        Role = "Damage",
                        HitPoints = 200,
                        Abilities = "Endothermic Blaster, Cryo-Freeze, Ice Wall, Blizzard"
                    },
                    new Hero
                    {
                        Name = "Pharah",
                        Role = "Damage",
                        HitPoints = 200,
                        Abilities = "Hover Jets, Rocket Launcher, Jump Jet, Concussive Blast, Barrage"
                    },
                    new Hero
                    {
                        Name = "Reaper",
                        Role = "Damage",
                        HitPoints = 250,
                        Abilities = "The Reaping, Hellfire Shotguns, Wraith Form, Shadow Step, Death Blossom"
                    },
                    new Hero
                    {
                        Name = "Soldier: 76",
                        Role = "Damage",
                        HitPoints = 200,
                        Abilities = "Heavy Pulse Rifle, Helix Rockets, Sprint, Biotic Field, Tactical Visor"
                    },
                    new Hero
                    {
                        Name = "Sombra",
                        Role = "Damage",
                        HitPoints = 200,
                        Abilities = "Opportunist, Machine Pistol, Hack, Stealth, Translocator, EMP"
                    },
                    new Hero
                    {
                        Name = "Symmetra",
                        Role = "Damage",
                        HitPoints = 225,
                        Abilities = "Photon Projector, Sentry Turret, Teleporter, Photon Barrier"
                    },
                    new Hero
                    {
                        Name = "Torbjorn",
                        Role = "Damage",
                        HitPoints = 200,
                        Abilities = "Rivet Gun, Forge Hammer, Deploy Turret, Overload, Molten Core"
                    },
                    new Hero
                    {
                        Name = "Tracer",
                        Role = "Damage",
                        HitPoints = 150,
                        Abilities = "Pulse Pistols, Blink, Recall, Pulse Bomb, Supercharger"
                    },
                    new Hero
                    {
                        Name = "Widowmaker",
                        Role = "Damage",
                        HitPoints = 175,
                        Abilities = "Widow's Kiss, Grappling Hook, Venom Mine, Infra-Sight"
                    },
                    new Hero
                    {
                        Name = "Ana",
                        Role = "Support",
                        HitPoints = 200,
                        Abilities = "Biotic Rifle, Sleep Dart, Biotic Grenade, Nano Boost"
                    },
                    new Hero
                    {
                        Name = "Baptiste",
                        Role = "Support",
                        HitPoints = 200,
                        Abilities = "Exo Boots, Biotic Launcher, Regenerative Burst, Immortality Field, Amplification Matrix"
                    },
                    new Hero
                    {
                        Name = "Brigitte",
                        Role = "Support",
                        HitPoints = 200,
                        Abilities = "Inspire, Rocket Flail, Repair Pack, Whip Shot, Barrier Shield, Shield Bash, Rally"
                    },
                    new Hero
                    {
                        Name = "Lucio",
                        Role = "Support",
                        HitPoints = 200,
                        Abilities = "Wall Ride, Sonic Amplifier, Soundwave, Crossfade, Amp It Up, Sound Barrier"
                    },
                    new Hero
                    {
                        Name = "Mercy",
                        Role = "Support",
                        HitPoints = 200,
                        Abilities = "Regeneration, Angelic Descent, Caduceus Staff, Caduceus Blaster, Guardian Angel, Resurrect, Valkyrie"
                    },
                    new Hero
                    {
                        Name = "Moira",
                        Role = "Support",
                        HitPoints = 200,
                        Abilities = "Biotic Grasp, Biotic Orb, Fade, Coalescence"
                    },
                    new Hero
                    {
                        Name = "Zenyatta",
                        Role = "Support",
                        HitPoints = 200,
                        Abilities = "Orb of Destruction, Orb of Harmony, Orb of Discord, Transcendence"
                    }  
                );

                if (context.Maps.Any())
                {
                    return;
                }
                 
                 context.Maps.AddRange(
                    
                    new Map
                    {
                        Name = "Hanamura",
                        GameMode = "Assault",
                        Location = "Japan"
                    },
                    new Map
                    {
                        Name = "Temple of Anubis",
                        GameMode = "Assault",
                        Location = "Egypt"
                    },
                    new Map
                    {
                        Name = "Volskaya Industries",
                        GameMode = "Assault",
                        Location = "Russia"
                    },
                    new Map
                    {
                        Name = "Dorado",
                        GameMode = "Escort",
                        Location = "Mexico"
                    },
                    new Map
                    {
                        Name = "Havana",
                        GameMode = "Escort",
                        Location = "Cuba"
                    },
                    new Map
                    {
                        Name = "Junkertown",
                        GameMode = "Escort",
                        Location = "Australia"
                    },
                    new Map
                    {
                        Name = "Rialto",
                        GameMode = "Escort",
                        Location = "Italy"
                    },
                    new Map
                    {
                        Name = "Route 66",
                        GameMode = "Escort",
                        Location = "United States"
                    },
                    new Map
                    {
                        Name = "Watchpoint: Gibralter",
                        GameMode = "Escort",
                        Location = "Gibraltar"
                    },
                    new Map
                    {
                        Name = "Blizzard World",
                        GameMode = "Hybrid",
                        Location = "United States"
                    },
                    new Map
                    {
                        Name = "Eichenwalde",
                        GameMode = "Hybrid",
                        Location = "Germany"
                    },
                    new Map
                    {
                        Name = "Hollywood",
                        GameMode = "Hybrid",
                        Location = "United States"
                    },
                    new Map
                    {
                        Name = "King's Row",
                        GameMode = "Hybrid",
                        Location = "United Kingdom"
                    },
                    new Map
                    {
                        Name = "Numbani",
                        GameMode = "Hybrid",
                        Location = "Nigeria"
                    },
                    new Map
                    {
                        Name = "Busan",
                        GameMode = "Control",
                        Location = "South Korea"
                    },
                    new Map
                    {
                        Name = "Ilios",
                        GameMode = "Control",
                        Location = "Greece"
                    },
                    new Map
                    {
                        Name = "Lijiang Tower",
                        GameMode = "Control",
                        Location = "China"
                    },
                    new Map
                    {
                        Name = "Nepal",
                        GameMode = "Control",
                        Location = "Nepal"
                    },
                    new Map
                    {
                        Name = "Oasis",
                        GameMode = "Control",
                        Location = "Iraq"
                    } 
                );
                context.SaveChanges();
            }
        }
    }
}