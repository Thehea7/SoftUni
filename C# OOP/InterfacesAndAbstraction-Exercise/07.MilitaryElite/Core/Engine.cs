
using _07.MilitaryElite.Core.Interfaces;
using _07.MilitaryElite.Models;
using _07.MilitaryElite.Models.Interfaces;

namespace _07.MilitaryElite.Core
{
    internal class Engine : IEngine
    {
        public void Run()
        {
            List<ISoldier> soldiers = new List<ISoldier>();
            string commands;

            while ((commands = Console.ReadLine()) != "End")
            {
                string[] arguments = commands.Split();
                string soldier = arguments[0];
                string id = arguments[1];
                string firstname = arguments[2];
                string lastname = arguments[3];
                
                switch (soldier)
                {
                    case "Private":
                        AddPrivate();
                        break;
                    case "LieutenantGeneral":
                        AddLieutenantGeneral();
                        break;
                    case "Engineer":
                        AddEngineer();
                        break;
                    case "Commando":
                        AddCommando();
                        break;
                    case "Spy":
                        AddSpy();
                        break;
                }

                void AddLieutenantGeneral()
                {
                    List<ISoldier> privates = new List<ISoldier>(); 
                    decimal salary = decimal.Parse(arguments[4]);
                    List<string> privateIDs = arguments.Skip(4).ToList();
                    foreach (string privateID in privateIDs)
                    {
                        foreach (var soldier in soldiers)
                        {
                            if (soldier.Id == privateID)
                            {
                                privates.Add(soldier);
                            }
                        }
                    }
                    soldiers.Add(new LieutenantGeneral(id, firstname, lastname, salary, privates));
                }
                void AddPrivate()
                {
                    decimal salary = decimal.Parse(arguments[4]);
                    soldiers.Add(new Private(id, firstname, lastname, salary));
                }
                void AddEngineer()
                {
                    decimal salary = decimal.Parse(arguments[4]);
                    string corps = arguments[5];
                    if (CorpsIsNotValid(corps)) {return;}
                    List<Repair> repairs = new List<Repair>();

                    string[] repairsInfo = arguments.Skip(6).ToArray();
                    for (int i = 0; i < repairsInfo.Length; i+=2)
                    {
                        repairs.Add(new Repair(repairsInfo[i], int.Parse(repairsInfo[i+1])));
                    }
                    soldiers.Add(new Engineer(id, firstname, lastname, salary, corps, repairs));
                }
                void AddCommando()
                {
                    decimal salary = decimal.Parse(arguments[4]);
                    string corps = arguments[5];
                    if (CorpsIsNotValid(corps)) { return; }
                    List<Mission> missions = new List<Mission>();

                    string[] missionsInfo = arguments.Skip(6).ToArray();
                    for (int i = 0; i < missionsInfo.Length; i += 2)
                    {
                        string missionStatus = missionsInfo[i+1];
                        if(MissionStatusIsNotValid(missionStatus)){continue;}
                        missions.Add(new Mission(missionsInfo[i], missionStatus));
                    }
                    soldiers.Add(new Commando(id, firstname, lastname, salary, corps, missions));
                }
                void AddSpy()
                {
                    int codeNumber = int.Parse(arguments[4]);
                    soldiers.Add(new Spy(id, firstname, lastname, codeNumber));
                }
            }

            soldiers.ForEach(x => Console.WriteLine(x));
        } 
        bool MissionStatusIsNotValid(string missionStatus)
        {
            if (missionStatus is not "inProgress" and not "Finished")
            {
                return true;
            }
            return false;
        }
        bool CorpsIsNotValid(string corps)
        {
            if (corps is not "Airforces" and not "Marines")
            {
                return true;
            }
            return false;
        }
    }
}
