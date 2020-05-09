using System;
namespace ToxinhoCorno {

    class Program {

        static void Main(string[] args) {
            var paladino = new Hero(
                classe: "Paladino",
                nomeHeroi: "Pockieddw",
                nivel: 1,
                hp: 500,
                mana: 300,
                danoBase: 50,
                armadura: 30,
                chanceEsquiva: 10,
                chanceCritical: 15,
                critical: 50,
                resistenciaDanoMagico: 15
            );
            paladino.Inventario.AddRange(new [] {
                new Item {
                    Nome           = "Espada Claymore divina",
                    Dano           = 25,
                    ChanceCritical = 10,
                    CriticalC      = 20 
                },
                new Item {
                    Nome     = "Cota de malhas",
                    Armadura = 10
                }
            });
            paladino.CalcularItens();
            paladino.Skills.Add(new Magia {
                Nome       = "Luz Divina",
                ChanceErro = 10,
                CustoMana  = 70,
                Cura       = 140
            });
            paladino.Skills.Add(new Magia {
                Nome       = "Ataque de ursos",
                ChanceErro = 15,
                CustoMana  = 90,
                DanoMagico = 120
            });
            paladino.Skills.Add(new Magia {
                Nome       = "Braza do Tenar",
                ChanceErro = 25,
                CustoMana  = 150,
                DanoMagico = 250,
                Cura       = 90
            });
            
            var mago = new Hero(
               classe: "Mago",
               nomeHeroi: "Mago da sabedoria",
               nivel: 1,
               hp: 350,
               mana:510, 
               danoBase: 70,
               armadura: 20,
               chanceEsquiva: 7,
               chanceCritical: 15,
               critical: 50,
               resistenciaDanoMagico: 15
            );
            mago.Inventario.Add(new Item {
                Nome = "Pedra do vazio",
                Hp   = 50,
                ChanceEsquiva = 5,
                Armadura = 10
            });
            mago.Inventario.Add(new Item {
                Nome = "Cetro implacável",
                Dano = 15,
                Hp   = 100,
            });
            mago.CalcularItens();
            
            mago.Skills.Add(new Magia {
                Nome = "Dragão do Vazio",
                ChanceErro = 12,
                CustoMana = 80,
                DanoMagico = 110
            });
            mago.Skills.Add(new Magia {
                Nome       = "Cura do illuminatti",
                ChanceErro = 1,
                CustoMana  = 80,
                DanoMagico = 0,
                Cura       = 100,
            });
            mago.Skills.Add(new Magia {
                Nome       = "MUITO DAMAGE",
                ChanceErro = 25,
                CustoMana  = 250,
                DanoMagico = 300
            });
            
            var barbaro = new Hero(
                classe: "Bábaro",
                nomeHeroi: "Toxicuzinho",
                nivel: 1,
                hp: 600,
                mana: 200,
                danoBase: 70,
                armadura: 0,
                chanceEsquiva: 10,
                chanceCritical: 15,
                critical: 40,
                resistenciaDanoMagico: 15
            );
            barbaro.Inventario.AddRange(new [] {
                new Item {
                    Nome = "Cepo de madeira",
                    Dano = 12
                },
                new Item {
                    Nome = "Pedregulho",
                    Dano = 10
                },
            });
            barbaro.CalcularItens();
            barbaro.Skills.Add(new Magia {
                Nome       = "Pele de Pedra",
                ChanceErro = 35,
                CustoMana  = 80,
                DanoMagico = 0,
                Cura       = 200
            });
            barbaro.Skills.Add(new Magia {
                Nome       = "Pedra de Fogo",
                ChanceErro = 40,
                CustoMana  = 50,
                DanoMagico = 100,
                Cura       = 0,
            });
            barbaro.Skills.Add(new Magia {
                Nome       = "Rugido",
                ChanceErro = 50,
                CustoMana  = 70,
                DanoMagico = 200
            });
            
            var ladrao = new Hero(
               classe: "Ladrão",
               nomeHeroi: "Notim teressa",
               nivel: 1,
               hp: 350,
               mana: 350,
               danoBase: 80,
               armadura: 15,
               chanceEsquiva: 32,
               chanceCritical: 20,
               critical: 50,
               resistenciaDanoMagico: 10
            );
            ladrao.Inventario.AddRange(new [] {
                new Item {
                    Nome = "Espada de vidro negro",
                    Dano = 30,
                },
                new Item {
                    Nome = "Capa da sombra",
                    Armadura = 10
                },
                new Item {
                    Nome = "Peita do corinthians",
                    Hp   = 50,
                    Armadura = 10
                },
            });
            ladrao.CalcularItens();
            
            ladrao.Skills.Add(new Magia {
                Nome       = "Arrastão",
                ChanceErro = 10,
                CustoMana  = 80,
                DanoMagico = 110
            });
            ladrao.Skills.Add(new Magia {
                Nome       = "Injeção achada no lixo",
                ChanceErro = 50,
                CustoMana  = 70,
                DanoMagico = 0,
                Cura       = 150,
            });
            ladrao.Skills.Add(new Magia {
                Nome       = "Vou te roubei",
                ChanceErro = 25,
                CustoMana  = 170,
                DanoMagico = 220
            });
            
            
            var guerreiro = new Hero(
                classe: "Guerreiro",
                nomeHeroi: "Tio Zangs",
                nivel: 1,
                hp: 600,
                mana: 300,
                danoBase: 50,
                armadura: 30,
                chanceEsquiva: 10,
                chanceCritical: 10,
                critical: 30,
                resistenciaDanoMagico: 20
            );
            guerreiro.Inventario.AddRange(new [] {
                new Item {
                    Nome = "Espada Longa de Zangson (Lendária)",
                    Dano = 40
                },
                new Item {
                    Nome     = "Escuderia ferrari",
                    Armadura = 15,
                },
                new Item {
                    Nome = "Colar de Venus",
                    Hp = 100,
                    ResistenciaMagica = 20
                },
            });
            guerreiro.CalcularItens();
            
            guerreiro.Skills.Add(new Magia {
                Nome       = "Grito de ira",
                ChanceErro = 10,
                CustoMana  = 70,
                DanoMagico = 150
            });
            guerreiro.Skills.Add(new Magia {
                Nome       = "Anjo da guarda",
                ChanceErro = 50,
                CustoMana  = 100,
                DanoMagico = 0,
                Cura       = 200,
            });
            guerreiro.Skills.Add(new Magia {
                Nome       = "Fome de batalha",
                ChanceErro = 25,
                CustoMana  = 110,
                DanoMagico = 180
            });
            
            var heroes = new [] {
                mago,
                paladino,
                barbaro,
                ladrao,
                guerreiro
            };

            Battles.Battle_2x2(heroes);
        }
    }
    
}