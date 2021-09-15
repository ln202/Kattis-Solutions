using System;


using System.Collections;


using System.Text;


using System.Linq;


namespace ISM4300_Election


{


    class Program


    {


        static void Main(string[] args)


        {


            int candidateTotal = Int32.Parse(Console.ReadLine());


            if (candidateTotal >= 2 && candidateTotal <= 20)


            {


                Hashtable candidatePartyHashTable = new Hashtable();


                for (int i = 0; i < candidateTotal; i++)


                {


                    string name = Console.ReadLine().Trim();


                    string party = Console.ReadLine().Trim();


                    if (name.Length >= 1 && name.Length <= 80)


                    {


                        byte[] nameAscii = Encoding.ASCII.GetBytes(name);


                        byte[] partyAscii = Encoding.ASCII.GetBytes(party);


                        if (nameAscii.Max() <= 126 && nameAscii.Min() >= 32 && partyAscii.Max() <= 126 && partyAscii.Min() >= 32)


                        {


                            if (party == "independent" && !candidatePartyHashTable.ContainsKey(name))


                            {


                                candidatePartyHashTable.Add(name, party);


                            }





                            else if (!candidatePartyHashTable.ContainsKey(name) && !candidatePartyHashTable.ContainsValue(party))


                            {


                                candidatePartyHashTable.Add(name, party);


                            }


                        }


                    }


                }





                Hashtable ballotHashTable = new Hashtable();


                foreach (string key in candidatePartyHashTable.Keys)


                {


                    ballotHashTable.Add(key, 0);


                }


                int ballots = Int32.Parse(Console.ReadLine());


                if (ballots > 0 && ballots <= 10000)


                {


                    for (int i = 0; i < ballots; i++)


                    {


                        string candidate = Console.ReadLine().Trim();


                        if (ballotHashTable.ContainsKey(candidate))


                        {


                            ballotHashTable[candidate] = (int)ballotHashTable[candidate] + 1;


                        }





                        else


                            continue;


                    }





                    string winner = "";


                    int max = 0;


                    foreach (string key in ballotHashTable.Keys)


                    {


                        if ((int)ballotHashTable[key] > max)


                        {


                            winner = key;


                            max = (int)ballotHashTable[key];


                        }





                        else if ((int)ballotHashTable[key] == max)


                        {


                            winner = "tie";


                        }


                    }





                    if (winner != "tie")


                        Console.WriteLine(candidatePartyHashTable[winner]);


                    else


                        Console.WriteLine(winner);


                }


            }


        }


    }


}