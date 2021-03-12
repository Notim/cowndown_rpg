using System;
using System.Collections.Generic;
using System.Linq;

namespace ToxinhoCorno {

    public class Hero2 {
        /*
        public string Classe { get; set; }

        public string NomeHeroi { get; set; }

        public int Nivel { get; set; }

        private double Hp { get; set; }

        private double HpInicial { get; set; }

        private double Mana { get; set; }

        private double DanoBase { get; set; }

        private double Armadura { get; set; }

        private double ResistenciaDanoMagico { get; set; }

        private int ChanceEsquiva { get; set; }

        private int ChanceCritical { get; set; }

        private int CriticalC { get; set; }

        public List<Item> Inventario { get; set; }

        public List<Magic> Skills { get; set; }

        public bool TaVivo { get; set; } = true;

        public Hero(string classe,
                    string nomeHeroi, 
                    int nivel, 
                    double hp,
                    double mana,
                    double danoBase,
                    double armadura, 
                    int chanceEsquiva,
                    int chanceCritical, 
                    int critical,
                    int resistenciaDanoMagico) {
            
            this.Classe                = classe;
            this.NomeHeroi             = nomeHeroi;
            this.Hp                    = hp + (nivel * 50);
            this.Mana                  = mana + (nivel * 15);
            this.HpInicial             = this.Hp;
            this.Nivel                 = nivel;
            this.DanoBase              = danoBase + (this.Nivel * 5);
            this.Armadura              = armadura;
            this.ChanceEsquiva         = chanceEsquiva;
            this.ChanceCritical        = chanceCritical;
            this.CriticalC             = critical;
            this.ResistenciaDanoMagico = resistenciaDanoMagico;
            
            this.Inventario = new List<Item>();
            this.Skills = new List<Magic>();
        }

        public bool Critical() {
            return new Random().Next(1, (100 / this.ChanceCritical)) == 1;
        }

        public bool Esquivar() {
            return new Random().Next(1, (100 / this.ChanceEsquiva)) == 1;
        }

        public (double, int) Atacar() {
            if (this.TaVivo == false) {
                Console.WriteLine(" - " + this.NomeHeroi + " Tá morto e perdeu a vez.");
                
                return (0, 0);
            }
            
            if (new Random().Next(1, 10) % 2 == 0) {
                
                return AtaqueFisico();
            } 
            
            return AtaqueMagico();
        }
        
        public (double, int) AtaqueFisico() {
            
            Console.WriteLine(" - " + this.NomeHeroi + " bateu no inimico com " + this.Inventario.ToArray()[new Random().Next(this.Inventario.Count)].Nome);
            
            if (this.Critical()) {
                var danoCritical = this.DanoBase + (this.DanoBase * (this.CriticalC / (double) 100));
                
                Console.WriteLine(" - muito puto deu um golpe forte e acertou criticamente o inimigo");
                Console.WriteLine($"{this.NomeHeroi} deu um ataque critico de {this.DanoBase} para {danoCritical}");

                return (danoCritical, 1);
            }

            return (this.DanoBase, 1);
        }
        
        public (double, int)  AtaqueMagico() {
            
            var skills = this.Skills.Where(x => this.Mana > x.CustoMana).ToArray();
            
            if (!skills.Any())
                return AtaqueFisico();
            
            var index = 0;
            var rnd = new Random();
            
            if (skills.Length > 0) {
                
                index = rnd.Next(0, skills.Length - 1);
            }
            
            var sks = skills[index];
            
            Console.WriteLine(" - " + this.NomeHeroi + " lançou a magia " + sks.Nome);

            var danoMagico = sks.DanoMagico;
            
            if (new Random().Next(0, (int) (100 / sks.ChanceErro)) == 1) {
                
                Console.WriteLine(" - " + this.NomeHeroi + " se estabanou e erro a magia :/");
                
                danoMagico = 0;
            }
            
            if (sks.Cura > 0) {
                Console.WriteLine(" - " + this.NomeHeroi + " Recuperou " + sks.Cura + " de hp");

                this.Hp += sks.Cura;
            }

            this.Mana -= sks.CustoMana;

            return (danoMagico, 2);
        }
        
        public void ReceberDano((double danoRecebido, int tipoDano) tuple) {
            if (tuple.tipoDano == 1) {
                
                var danoRecebidoFinal = tuple.danoRecebido - (tuple.danoRecebido * (this.Armadura * 0.4) / 100);

                if (Esquivar()) {
                    Console.WriteLine(" - o inimigo tropeçou e errou o golpe.");
                    Console.WriteLine(this.NomeHeroi + " esquivou");

                    danoRecebidoFinal = 0;
                }

                Console.WriteLine(this.NomeHeroi + " tomou " + danoRecebidoFinal + " de dano");

                this.Hp -= danoRecebidoFinal;

                if (Hp <= 0) {
                    this.TaVivo = false;
                }
            }
            
            if (tuple.tipoDano == 2) {
                var danoRecebidoFinal = tuple.danoRecebido - (tuple.danoRecebido * (this.ResistenciaDanoMagico * 0.35) / 100);
                
                Console.WriteLine(this.NomeHeroi + " tomou " + danoRecebidoFinal + " de dano");
                
                this.Hp -= danoRecebidoFinal;

                if (Hp <= 0) {
                    this.TaVivo = false;
                }
            }
        }

        public void FinalRodada() {
            if (this.TaVivo == false) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(this.NomeHeroi + " está Morto :(");
                Console.ForegroundColor = ConsoleColor.White;
                
                return;
            }

            Console.Write($"{this.NomeHeroi} está com: ");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($" {this.Hp}/{this.HpInicial}Hp ");
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($" {this.Mana}Mp");
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("");
        }

        public void CalcularItens() {
            
            Console.Write(this.NomeHeroi + " possui os itens: ");

            foreach (var item in this.Inventario) {
                
                Console.Write(item.Nome + ", "); 
                
                this.Hp += item.Hp;
                this.Mana += item.Mana;
                this.DanoBase += item.Dano;
                this.Armadura += item.Armadura ;
                this.ChanceEsquiva += item.ChanceEsquiva;
                this.ChanceCritical += item.ChanceCritical;
                this.CriticalC += item.CriticalC;
                this.ResistenciaDanoMagico += item.ResistenciaMagica;
            }
            
            Console.WriteLine("");
        }
        */
    }

}