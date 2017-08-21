using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialMovie.Models;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialMovie.Controllers
{
    public class HomeController : Controller
    {
        private SocialMovieContext _context;

        public HomeController(SocialMovieContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();

            var movie = new Movie()
            {
                Name = "Split",
                Description = "Rapaz que rouba mocas",
                Type = ContentType.Movie,
                Thumbnail = new Archive()
                {
                    Name = "split",
                    Path = "split/",
                    Extension = ".jpg",
                    Type = ArchiveType.Image
                },
                VideoFile = new Archive()
                {
                    Name = "stream",
                    Path = "split/video",
                    Extension = "mpd",
                    Type = ArchiveType.Video
                },
                Star1 = 10,
                Star2 = 20,
                Star3 = 30,
                Star4 = 40,
                Star5 = 50
            };


            Content split = _context.Contents.FirstOrDefault(c => c.Name == "Split");
            if (split == null)
            {
                _context.Contents.Add(movie);
            }

            var jerrygoround = new Archive()
            {
                Extension = "mpd",
                Name = "JerryGoRound_vod",
                Path = "JerryGoRound_output"
            };

            //var justducky = new Archive()
            //{
            //    Extension = "mpd",
            //    Name = "JustDucky_vod",
            //    Path = "JustDucky_output"
            //};

            var episodes = new List<Episode>
            {
                new Episode() { ENumber = 1, SNumber = 1, VideoFile = jerrygoround },
                //episodes.Add(new Episode() { ENumber = 2, SNumber = 2, VideoFile = justducky });
                //episodes.Add(new Episode()
                //{
                //    Name = "JustDucky",
                //    ENumber = 2,
                //    SNumber = 2,
                //    VideoFile = new Archive()
                //    {
                //        Extension = "mpd",
                //        Name = "JustDucky_vod",
                //        Path = "JustDucky_output"
                //    }
                //});

                new Episode()
                {
                    Name = "NeapolitanMouse",
                    ENumber = 0,
                    SNumber = 1,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "NeapolitanMouse_vod",
                        Path = "tom-and-jerry/NeapolitanMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "MouseinManhattan",
                    ENumber = 0,
                    SNumber = 2,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "MouseinManhattan_vod",
                        Path = "tom-and-jerry/MouseinManhattan_output"
                    }
                },


                new Episode()
                {
                    Name = "SafetySecond",
                    ENumber = 0,
                    SNumber = 3,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SafetySecond_vod",
                        Path = "tom-and-jerry/SafetySecond_output"
                    }
                },


                new Episode()
                {
                    Name = "TheBowlingAlleyCat",
                    ENumber = 0,
                    SNumber = 4,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheBowlingAlleyCat_vod",
                        Path = "tom-and-jerry/TheBowlingAlleyCat_output"
                    }
                },


                new Episode()
                {
                    Name = "DesignsonJerry",
                    ENumber = 0,
                    SNumber = 5,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "DesignsonJerry_vod",
                        Path = "tom-and-jerry/DesignsonJerry_output"
                    }
                },


                new Episode()
                {
                    Name = "TheTruceHurts",
                    ENumber = 0,
                    SNumber = 6,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheTruceHurts_vod",
                        Path = "tom-and-jerry/TheTruceHurts_output"
                    }
                },


                new Episode()
                {
                    Name = "MuchoMouse",
                    ENumber = 0,
                    SNumber = 7,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "MuchoMouse_vod",
                        Path = "tom-and-jerry/MuchoMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "JohannMouse",
                    ENumber = 0,
                    SNumber = 8,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "JohannMouse_vod",
                        Path = "tom-and-jerry/JohannMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "TheFlyingCat",
                    ENumber = 0,
                    SNumber = 9,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheFlyingCat_vod",
                        Path = "tom-and-jerry/TheFlyingCat_output"
                    }
                },


                new Episode()
                {
                    Name = "CarmenGetIt!",
                    ENumber = 0,
                    SNumber = 10,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "CarmenGetIt!_vod",
                        Path = "tom-and-jerry/CarmenGetIt!_output"
                    }
                },


                new Episode()
                {
                    Name = "LoveMeLoveMyMouse",
                    ENumber = 0,
                    SNumber = 11,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "LoveMeLoveMyMouse_vod",
                        Path = "tom-and-jerry/LoveMeLoveMyMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "CatandDuplicat",
                    ENumber = 0,
                    SNumber = 12,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "CatandDuplicat_vod",
                        Path = "tom-and-jerry/CatandDuplicat_output"
                    }
                },


                new Episode()
                {
                    Name = "TheATomInableSnowman",
                    ENumber = 0,
                    SNumber = 13,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheATomInableSnowman_vod",
                        Path = "tom-and-jerry/TheATomInableSnowman_output"
                    }
                },


                new Episode()
                {
                    Name = "SlickedupPup",
                    ENumber = 0,
                    SNumber = 14,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SlickedupPup_vod",
                        Path = "tom-and-jerry/SlickedupPup_output"
                    }
                },


                new Episode()
                {
                    Name = "TopswithPops",
                    ENumber = 0,
                    SNumber = 15,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TopswithPops_vod",
                        Path = "tom-and-jerry/TopswithPops_output"
                    }
                },


                new Episode()
                {
                    Name = "TripletTrouble",
                    ENumber = 0,
                    SNumber = 16,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TripletTrouble_vod",
                        Path = "tom-and-jerry/TripletTrouble_output"
                    }
                },


                new Episode()
                {
                    Name = "SorrySafari",
                    ENumber = 0,
                    SNumber = 17,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SorrySafari_vod",
                        Path = "tom-and-jerry/SorrySafari_output"
                    }
                },


                new Episode()
                {
                    Name = "LoveThatPup",
                    ENumber = 0,
                    SNumber = 18,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "LoveThatPup_vod",
                        Path = "tom-and-jerry/LoveThatPup_output"
                    }
                },


                new Episode()
                {
                    Name = "KittyFoiled",
                    ENumber = 0,
                    SNumber = 19,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "KittyFoiled_vod",
                        Path = "tom-and-jerry/KittyFoiled_output"
                    }
                },


                new Episode()
                {
                    Name = "TheLittleOrphan",
                    ENumber = 0,
                    SNumber = 20,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheLittleOrphan_vod",
                        Path = "tom-and-jerry/TheLittleOrphan_output"
                    }
                },


                new Episode()
                {
                    Name = "PurrChancetoDream",
                    ENumber = 0,
                    SNumber = 21,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PurrChancetoDream_vod",
                        Path = "tom-and-jerry/PurrChancetoDream_output"
                    }
                },


                new Episode()
                {
                    Name = "TheMousefromH.U.N.G.E.R.",
                    ENumber = 0,
                    SNumber = 22,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheMousefromH.U.N.G.E.R._vod",
                        Path = "tom-and-jerry/TheMousefromH.U.N.G.E.R._output"
                    }
                },


                new Episode()
                {
                    Name = "FlirtyBirdy",
                    ENumber = 0,
                    SNumber = 23,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "FlirtyBirdy_vod",
                        Path = "tom-and-jerry/FlirtyBirdy_output"
                    }
                },


                new Episode()
                {
                    Name = "CatNapping",
                    ENumber = 0,
                    SNumber = 24,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "CatNapping_vod",
                        Path = "tom-and-jerry/CatNapping_output"
                    }
                },


                new Episode()
                {
                    Name = "SwitchinKitten",
                    ENumber = 0,
                    SNumber = 25,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SwitchinKitten_vod",
                        Path = "tom-and-jerry/SwitchinKitten_output"
                    }
                },


                new Episode()
                {
                    Name = "AhSweetMouseStoryofLife",
                    ENumber = 0,
                    SNumber = 26,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "AhSweetMouseStoryofLife_vod",
                        Path = "tom-and-jerry/AhSweetMouseStoryofLife_output"
                    }
                },


                new Episode()
                {
                    Name = "TheDuckDoctor",
                    ENumber = 0,
                    SNumber = 27,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheDuckDoctor_vod",
                        Path = "tom-and-jerry/TheDuckDoctor_output"
                    }
                },


                new Episode()
                {
                    Name = "CasanovaCat",
                    ENumber = 0,
                    SNumber = 28,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "CasanovaCat_vod",
                        Path = "tom-and-jerry/CasanovaCat_output"
                    }
                },


                new Episode()
                {
                    Name = "TheFramedCat",
                    ENumber = 0,
                    SNumber = 29,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheFramedCat_vod",
                        Path = "tom-and-jerry/TheFramedCat_output"
                    }
                },


                new Episode()
                {
                    Name = "HighSteaks",
                    ENumber = 0,
                    SNumber = 30,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "HighSteaks_vod",
                        Path = "tom-and-jerry/HighSteaks_output"
                    }
                },


                new Episode()
                {
                    Name = "PetPeeve",
                    ENumber = 0,
                    SNumber = 31,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PetPeeve_vod",
                        Path = "tom-and-jerry/PetPeeve_output"
                    }
                },


                new Episode()
                {
                    Name = "SaturdayEveningPuss",
                    ENumber = 0,
                    SNumber = 32,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SaturdayEveningPuss_vod",
                        Path = "tom-and-jerry/SaturdayEveningPuss_output"
                    }
                },


                new Episode()
                {
                    Name = "MiceFollies",
                    ENumber = 0,
                    SNumber = 33,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "MiceFollies_vod",
                        Path = "tom-and-jerry/MiceFollies_output"
                    }
                },


                new Episode()
                {
                    Name = "TallintheTrap",
                    ENumber = 0,
                    SNumber = 34,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TallintheTrap_vod",
                        Path = "tom-and-jerry/TallintheTrap_output"
                    }
                },


                new Episode()
                {
                    Name = "LittleRunaway",
                    ENumber = 0,
                    SNumber = 35,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "LittleRunaway_vod",
                        Path = "tom-and-jerry/LittleRunaway_output"
                    }
                },


                new Episode()
                {
                    Name = "TheInvisibleMouse",
                    ENumber = 0,
                    SNumber = 36,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheInvisibleMouse_vod",
                        Path = "tom-and-jerry/TheInvisibleMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "TheBodyguard",
                    ENumber = 0,
                    SNumber = 37,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheBodyguard_vod",
                        Path = "tom-and-jerry/TheBodyguard_output"
                    }
                },


                new Episode()
                {
                    Name = "AdvanceandBeMechanized",
                    ENumber = 0,
                    SNumber = 38,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "AdvanceandBeMechanized_vod",
                        Path = "tom-and-jerry/AdvanceandBeMechanized_output"
                    }
                },


                new Episode()
                {
                    Name = "TheMilkyWaif",
                    ENumber = 0,
                    SNumber = 39,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheMilkyWaif_vod",
                        Path = "tom-and-jerry/TheMilkyWaif_output"
                    }
                },


                new Episode()
                {
                    Name = "AMouseintheHouse",
                    ENumber = 0,
                    SNumber = 40,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "AMouseintheHouse_vod",
                        Path = "tom-and-jerry/AMouseintheHouse_output"
                    }
                },


                new Episode()
                {
                    Name = "TheMouseComestoDinner",
                    ENumber = 0,
                    SNumber = 41,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheMouseComestoDinner_vod",
                        Path = "tom-and-jerry/TheMouseComestoDinner_output"
                    }
                },


                new Episode()
                {
                    Name = "PussGetstheBoot",
                    ENumber = 0,
                    SNumber = 42,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PussGetstheBoot_vod",
                        Path = "tom-and-jerry/PussGetstheBoot_output"
                    }
                },


                new Episode()
                {
                    Name = "FraidyCat",
                    ENumber = 0,
                    SNumber = 43,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "FraidyCat_vod",
                        Path = "tom-and-jerry/FraidyCat_output"
                    }
                },


                new Episode()
                {
                    Name = "CruiseCat",
                    ENumber = 0,
                    SNumber = 44,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "CruiseCat_vod",
                        Path = "tom-and-jerry/CruiseCat_output"
                    }
                },


                new Episode()
                {
                    Name = "PussnBoats",
                    ENumber = 0,
                    SNumber = 45,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PussnBoats_vod",
                        Path = "tom-and-jerry/PussnBoats_output"
                    }
                },


                new Episode()
                {
                    Name = "SpringtimeforThomas",
                    ENumber = 0,
                    SNumber = 46,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SpringtimeforThomas_vod",
                        Path = "tom-and-jerry/SpringtimeforThomas_output"
                    }
                },


                new Episode()
                {
                    Name = "MuscleBeachTom",
                    ENumber = 0,
                    SNumber = 47,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "MuscleBeachTom_vod",
                        Path = "tom-and-jerry/MuscleBeachTom_output"
                    }
                },


                new Episode()
                {
                    Name = "JerryGoRound",
                    ENumber = 0,
                    SNumber = 48,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "JerryGoRound_vod",
                        Path = "tom-and-jerry/JerryGoRound_output"
                    }
                },


                new Episode()
                {
                    Name = "Touch#UePussyCat!",
                    ENumber = 0,
                    SNumber = 49,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "Touch#UePussyCat!_vod",
                        Path = "tom-and-jerry/Touch#UePussyCat!_output"
                    }
                },


                new Episode()
                {
                    Name = "DownheartedDuckling",
                    ENumber = 0,
                    SNumber = 50,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "DownheartedDuckling_vod",
                        Path = "tom-and-jerry/DownheartedDuckling_output"
                    }
                },


                new Episode()
                {
                    Name = "OSolarMeow",
                    ENumber = 0,
                    SNumber = 51,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "OSolarMeow_vod",
                        Path = "tom-and-jerry/OSolarMeow_output"
                    }
                },


                new Episode()
                {
                    Name = "TwoLittleIndians",
                    ENumber = 0,
                    SNumber = 52,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TwoLittleIndians_vod",
                        Path = "tom-and-jerry/TwoLittleIndians_output"
                    }
                },


                new Episode()
                {
                    Name = "JerryandtheLion",
                    ENumber = 0,
                    SNumber = 53,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "JerryandtheLion_vod",
                        Path = "tom-and-jerry/JerryandtheLion_output"
                    }
                },


                new Episode()
                {
                    Name = "HatchUpYourTroubles",
                    ENumber = 0,
                    SNumber = 54,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "HatchUpYourTroubles_vod",
                        Path = "tom-and-jerry/HatchUpYourTroubles_output"
                    }
                },


                new Episode()
                {
                    Name = "JerryandJumbo",
                    ENumber = 0,
                    SNumber = 55,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "JerryandJumbo_vod",
                        Path = "tom-and-jerry/JerryandJumbo_output"
                    }
                },


                new Episode()
                {
                    Name = "CanneryRodent",
                    ENumber = 0,
                    SNumber = 56,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "CanneryRodent_vod",
                        Path = "tom-and-jerry/CanneryRodent_output"
                    }
                },


                new Episode()
                {
                    Name = "OldRockinChairTom",
                    ENumber = 0,
                    SNumber = 57,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "OldRockinChairTom_vod",
                        Path = "tom-and-jerry/OldRockinChairTom_output"
                    }
                },


                new Episode()
                {
                    Name = "SmittenKitten",
                    ENumber = 0,
                    SNumber = 58,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SmittenKitten_vod",
                        Path = "tom-and-jerry/SmittenKitten_output"
                    }
                },


                new Episode()
                {
                    Name = "FiletMeow",
                    ENumber = 0,
                    SNumber = 59,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "FiletMeow_vod",
                        Path = "tom-and-jerry/FiletMeow_output"
                    }
                },


                new Episode()
                {
                    Name = "HauntedMouse",
                    ENumber = 0,
                    SNumber = 60,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "HauntedMouse_vod",
                        Path = "tom-and-jerry/HauntedMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "JerryandtheGoldfish",
                    ENumber = 0,
                    SNumber = 61,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "JerryandtheGoldfish_vod",
                        Path = "tom-and-jerry/JerryandtheGoldfish_output"
                    }
                },


                new Episode()
                {
                    Name = "TomsPhotoFinish",
                    ENumber = 0,
                    SNumber = 62,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TomsPhotoFinish_vod",
                        Path = "tom-and-jerry/TomsPhotoFinish_output"
                    }
                },


                new Episode()
                {
                    Name = "TheEggandJerry",
                    ENumber = 0,
                    SNumber = 63,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheEggandJerry_vod",
                        Path = "tom-and-jerry/TheEggandJerry_output"
                    }
                },


                new Episode()
                {
                    Name = "OfFelineBondage",
                    ENumber = 0,
                    SNumber = 64,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "OfFelineBondage_vod",
                        Path = "tom-and-jerry/OfFelineBondage_output"
                    }
                },


                new Episode()
                {
                    Name = "LifewithTom",
                    ENumber = 0,
                    SNumber = 65,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "LifewithTom_vod",
                        Path = "tom-and-jerry/LifewithTom_output"
                    }
                },


                new Episode()
                {
                    Name = "DickyMoe",
                    ENumber = 0,
                    SNumber = 66,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "DickyMoe_vod",
                        Path = "tom-and-jerry/DickyMoe_output"
                    }
                },


                new Episode()
                {
                    Name = "ItsGreektoMeow",
                    ENumber = 0,
                    SNumber = 67,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "ItsGreektoMeow_vod",
                        Path = "tom-and-jerry/ItsGreektoMeow_output"
                    }
                },


                new Episode()
                {
                    Name = "PuppyTale",
                    ENumber = 0,
                    SNumber = 68,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PuppyTale_vod",
                        Path = "tom-and-jerry/PuppyTale_output"
                    }
                },


                new Episode()
                {
                    Name = "MouseforSale",
                    ENumber = 0,
                    SNumber = 69,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "MouseforSale_vod",
                        Path = "tom-and-jerry/MouseforSale_output"
                    }
                },


                new Episode()
                {
                    Name = "MatineeMouse",
                    ENumber = 0,
                    SNumber = 70,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "MatineeMouse_vod",
                        Path = "tom-and-jerry/MatineeMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "ProfessorTom",
                    ENumber = 0,
                    SNumber = 71,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "ProfessorTom_vod",
                        Path = "tom-and-jerry/ProfessorTom_output"
                    }
                },


                new Episode()
                {
                    Name = "RoyalCatNap",
                    ENumber = 0,
                    SNumber = 72,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "RoyalCatNap_vod",
                        Path = "tom-and-jerry/RoyalCatNap_output"
                    }
                },


                new Episode()
                {
                    Name = "TheMillionDollarCat",
                    ENumber = 0,
                    SNumber = 73,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheMillionDollarCat_vod",
                        Path = "tom-and-jerry/TheMillionDollarCat_output"
                    }
                },


                new Episode()
                {
                    Name = "ImJustWildAboutJerry",
                    ENumber = 0,
                    SNumber = 74,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "ImJustWildAboutJerry_vod",
                        Path = "tom-and-jerry/ImJustWildAboutJerry_output"
                    }
                },


                new Episode()
                {
                    Name = "JustDucky",
                    ENumber = 0,
                    SNumber = 75,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "JustDucky_vod",
                        Path = "tom-and-jerry/JustDucky_output"
                    }
                },


                new Episode()
                {
                    Name = "TheCatAboveandtheMouseBelow",
                    ENumber = 0,
                    SNumber = 76,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheCatAboveandtheMouseBelow_vod",
                        Path = "tom-and-jerry/TheCatAboveandtheMouseBelow_output"
                    }
                },


                new Episode()
                {
                    Name = "QuietPlease!",
                    ENumber = 0,
                    SNumber = 77,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "QuietPlease!_vod",
                        Path = "tom-and-jerry/QuietPlease!_output"
                    }
                },


                new Episode()
                {
                    Name = "NitWittyKitty",
                    ENumber = 0,
                    SNumber = 78,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "NitWittyKitty_vod",
                        Path = "tom-and-jerry/NitWittyKitty_output"
                    }
                },


                new Episode()
                {
                    Name = "LittleQuacker",
                    ENumber = 0,
                    SNumber = 79,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "LittleQuacker_vod",
                        Path = "tom-and-jerry/LittleQuacker_output"
                    }
                },


                new Episode()
                {
                    Name = "TheZootCat",
                    ENumber = 0,
                    SNumber = 80,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheZootCat_vod",
                        Path = "tom-and-jerry/TheZootCat_output"
                    }
                },


                new Episode()
                {
                    Name = "Dr.JekyllandMr.Mouse",
                    ENumber = 0,
                    SNumber = 81,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "Dr.JekyllandMr.Mouse_vod",
                        Path = "tom-and-jerry/Dr.JekyllandMr.Mouse_output"
                    }
                },


                new Episode()
                {
                    Name = "TrapHappy",
                    ENumber = 0,
                    SNumber = 82,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TrapHappy_vod",
                        Path = "tom-and-jerry/TrapHappy_output"
                    }
                },


                new Episode()
                {
                    Name = "TheVanishingDuck",
                    ENumber = 0,
                    SNumber = 83,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheVanishingDuck_vod",
                        Path = "tom-and-jerry/TheVanishingDuck_output"
                    }
                },


                new Episode()
                {
                    Name = "RocknRodent",
                    ENumber = 0,
                    SNumber = 84,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "RocknRodent_vod",
                        Path = "tom-and-jerry/RocknRodent_output"
                    }
                },


                new Episode()
                {
                    Name = "BuddiesThickerThanWater",
                    ENumber = 0,
                    SNumber = 85,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "BuddiesThickerThanWater_vod",
                        Path = "tom-and-jerry/BuddiesThickerThanWater_output"
                    }
                },


                new Episode()
                {
                    Name = "PartTimePal",
                    ENumber = 0,
                    SNumber = 86,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PartTimePal_vod",
                        Path = "tom-and-jerry/PartTimePal_output"
                    }
                },


                new Episode()
                {
                    Name = "RobinHoodwinked",
                    ENumber = 0,
                    SNumber = 87,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "RobinHoodwinked_vod",
                        Path = "tom-and-jerry/RobinHoodwinked_output"
                    }
                },


                new Episode()
                {
                    Name = "DuelPersonality",
                    ENumber = 0,
                    SNumber = 88,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "DuelPersonality_vod",
                        Path = "tom-and-jerry/DuelPersonality_output"
                    }
                },


                new Episode()
                {
                    Name = "FittobeTied",
                    ENumber = 0,
                    SNumber = 89,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "FittobeTied_vod",
                        Path = "tom-and-jerry/FittobeTied_output"
                    }
                },


                new Episode()
                {
                    Name = "BarbecueBrawl",
                    ENumber = 0,
                    SNumber = 90,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "BarbecueBrawl_vod",
                        Path = "tom-and-jerry/BarbecueBrawl_output"
                    }
                },


                new Episode()
                {
                    Name = "JerrysDiary",
                    ENumber = 0,
                    SNumber = 91,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "JerrysDiary_vod",
                        Path = "tom-and-jerry/JerrysDiary_output"
                    }
                },


                new Episode()
                {
                    Name = "ThatsMyMommy",
                    ENumber = 0,
                    SNumber = 92,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "ThatsMyMommy_vod",
                        Path = "tom-and-jerry/ThatsMyMommy_output"
                    }
                },


                new Episode()
                {
                    Name = "TheYankeeDoodleMouse",
                    ENumber = 0,
                    SNumber = 93,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheYankeeDoodleMouse_vod",
                        Path = "tom-and-jerry/TheYankeeDoodleMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "PushButtonKitty",
                    ENumber = 0,
                    SNumber = 94,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PushButtonKitty_vod",
                        Path = "tom-and-jerry/PushButtonKitty_output"
                    }
                },


                new Episode()
                {
                    Name = "JerrysCousin",
                    ENumber = 0,
                    SNumber = 95,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "JerrysCousin_vod",
                        Path = "tom-and-jerry/JerrysCousin_output"
                    }
                },


                new Episode()
                {
                    Name = "TheDogHouse",
                    ENumber = 0,
                    SNumber = 96,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheDogHouse_vod",
                        Path = "tom-and-jerry/TheDogHouse_output"
                    }
                },


                new Episode()
                {
                    Name = "CueBallCat",
                    ENumber = 0,
                    SNumber = 97,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "CueBallCat_vod",
                        Path = "tom-and-jerry/CueBallCat_output"
                    }
                },


                new Episode()
                {
                    Name = "PosseCat",
                    ENumber = 0,
                    SNumber = 98,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PosseCat_vod",
                        Path = "tom-and-jerry/PosseCat_output"
                    }
                },


                new Episode()
                {
                    Name = "PussnToots",
                    ENumber = 0,
                    SNumber = 99,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PussnToots_vod",
                        Path = "tom-and-jerry/PussnToots_output"
                    }
                },


                new Episode()
                {
                    Name = "LandingStripling",
                    ENumber = 0,
                    SNumber = 100,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "LandingStripling_vod",
                        Path = "tom-and-jerry/LandingStripling_output"
                    }
                },


                new Episode()
                {
                    Name = "IsThereaDoctorintheMouse",
                    ENumber = 0,
                    SNumber = 101,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "IsThereaDoctorintheMouse_vod",
                        Path = "tom-and-jerry/IsThereaDoctorintheMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "TheHollywoodBowl",
                    ENumber = 0,
                    SNumber = 102,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheHollywoodBowl_vod",
                        Path = "tom-and-jerry/TheHollywoodBowl_output"
                    }
                },


                new Episode()
                {
                    Name = "ThatsMyPup!",
                    ENumber = 0,
                    SNumber = 103,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "ThatsMyPup!_vod",
                        Path = "tom-and-jerry/ThatsMyPup!_output"
                    }
                },


                new Episode()
                {
                    Name = "SolidSerenade",
                    ENumber = 0,
                    SNumber = 104,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SolidSerenade_vod",
                        Path = "tom-and-jerry/SolidSerenade_output"
                    }
                },


                new Episode()
                {
                    Name = "TheMissingMouse",
                    ENumber = 0,
                    SNumber = 105,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheMissingMouse_vod",
                        Path = "tom-and-jerry/TheMissingMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "TheFlyingSorceress",
                    ENumber = 0,
                    SNumber = 106,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheFlyingSorceress_vod",
                        Path = "tom-and-jerry/TheFlyingSorceress_output"
                    }
                },


                new Episode()
                {
                    Name = "DogTrouble",
                    ENumber = 0,
                    SNumber = 107,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "DogTrouble_vod",
                        Path = "tom-and-jerry/DogTrouble_output"
                    }
                },


                new Episode()
                {
                    Name = "ShutterBuggedCat",
                    ENumber = 0,
                    SNumber = 108,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "ShutterBuggedCat_vod",
                        Path = "tom-and-jerry/ShutterBuggedCat_output"
                    }
                },


                new Episode()
                {
                    Name = "SurfBoredCat",
                    ENumber = 0,
                    SNumber = 109,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SurfBoredCat_vod",
                        Path = "tom-and-jerry/SurfBoredCat_output"
                    }
                },


                new Episode()
                {
                    Name = "HiccupPup",
                    ENumber = 0,
                    SNumber = 110,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "HiccupPup_vod",
                        Path = "tom-and-jerry/HiccupPup_output"
                    }
                },


                new Episode()
                {
                    Name = "SaltWaterTabby",
                    ENumber = 0,
                    SNumber = 111,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SaltWaterTabby_vod",
                        Path = "tom-and-jerry/SaltWaterTabby_output"
                    }
                },


                new Episode()
                {
                    Name = "SnowbodyLovesMe",
                    ENumber = 0,
                    SNumber = 112,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SnowbodyLovesMe_vod",
                        Path = "tom-and-jerry/SnowbodyLovesMe_output"
                    }
                },


                new Episode()
                {
                    Name = "TexasTom",
                    ENumber = 0,
                    SNumber = 113,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TexasTom_vod",
                        Path = "tom-and-jerry/TexasTom_output"
                    }
                },


                new Episode()
                {
                    Name = "CatFishin",
                    ENumber = 0,
                    SNumber = 114,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "CatFishin_vod",
                        Path = "tom-and-jerry/CatFishin_output"
                    }
                },


                new Episode()
                {
                    Name = "SmartyCat",
                    ENumber = 0,
                    SNumber = 115,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SmartyCat_vod",
                        Path = "tom-and-jerry/SmartyCat_output"
                    }
                },


                new Episode()
                {
                    Name = "TheCatsMeOuch",
                    ENumber = 0,
                    SNumber = 116,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheCatsMeOuch_vod",
                        Path = "tom-and-jerry/TheCatsMeOuch_output"
                    }
                },


                new Episode()
                {
                    Name = "TheMidnightSnack",
                    ENumber = 0,
                    SNumber = 117,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheMidnightSnack_vod",
                        Path = "tom-and-jerry/TheMidnightSnack_output"
                    }
                },


                new Episode()
                {
                    Name = "PuponaPicnic",
                    ENumber = 0,
                    SNumber = 118,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PuponaPicnic_vod",
                        Path = "tom-and-jerry/PuponaPicnic_output"
                    }
                },


                new Episode()
                {
                    Name = "TheCatConcerto",
                    ENumber = 0,
                    SNumber = 119,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheCatConcerto_vod",
                        Path = "tom-and-jerry/TheCatConcerto_output"
                    }
                },


                new Episode()
                {
                    Name = "BlueCatBlues",
                    ENumber = 0,
                    SNumber = 120,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "BlueCatBlues_vod",
                        Path = "tom-and-jerry/BlueCatBlues_output"
                    }
                },


                new Episode()
                {
                    Name = "TheTomandJerryCartoonKit",
                    ENumber = 0,
                    SNumber = 121,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheTomandJerryCartoonKit_vod",
                        Path = "tom-and-jerry/TheTomandJerryCartoonKit_output"
                    }
                },


                new Episode()
                {
                    Name = "BadDayatCatRock",
                    ENumber = 0,
                    SNumber = 122,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "BadDayatCatRock_vod",
                        Path = "tom-and-jerry/BadDayatCatRock_output"
                    }
                },


                new Episode()
                {
                    Name = "HisMouseFriday",
                    ENumber = 0,
                    SNumber = 123,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "HisMouseFriday_vod",
                        Path = "tom-and-jerry/HisMouseFriday_output"
                    }
                },


                new Episode()
                {
                    Name = "TomandCh#Uerie",
                    ENumber = 0,
                    SNumber = 124,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TomandCh#Uerie_vod",
                        Path = "tom-and-jerry/TomandCh#Uerie_output"
                    }
                },


                new Episode()
                {
                    Name = "PecosPest",
                    ENumber = 0,
                    SNumber = 125,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PecosPest_vod",
                        Path = "tom-and-jerry/PecosPest_output"
                    }
                },


                new Episode()
                {
                    Name = "PolkaDotPuss",
                    ENumber = 0,
                    SNumber = 126,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PolkaDotPuss_vod",
                        Path = "tom-and-jerry/PolkaDotPuss_output"
                    }
                },


                new Episode()
                {
                    Name = "PentHouseMouse",
                    ENumber = 0,
                    SNumber = 127,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PentHouseMouse_vod",
                        Path = "tom-and-jerry/PentHouseMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "FineFeatheredFriend",
                    ENumber = 0,
                    SNumber = 128,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "FineFeatheredFriend_vod",
                        Path = "tom-and-jerry/FineFeatheredFriend_output"
                    }
                },


                new Episode()
                {
                    Name = "PuttinontheDog",
                    ENumber = 0,
                    SNumber = 129,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "PuttinontheDog_vod",
                        Path = "tom-and-jerry/PuttinontheDog_output"
                    }
                },


                new Episode()
                {
                    Name = "TheUnshrinkableJerryMouse",
                    ENumber = 0,
                    SNumber = 130,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheUnshrinkableJerryMouse_vod",
                        Path = "tom-and-jerry/TheUnshrinkableJerryMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "CattyCornered",
                    ENumber = 0,
                    SNumber = 131,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "CattyCornered_vod",
                        Path = "tom-and-jerry/CattyCornered_output"
                    }
                },


                new Episode()
                {
                    Name = "TheCatandtheMermouse",
                    ENumber = 0,
                    SNumber = 132,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheCatandtheMermouse_vod",
                        Path = "tom-and-jerry/TheCatandtheMermouse_output"
                    }
                },


                new Episode()
                {
                    Name = "TeeforTwo",
                    ENumber = 0,
                    SNumber = 133,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TeeforTwo_vod",
                        Path = "tom-and-jerry/TeeforTwo_output"
                    }
                },


                new Episode()
                {
                    Name = "JerryJerryQuiteContrary",
                    ENumber = 0,
                    SNumber = 134,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "JerryJerryQuiteContrary_vod",
                        Path = "tom-and-jerry/JerryJerryQuiteContrary_output"
                    }
                },


                new Episode()
                {
                    Name = "TheBrothersCarryMouseOff",
                    ENumber = 0,
                    SNumber = 135,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheBrothersCarryMouseOff_vod",
                        Path = "tom-and-jerry/TheBrothersCarryMouseOff_output"
                    }
                },


                new Episode()
                {
                    Name = "TheTwoMouseketeers",
                    ENumber = 0,
                    SNumber = 136,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheTwoMouseketeers_vod",
                        Path = "tom-and-jerry/TheTwoMouseketeers_output"
                    }
                },


                new Episode()
                {
                    Name = "TotWatchers",
                    ENumber = 0,
                    SNumber = 137,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TotWatchers_vod",
                        Path = "tom-and-jerry/TotWatchers_output"
                    }
                },


                new Episode()
                {
                    Name = "BabyPuss",
                    ENumber = 0,
                    SNumber = 138,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "BabyPuss_vod",
                        Path = "tom-and-jerry/BabyPuss_output"
                    }
                },


                new Episode()
                {
                    Name = "DownBeatBear",
                    ENumber = 0,
                    SNumber = 139,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "DownBeatBear_vod",
                        Path = "tom-and-jerry/DownBeatBear_output"
                    }
                },


                new Episode()
                {
                    Name = "TheLonesomeMouse",
                    ENumber = 0,
                    SNumber = 140,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheLonesomeMouse_vod",
                        Path = "tom-and-jerry/TheLonesomeMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "CalypsoCat",
                    ENumber = 0,
                    SNumber = 141,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "CalypsoCat_vod",
                        Path = "tom-and-jerry/CalypsoCat_output"
                    }
                },


                new Episode()
                {
                    Name = "TheYearoftheMouse",
                    ENumber = 0,
                    SNumber = 142,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheYearoftheMouse_vod",
                        Path = "tom-and-jerry/TheYearoftheMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "LittleSchoolMouse",
                    ENumber = 0,
                    SNumber = 143,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "LittleSchoolMouse_vod",
                        Path = "tom-and-jerry/LittleSchoolMouse_output"
                    }
                },


                new Episode()
                {
                    Name = "FeedintheKiddie",
                    ENumber = 0,
                    SNumber = 144,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "FeedintheKiddie_vod",
                        Path = "tom-and-jerry/FeedintheKiddie_output"
                    }
                },


                new Episode()
                {
                    Name = "MuchAdoAboutMousing",
                    ENumber = 0,
                    SNumber = 145,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "MuchAdoAboutMousing_vod",
                        Path = "tom-and-jerry/MuchAdoAboutMousing_output"
                    }
                },


                new Episode()
                {
                    Name = "MouseIntoSpace",
                    ENumber = 0,
                    SNumber = 146,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "MouseIntoSpace_vod",
                        Path = "tom-and-jerry/MouseIntoSpace_output"
                    }
                },


                new Episode()
                {
                    Name = "TennisChumps",
                    ENumber = 0,
                    SNumber = 147,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TennisChumps_vod",
                        Path = "tom-and-jerry/TennisChumps_output"
                    }
                },


                new Episode()
                {
                    Name = "TomicEnergy",
                    ENumber = 0,
                    SNumber = 148,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TomicEnergy_vod",
                        Path = "tom-and-jerry/TomicEnergy_output"
                    }
                },


                new Episode()
                {
                    Name = "SufferinCats!",
                    ENumber = 0,
                    SNumber = 149,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SufferinCats!_vod",
                        Path = "tom-and-jerry/SufferinCats!_output"
                    }
                },


                new Episode()
                {
                    Name = "GuidedMouseille",
                    ENumber = 0,
                    SNumber = 150,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "GuidedMouseille_vod",
                        Path = "tom-and-jerry/GuidedMouseille_output"
                    }
                },


                new Episode()
                {
                    Name = "BabyButch",
                    ENumber = 0,
                    SNumber = 151,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "BabyButch_vod",
                        Path = "tom-and-jerry/BabyButch_output"
                    }
                },


                new Episode()
                {
                    Name = "MouseCleaning",
                    ENumber = 0,
                    SNumber = 152,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "MouseCleaning_vod",
                        Path = "tom-and-jerry/MouseCleaning_output"
                    }
                },


                new Episode()
                {
                    Name = "HeavenlyPuss",
                    ENumber = 0,
                    SNumber = 153,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "HeavenlyPuss_vod",
                        Path = "tom-and-jerry/HeavenlyPuss_output"
                    }
                },


                new Episode()
                {
                    Name = "SleepyTimeTom",
                    ENumber = 0,
                    SNumber = 154,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SleepyTimeTom_vod",
                        Path = "tom-and-jerry/SleepyTimeTom_output"
                    }
                },


                new Episode()
                {
                    Name = "HappyGoDucky",
                    ENumber = 0,
                    SNumber = 155,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "HappyGoDucky_vod",
                        Path = "tom-and-jerry/HappyGoDucky_output"
                    }
                },


                new Episode()
                {
                    Name = "MouseTrouble",
                    ENumber = 0,
                    SNumber = 156,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "MouseTrouble_vod",
                        Path = "tom-and-jerry/MouseTrouble_output"
                    }
                },


                new Episode()
                {
                    Name = "DownandOuting",
                    ENumber = 0,
                    SNumber = 157,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "DownandOuting_vod",
                        Path = "tom-and-jerry/DownandOuting_output"
                    }
                },


                new Episode()
                {
                    Name = "BusyBuddies",
                    ENumber = 0,
                    SNumber = 158,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "BusyBuddies_vod",
                        Path = "tom-and-jerry/BusyBuddies_output"
                    }
                },


                new Episode()
                {
                    Name = "TimidTabby",
                    ENumber = 0,
                    SNumber = 159,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TimidTabby_vod",
                        Path = "tom-and-jerry/TimidTabby_output"
                    }
                },


                new Episode()
                {
                    Name = "SouthboundDuckling",
                    ENumber = 0,
                    SNumber = 160,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "SouthboundDuckling_vod",
                        Path = "tom-and-jerry/SouthboundDuckling_output"
                    }
                },


                new Episode()
                {
                    Name = "TheNightBeforeChristmas",
                    ENumber = 0,
                    SNumber = 161,
                    VideoFile = new Archive()
                    {
                        Extension = "mpd",
                        Name = "TheNightBeforeChristmas_vod",
                        Path = "tom-and-jerry/TheNightBeforeChristmas_output"
                    }
                }
            };







            var serie = new Serie()
            {
                Name = "Tom and Jerry",
                Description = "Gato e rato",
                Type = ContentType.Episode,
                Thumbnail = new Archive()
                {
                    Name = "tom",
                    Path = "jerry/",
                    Extension = ".jpg",
                    Type = ArchiveType.Image
                },
                Episodes = episodes,
                Star1 = 10,
                Star2 = 20,
                Star3 = 30,
                Star4 = 40,
                Star5 = 50
            };

            Content tomjerry = _context.Contents.FirstOrDefault(c => c.Name == "Tom and Jerry");
            if (tomjerry == null)
            {
                _context.Contents.Add(serie);
            }

            Review review = new Review()
            {
                ArchiveId = movie.Id,
                ReviewerId = 1,
                Body = "Esse filme é muito bom. Ótimas atuações",
                Likes = 100,
                Deslikes = 2,
                Title = "Rapaz mestre",
                Rating = Rating.Excellent
            };

            //_context.Reviews.Add(review);
            

            _context.SaveChanges();

        }
        [Authorize]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "MainMenu");
        }
    }
}
