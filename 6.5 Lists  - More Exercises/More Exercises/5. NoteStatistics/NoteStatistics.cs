using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NoteStatistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {
            var notes = new List<string>();
            var naturals = new List<string>();
            var sharps = new List<string>();

            var sequances = Console.ReadLine()
                .Split(' ').Select(double.Parse).ToList();

            var note = "C C# D D# E F F# G G# A A# B"
                .Split(' ').ToList();

            var seq = "261.63 277.18 293.66 311.13 329.63 349.23 369.99 392.00 415.30 440.00 466.16 493.88"
                .Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < sequances.Count; i++)
            {
                    if (seq.Contains(sequances[i]))
                    {
                    var index = seq.IndexOf(sequances[i]);

                        notes.Add(note[index]);
                    }
            }

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

            Console.WriteLine("Notes: " + string.Join(" ", notes));
            Console.WriteLine("Naturals: " + string.Join(", ", naturals));
            Console.WriteLine("Sharps: " + string.Join(", ", sharps));

            var sumNaturals = 0.0;
            var sumSharps = 0.0;

            for (int i = 0; i < naturals.Count; i++)
            {
                if (note.Contains(naturals[i]))
                {
                    var index = note.IndexOf(naturals[i]);
                    sumNaturals += seq[index];
                }
            }

            for (int i = 0; i < sharps.Count; i++)
            {
                if (note.Contains(sharps[i]))
                {
                    var index = note.IndexOf(sharps[i]);
                    sumSharps += seq[index];
                }
            }
            Console.WriteLine((int)sumNaturals == sumNaturals ? $"Naturals sum: {(int)sumNaturals}" : $"Naturals sum: {sumNaturals:F2}");
            Console.WriteLine((int)sumSharps == sumSharps ? $"Sharps sum: {(int)sumSharps}" : $"Sharps sum: {sumSharps:F2}");
        }
    }
}
