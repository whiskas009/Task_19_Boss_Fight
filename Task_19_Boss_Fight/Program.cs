using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19_Boss_Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userHealth = 100;
            int userEnergy = 100;

            int maxHealth = 100;
            int maxEnergy = 100;

            int healthRecovery = 10;
            int energyRecovery = 10;
                 
            int userUsualyAttak = 10;
            int userStrongAttak = 30;

            int increasedDamage = 10;
            int decreaseHealthRecovery = 20;
            int statusLexir = 0;

            int energyUsualtAttak = 30;
            int energyStrongtAttak = 80;
            
            int enemyHealth = 100;
            int enemyAttak = 50;

            while (userHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine($"Ваше здоровье: {userHealth} \nВаша энергия: {userEnergy}\n");
                Console.WriteLine($"Здоровье противника: {enemyHealth} \n");

                Console.WriteLine($"Выберите действие: \n1. Выполнить обычную аттаку ({userUsualyAttak} урона и {energyUsualtAttak} энергии)");
                Console.WriteLine($"2. Выполнить сильную аттаку ({userStrongAttak} урона и {energyStrongtAttak} энергии)");
                Console.WriteLine($"3. Спрятаться за укрытие и восстановить {energyRecovery} энергии");
                Console.WriteLine($"4. Выпить лексир повышающий урон (навсегда повышает урон на 10, но уменьшает и здоровья на 20)\n");
                int userСhoice = int.Parse(Console.ReadLine());

                switch (userСhoice)
                {
                    case 1:
                        if (userEnergy >= energyUsualtAttak)
                        {
                            enemyHealth -= userUsualyAttak;
                            userEnergy -= energyUsualtAttak;
                            userHealth -= enemyAttak;
                            Console.WriteLine($"Враг наносит Вам {enemyAttak} урона");
                        }
                        else
                            Console.WriteLine("У Вас недостаточно энергии для данного действия: \n");
                        break;

                    case 2:
                        if (userEnergy >= energyStrongtAttak)
                        {
                            enemyHealth -= userStrongAttak;
                            userEnergy -= energyStrongtAttak;
                            userHealth -= enemyAttak;
                            Console.WriteLine($"Враг наносит Вам {enemyAttak} урона");
                        }
                        else
                            Console.WriteLine("У Вас недостаточно энергии для данного действия: \n");
                        break;

                    case 3:
                        if (userHealth != maxHealth)
                        { 
                            userHealth += healthRecovery;
                            userEnergy += energyRecovery;
                        }
                        else if (userEnergy != maxEnergy)
                            userEnergy += energyRecovery;
                        else
                            Console.WriteLine("У Вас уже полная энергия и здоровье");
                        break;

                    case 4:
                        if (statusLexir == 0)
                        {
                            maxHealth -= decreaseHealthRecovery;
                            userHealth -= decreaseHealthRecovery;
                            userUsualyAttak += increasedDamage;
                            userStrongAttak += increasedDamage;
                            statusLexir = 1;
                            Console.WriteLine("Лексир применён!");
                        }
                        else 
                            Console.WriteLine("Лексир уже применён!");
                        break;
                    
                    default: Console.WriteLine("Такого варианта нет!\n");
                        break;
                }
                
            }

            if (userHealth <= 0)
                Console.WriteLine("Вы погибли");
            else
                Console.WriteLine("Противник повержен!");
        }
    }
}
