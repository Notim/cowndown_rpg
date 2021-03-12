using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ToxinhoCorno {

    public static class Battles {
        /*
        public static void Battle_2x2(Hero[] herois) {
            
            Console.WriteLine("Rpg da cowdown 2 x 2:");

            var (time1, time2) = MontarTimes(herois);
            
            var turno = 1;

            Console.WriteLine($"{time1[0].NomeHeroi}, {time1[1].NomeHeroi} X {time2[0].NomeHeroi}, {time2[1].NomeHeroi}");
            
            while (time1.Any(x => x.TaVivo) && time2.Any(x => x.TaVivo)) {
                Console.WriteLine("\nBriga de cornos turno: " + turno);

                var alvoTeam1_1 = new Random().Next(0, time1.Count());
                var alvoTeam2_1 = new Random().Next(0, time2.Count());
                var alvoTeam1_2 = new Random().Next(0, time1.Count());
                var alvoTeam2_2 = new Random().Next(0, time2.Count());
                
                Turno(time1[0], time2[alvoTeam1_1].TaVivo ? time2[alvoTeam1_1] : time2[alvoTeam1_2]);
                Turno(time2[0], time1[alvoTeam2_1].TaVivo ? time1[alvoTeam2_1] : time1[alvoTeam2_2]);
                Turno(time1[1], time2[alvoTeam1_2].TaVivo ? time2[alvoTeam1_2] : time2[alvoTeam1_1]);
                Turno(time2[1], time1[alvoTeam2_2].TaVivo ? time1[alvoTeam2_2] : time1[alvoTeam2_1]);
                
                Console.WriteLine("------------------------------------");
                time1[0].FinalRodada();
                time1[1].FinalRodada();
                time2[0].FinalRodada();
                time2[1].FinalRodada();
                
                turno++;
                
                Console.ReadKey();
            }
        }
        
        public static void Turno(Hero atacante, Hero atacado) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Vez de {atacante.NomeHeroi} escolheu {atacado.NomeHeroi}");
            Console.ForegroundColor = ConsoleColor.White;
             
            atacado.ReceberDano(atacante.Atacar());
        }
        
        public static (List<Hero>, List<Hero>) MontarTimes(Hero[] herois) {
            var heroIndex1 = herois[new Random().Next(0, herois.Length)];
            var heroIndex2 = herois[new Random().Next(0, herois.Length)];
            var heroIndex3 = herois[new Random().Next(0, herois.Length)];
            var heroIndex4 = herois[new Random().Next(0, herois.Length)];
            
            var time1 = new List<Hero> {
                heroIndex1,
                heroIndex2
            };
            var time2 = new List<Hero> {
                heroIndex3,
                heroIndex4
            };

            var teste = time2.ToList();
            teste.AddRange(time1);
            
            if (teste.Select(x => x.NomeHeroi).Distinct().Count() < 4) {
                return MontarTimes(herois);
            }

            return (time1, time2);
        }
        */
    }

}