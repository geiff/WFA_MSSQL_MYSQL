using System;
using System.Collections.Generic;

namespace ProblemColumnGasStation
{
    public class ColumnGasStationMain
    {
        static void Main()
        {
            StateMachine machine = new StateMachine();

            Console.WriteLine("В момента колонката за бензин е ГОТОВА за работа!");
            Console.WriteLine("Моля въведете число 1 до 4 в зависимост от това какво желаете да направите с колонката за бензин, като:");
            Console.WriteLine(" - За да СЧУПИТЕ колонкота за бензин натиснете 1\n - За да си ЗАРЕДИТЕ колата с бензин от колонката натиснете 2\n" +
                              " - ЗА ПЛАЩАНЕ натиснете 3\n - Ако желаете колонката да премине в режим ГОТОВА за работа натиснете 4\n\nЗа изход натиснете 0!\n");
            try
            {
                int command = int.Parse(Console.ReadLine());

                while (command != 0)
                {
                    machine.Machine.CommandTransition = (Transition) command;
                    machine.Machine = machine.TransitionToNewState(machine.Machine.CurrentState, machine.Machine.CommandTransition); 
                    Console.WriteLine("Текущото състояние на колонката за бензин е {0}!", machine.Machine.CurrentState);

                    command = int.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Грешка! Въведената стойност е невалидна!");
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Не може да преминете в това състояние!");
            }
        }
    }
}