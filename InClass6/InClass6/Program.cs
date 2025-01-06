// In-Class 6
// Name: Amalachukwu Azubike
// Instructor: Sukhbir Tatla

using System;

namespace InClass6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jagged array Initialization to hold exam scores for each section
            int[][] examScores = new int[3][];

            //Final exam score for each section
            examScores[0] = new int[] { 87, 93, 72, 98, 65, 70, 89, 78, 77, 66, 92, 72 };  //Section 1
            examScores[1] = new int[] { 71, 98, 93, 79, 84, 90, 88, 91 };  //Section 2
            examScores[2] = new int[] { 88, 81, 56, 72, 69, 74, 80, 66, 71, 73 };  //Section 3

           


            // Each section's scores
            Console.WriteLine("The Exam Scores by Sections:");
            Console.WriteLine("The Exam scores by sections:");
            for (int i = 0; i < examScores.Length; i++)
            {
                Console.Write("Section {0}: ", i + 1);
                foreach (int score in examScores[i])
                {
                    Console.Write(score + " ");
                }
                Console.WriteLine();
            }
            

            // The average score for each section
            double totalScoreSum = 0;
            int totalStudents = 0;
            double[] sectionAverages = new double[examScores.Length];

            for (int i = 0; i < examScores.Length; i++)
            {
                double sectionSum = 0;
                foreach (int score in examScores[i])
                {
                    sectionSum += score;
                }
                sectionAverages[i] = sectionSum / examScores[i].Length;
                totalScoreSum += sectionSum;
                totalStudents += examScores[i].Length;
                Console.WriteLine("Average score for the Section {0}: {1:F2}", i + 1, sectionAverages[i]);
            }

            // The overall average score for all students
            double overallAverage = totalScoreSum / totalStudents;
            Console.WriteLine("Average score for all the students: {0:F2}", overallAverage);

            // The highest and lowest scores across all sections
            int highestScore = int.MinValue;
            int lowestScore = int.MaxValue;
            int highestSection = 0;
            int lowestSection = 0;

            for (int i = 0; i < examScores.Length; i++)
            {
                foreach (int score in examScores[i])
                {
                    if (score > highestScore)
                    {
                        highestScore = score;
                        highestSection = i + 1;
                    }
                    if (score < lowestScore)
                    {
                        lowestScore = score;
                        lowestSection = i + 1;
                    }
                }
            }

            // Output the highest and lowest scores with their section numbers
      
            Console.WriteLine("Highest score: {0} (Section {1})", highestScore, highestSection);
            Console.WriteLine("Lowest score: {0} (Section {1})", lowestScore, lowestSection);
        }
    }
}

