using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {
            var frequencies = Console.ReadLine().Split(' ').ToList();

            var notes = new List<string>();
            var naturals = new List<string>();
            var sharps = new List<string>();
            var sumNaturals = new List<string>();
            var sumSharps = new List<string>();

            var sum1 = 0.0;
            var sum2 = 0.0;

            var note = "";
            var note1 = "";

            for (int i = 0; i < frequencies.Count; i++)
            {
                switch (frequencies[i])
                {
                    case "261.63":
                        note = "C"; notes.Add(note);
                        break;
                    case "277.18":
                        note = "C#"; notes.Add(note);
                        break;
                    case "293.66":
                        note = "D"; notes.Add(note);
                        break;
                    case "311.13":
                        note = "D#"; notes.Add(note);
                        break;
                    case "329.63":
                        note = "E"; notes.Add(note);
                        break;
                    case "349.23":
                        note = "F"; notes.Add(note);
                        break;
                    case "369.99":
                        note = "F#"; notes.Add(note);
                        break;
                    case "392.0":
                        note = "G"; notes.Add(note);
                        break;
                    case "415.30":
                        note = "G#"; notes.Add(note);
                        break;
                    case "440.0":
                        note = "A"; notes.Add(note);
                        break;
                    case "466.16":
                        note = "A#"; notes.Add(note);
                        break;
                    case "493.88":
                        note = "B"; notes.Add(note);
                        break;
                }
            }
            Console.WriteLine("Notes: {0}", string.Join(" ", notes));

            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].Contains("#"))
                {
                    sharps.Add(notes[i]);
                }
                else
                {
                    naturals.Add(notes[i]);
                }
            }

            Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));

            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));

            for (int i = 0; i < naturals.Count; i++)
            {
                switch (naturals[i])
                {
                    case "C":
                        note1 = "261.63"; sumNaturals.Add(note1);
                        break;
                    case "D":
                        note1 = "293.66"; sumNaturals.Add(note1);
                        break;
                    case "E":
                        note1 = "329.63"; sumNaturals.Add(note1);
                        break;
                    case "F":
                        note1 = "349.23"; sumNaturals.Add(note1);
                        break;
                    case "G":
                        note1 = "392.0"; sumNaturals.Add(note1);
                        break;
                    case "A":
                        note1 = "440.0"; sumNaturals.Add(note1);
                        break;
                    case "B":
                        note1 = "493.88"; sumNaturals.Add(note1);
                        break;
                    default:
                        note1 = "0.0"; sumNaturals.Add(note1);
                        break;
                } 
            }
            for (int i = 0; i < sumNaturals.Count; i++)
            {
                sum1 += Convert.ToDouble(sumNaturals[i]);
            }
            if (sum1 == 0)
            {
                Console.WriteLine($"Naturals sum: 0");
            }
            else
            {
                Console.WriteLine($"Naturals sum: {sum1:f2}");
            }
            
            for (int i = 0; i < sharps.Count; i++)
            {
                switch (sharps[i])
                {
                    case "C#":
                        note = "277.18"; sumSharps.Add(note);
                        break;
                    case "D#":
                        note = "311.13"; sumSharps.Add(note);
                        break;
                    case "F#":
                        note = "369.99"; sumSharps.Add(note);
                        break;
                    case "G#":
                        note = "415.30"; sumSharps.Add(note);
                        break;
                    case "A#":
                        note = "466.16"; sumSharps.Add(note);
                        break;
                    default:
                        note = "0.0"; sumSharps.Add(note);
                        break;
                }
            }
            for (int i = 0; i < sumSharps.Count; i++)
            {
                sum2 += Convert.ToDouble(sumSharps[i]);
            }
            if (sum2 == 0)
            {
                Console.WriteLine($"Sharps sum: 0");
            }
            else
            {
                Console.WriteLine($"Sharps sum: {sum2:f2}");
            }
        }
    }
}
