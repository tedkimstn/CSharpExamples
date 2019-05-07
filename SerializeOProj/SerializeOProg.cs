using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// [Note: You can paste the Lizard class here] <--

[Serializable()]
public class Lizard
{
    public string Type { get; set; }
    public int Number { get; set; }
    public bool Healthy { get; set; }

    public Lizard(string t, int n, bool h)
    {
        Type = t;
        Number = n;
        Healthy = h;
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("s=serialize, r=read:");
            switch (Console.ReadLine())
            {
                case "s":
                    var lizards1 = new List<Lizard>();
                    lizards1.Add(new Lizard("Thorny devil", 1, true));
                    lizards1.Add(new Lizard("Casquehead lizard", 0, false));
                    lizards1.Add(new Lizard("Green iguana", 4, true));
                    lizards1.Add(new Lizard("Blotched blue-tongue lizard", 0, false));
                    lizards1.Add(new Lizard("Gila monster", 1, false));

                    try
                    {
                        using (Stream stream = File.Open("data.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, lizards1);
                        }
                    }
                    catch (IOException)
                    {
                    }
                    break;

                case "r":
                    try
                    {
                        using (Stream stream = File.Open("data.bin", FileMode.Open))
                        {
                            BinaryFormatter bin = new BinaryFormatter();

                            var lizards2 = (List<Lizard>)bin.Deserialize(stream);
                            foreach (Lizard lizard in lizards2)
                            {
                                Console.WriteLine("{0}, {1}, {2}",
                                    lizard.Type,
                                    lizard.Number,
                                    lizard.Healthy);
                            }
                        }
                    }
                    catch (IOException)
                    {
                    }
                    break;
            }
        }
    }
}