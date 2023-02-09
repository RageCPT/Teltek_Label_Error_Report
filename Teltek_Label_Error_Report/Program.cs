using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

class GFG
{
    // Main Method
    static void Main()
    {

        // Creating a text file named "out" in D Drive
        using (StreamWriter writer = new StreamWriter("C:\\Users\\rwb88\\Desktop\\Teltek report\\result_NewLog.txt"))
        {
            Console.SetOut(writer);
            Result();
        }
    }

    // Method Result
    static void Result()
    {

        // Writing to the file
        // Declare Variables
        string filePath = @"C:\Users\rwb88\Desktop\Teltek report\NewLog.txt";
        string letterF = "[F";
        string letterE = "[E";
        string letterC = "[C";

        //TimeSpan zeroTime = TimeSpan.Zero;


        //string pattern = @"\d{4}";
        string timeDatePattern = "[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1]) (2[0-3]|[01][0-9]):[0-5][0-9]:[0-5][0-9].[0-9][0-9][0-9]";
        string weightPattern = "\\d+\\s*g";
        string weightInNumbers = @"\d+";
        string renderedTextPattern = @"\brendered\b";
        string finishedTextPattern = @"\bfinished\b";



        if (File.Exists(filePath))

        {
            // Read a text file line by line.  
            string[] lines = File.ReadAllLines(filePath);

            //declare variables and counters
            int count = 0;
            string errorCodeC80Delay = new string(": Time delay between Flipp & C80");
            string errorCodeC80Delay2 = new string(": C80 triggered first incorrect label or no label");
            int delayCounter = 0;
            int delayCounter2 = 0;
            string errorCodeNoLabel = new string(": No label printed/skipped label");
            int noLabelCounter = 0;
            int scaleCount = 0;
            int c80Count = 0;
            int labelCount = 0;
            string errorEvoStatusProcess = new string("Evo Status Process Error");
            int errorEvoStatusProcessCount1 = 0;
            int errorEvoStatusProcessCount2 = 0;
            TimeSpan timeSpanSub050 = new TimeSpan(0, 0, 0, 0, 050);
            int count50ms = 0;
            TimeSpan timeSpanSub100 = new TimeSpan(0, 0, 0, 0, 100);
            int count100ms = 0;
            TimeSpan timeSpanSub200 = new TimeSpan(0, 0, 0, 0, 200);
            int count200ms = 0;
            TimeSpan timeSpanSub300 = new TimeSpan(0, 0, 0, 0, 300);
            int count300ms = 0;
            TimeSpan timeSpanSub400 = new TimeSpan(0, 0, 0, 0, 400);
            int count400ms = 0;
            TimeSpan timeSpanSub500 = new TimeSpan(0, 0, 0, 0, 500);
            int count500ms = 0;
            TimeSpan timeSpanSub1sec = new TimeSpan(0, 0, 0, 1, 000);
            int count1s = 0;
            int normalRange = 0;

            int labelDelayCounter = 0;
            TimeSpan labelTimeSpan900ms = new TimeSpan(0, 0, 0, 0, 900);
            int labelCountSub900ms = 0;
            int labelCount900ms = 0;
            TimeSpan labelTimeSpan1s = new TimeSpan(0, 0, 0, 1, 000);
            int labelCount1s = 0;
            TimeSpan labelTimeSpan1_1s = new TimeSpan(0, 0, 0, 1, 100);
            int labelCount1_1s = 0;
            TimeSpan labelTimeSpan1_2s = new TimeSpan(0, 0, 0, 1, 200);
            int labelCount1_2s = 0;
            TimeSpan labelTimeSpan1_3s = new TimeSpan(0, 0, 0, 1, 300);
            int labelCount1_3s = 0;
            TimeSpan labelTimeSpan1_4s = new TimeSpan(0, 0, 0, 1, 400);
            int labelCount1_4s = 0;
            TimeSpan labelTimeSpan1_5s = new TimeSpan(0, 0, 0, 1, 500);
            int labelCount1_5s = 0;
            TimeSpan labelTimeSpan1_6s = new TimeSpan(0, 0, 0, 1, 600);
            int labelCount1_6s = 0;
            TimeSpan labelTimeSpan1_7s = new TimeSpan(0, 0, 0, 1, 700);
            int labelCount1_7s = 0;
            TimeSpan labelTimeSpan1_8s = new TimeSpan(0, 0, 0, 1, 800);
            int labelCount1_8s = 0;
            TimeSpan labelTimeSpan1_9s = new TimeSpan(0, 0, 0, 1, 900);
            int labelCount1_9s = 0;
            TimeSpan labelTimeSpan2s = new TimeSpan(0, 0, 0, 2, 000);
            int labelCount2s = 0;

          


            {

                foreach (string line in lines)

                {
                    count++;
                    try
                    {
                        if (((lines[count].StartsWith(letterE)) && lines[count + 1].StartsWith(letterF)) || ((lines[count].StartsWith(letterE)) && lines[count + 1].StartsWith(letterC)))
                        {
                            string evoLabelError1 = new string(lines[count]);
                            Match renderedWord = Regex.Match(evoLabelError1, renderedTextPattern);
                            if (renderedWord.Success)
                            {
                                errorEvoStatusProcessCount1++;
                                Console.WriteLine();
                                Console.WriteLine(errorEvoStatusProcessCount1);
                                Console.WriteLine(errorEvoStatusProcess);
                                Console.WriteLine(evoLabelError1);
                            }

                        }

                        if ((lines[count].StartsWith(letterE)) && lines[count + 1].StartsWith(letterE))
                        {
                            string evoLabelError2 = new string(lines[count]);
                            string evoLabelError3 = new string(lines[count + 1]);
                            Match renderedWord1 = Regex.Match(evoLabelError2, renderedTextPattern);
                            Match renderedWord2 = Regex.Match(evoLabelError3, renderedTextPattern);
                            Match finishedWord1 = Regex.Match(evoLabelError2, finishedTextPattern);
                            Match finishedWord2 = Regex.Match(evoLabelError3, finishedTextPattern);
                            if ((renderedWord1 == renderedWord2) || (finishedWord1 == finishedWord2))
                            {
                                errorEvoStatusProcessCount2++;
                                Console.WriteLine();
                                Console.WriteLine(errorEvoStatusProcessCount1);
                                Console.WriteLine(errorEvoStatusProcess);
                                Console.WriteLine(evoLabelError2);
                                Console.WriteLine(evoLabelError3);
                            }
                        }

                        if ((lines[count].StartsWith(letterE)) && lines[count + 1].StartsWith(letterE))
                        {
                            string evoLabelRendered = new string(lines[count]);
                            string evoLabelFinished = new string(lines[count + 1]);
                            Match renderedWord = Regex.Match(evoLabelRendered, renderedTextPattern);
                            Match finishedWord = Regex.Match(evoLabelFinished, finishedTextPattern);

                            if (renderedWord.Success && finishedWord.Success)
                            {
                                Match m = Regex.Match(evoLabelRendered, timeDatePattern);
                                Match m2 = Regex.Match(evoLabelFinished, timeDatePattern);

                                DateTime DateR = DateTime.Parse(m.Value);
                                DateTime DateF = DateTime.Parse(m2.Value);
                                TimeSpan timeCompare = (DateF - DateR);

                                if (timeCompare != TimeSpan.Zero)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Evo Status Process Time");
                                    Console.WriteLine(evoLabelRendered + "\n" + evoLabelFinished);
                                    labelDelayCounter++;
                                    Console.WriteLine(timeCompare + errorCodeC80Delay);


                                    if (timeCompare >= labelTimeSpan2s)
                                    {
                                        Console.WriteLine("equal or more than 2 second");
                                        labelCount2s++;
                                    }
                                    else if (timeCompare >= labelTimeSpan1_9s)
                                    {
                                        Console.WriteLine("between 1.9 & 1.999");
                                        labelCount1_9s++;
                                    }
                                    else if (timeCompare >= labelTimeSpan1_8s)
                                    {
                                        Console.WriteLine("between 1.8 & 1.899");
                                        labelCount1_8s++;
                                    }
                                    else if (timeCompare >= labelTimeSpan1_7s)
                                    {
                                        Console.WriteLine("between 1.7 & 1.799");
                                        labelCount1_7s++;
                                    }
                                    else if (timeCompare >= labelTimeSpan1_6s)
                                    {
                                        Console.WriteLine("between 1.6 & 1.699");
                                        labelCount1_6s++;
                                    }
                                    else if (timeCompare >= labelTimeSpan1_5s)
                                    {
                                        Console.WriteLine("between 1.5 & 1.599");
                                        labelCount1_5s++;
                                    }
                                    else if (timeCompare >= labelTimeSpan1_4s)
                                    {
                                        Console.WriteLine("between 1.4 & 1.499");
                                        labelCount1_4s++;
                                    }
                                    else if (timeCompare >= labelTimeSpan1_3s)
                                    {
                                        Console.WriteLine("between 1.3 & 1.399");
                                        labelCount1_3s++;
                                    }
                                    else if (timeCompare >= labelTimeSpan1_2s)
                                    {
                                        Console.WriteLine("between 1.2 & 1.299");
                                        labelCount1_2s++;
                                    }
                                    else if (timeCompare >= labelTimeSpan1_1s)
                                    {
                                        Console.WriteLine("between 1.1 & 1.199");
                                        labelCount1_1s++;
                                    }
                                    else if (timeCompare >= labelTimeSpan1s)
                                    {
                                        Console.WriteLine("between 1 & 1.099");
                                        labelCount1s++;
                                    }
                                    else if (timeCompare >= labelTimeSpan900ms)
                                    {
                                        Console.WriteLine("between 0.900 & 0.999");
                                        labelCount900ms++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("less than 900ms");
                                        labelCountSub900ms++;
                                    }
                                }

                            }

                        }



                        if ((lines[count].StartsWith(letterF)) && lines[count + 1].StartsWith(letterF))
                        {
                            //No label error print out
                            noLabelCounter++;
                            Console.WriteLine();
                            Console.WriteLine("first");
                            Console.WriteLine(noLabelCounter + errorCodeNoLabel);
                            try
                            {
                                Console.WriteLine(lines[count - 2]);
                            }
                            catch (IndexOutOfRangeException)
                            {

                            }
                            try
                            {
                                Console.WriteLine(lines[count - 1]);
                            }
                            catch (IndexOutOfRangeException)
                            {

                            }
                            Console.WriteLine(lines[count]);
                            try
                            {
                                Console.WriteLine(lines[count + 1]);
                            }
                            catch (IndexOutOfRangeException)
                            {

                            }
                            try
                            {
                                Console.WriteLine(lines[count + 2]);
                            }
                            catch (IndexOutOfRangeException)
                            {

                            }
                            try
                            {
                                Console.WriteLine(lines[count + 3]);
                            }
                            catch (IndexOutOfRangeException)
                            {

                            }
                            Console.WriteLine();

                        }
                        else if ((lines[count].StartsWith(letterF)) && lines[count + 1].StartsWith(letterC))
                        {
                            string fullTimeValueF = new string(lines[count]);
                            string fullTimeValueC = new string(lines[count + 1]);

                            //set regex to find time
                            Match m = Regex.Match(fullTimeValueF, timeDatePattern);
                            Match m2 = Regex.Match(fullTimeValueC, timeDatePattern);
                            Match m3 = Regex.Match(fullTimeValueF, weightPattern);
                            Match m4 = Regex.Match(fullTimeValueC, weightPattern);
                            string weightString1 = (m3.Value);
                            string weightString2 = (m4.Value);
                            Match m5 = Regex.Match((string)weightString1, weightInNumbers);
                            Match m6 = Regex.Match(((string)weightString2), weightInNumbers);
                            int weight1 = int.Parse(m5.Value);
                            int weight2 = int.Parse(m6.Value);

                            DateTime DateF = DateTime.Parse(m.Value);
                            DateTime DateC = DateTime.Parse(m2.Value);
                            TimeSpan timeCompare = (DateC - DateF);
                            if ((timeCompare != TimeSpan.Zero) && (weight1 == weight2))
                            {
                                Console.WriteLine();
                                Console.WriteLine("Second");
                                Console.WriteLine(fullTimeValueF + "\n" + fullTimeValueC);
                                delayCounter++;
                                Console.WriteLine(timeCompare + errorCodeC80Delay);


                                if (timeCompare > timeSpanSub1sec)
                                {
                                    Console.WriteLine("more than 1 second");
                                    count1s++;
                                }
                                else if (timeCompare > timeSpanSub500)
                                {
                                    Console.WriteLine("more than 500 milliseconds");
                                    count500ms++;
                                }
                                else if (timeCompare > timeSpanSub400)
                                {
                                    Console.WriteLine("more than 400 milliseconds");
                                    count400ms++;
                                }
                                else if (timeCompare > timeSpanSub300)
                                {
                                    Console.WriteLine("more than 300 milliseconds");
                                    count300ms++;
                                }
                                else if (timeCompare > timeSpanSub200)
                                {
                                    Console.WriteLine("more than 200 milliseconds");
                                    count200ms++;
                                }
                                else if (timeCompare > timeSpanSub100)
                                {
                                    Console.WriteLine("more than 100 milliseconds");
                                    count100ms++;
                                }
                                else if (timeCompare >= timeSpanSub050)
                                {
                                    Console.WriteLine("more than 50 milliseconds");
                                    count50ms++;
                                }
                                else
                                {
                                    Console.WriteLine("less than 50ms");
                                    normalRange++;
                                }
                            }

                        }

                        else if ((lines[count].StartsWith(letterC)) && lines[count + 1].StartsWith(letterF))
                        {
                            string fullTimeValueC = new string(lines[count]);
                            string fullTimeValueF = new string(lines[count + 1]);

                            //set regex to find time
                            Match m = Regex.Match(fullTimeValueC, timeDatePattern);
                            Match m2 = Regex.Match(fullTimeValueF, timeDatePattern);
                            Match m3 = Regex.Match(fullTimeValueC, weightPattern);
                            Match m4 = Regex.Match(fullTimeValueF, weightPattern);
                            string weightString1 = (m3.Value);
                            string weightString2 = (m4.Value);
                            Match m5 = Regex.Match((string)weightString1, weightInNumbers);
                            Match m6 = Regex.Match(((string)weightString2), weightInNumbers);
                            int weight1 = int.Parse(m5.Value);
                            int weight2 = int.Parse(m6.Value);

                            DateTime DateC = DateTime.Parse(m.Value);
                            DateTime DateF = DateTime.Parse(m2.Value);
                            TimeSpan timeCompare = (DateF - DateC);

                            if ((timeCompare != TimeSpan.Zero) && (weight1 == weight2))
                            {

                                Console.WriteLine();
                                Console.WriteLine("Third");
                                Console.WriteLine(fullTimeValueC + "\n" + fullTimeValueF);
                                delayCounter2++;
                                Console.WriteLine(timeCompare + errorCodeC80Delay2);

                                if (timeCompare > timeSpanSub1sec)
                                {
                                    Console.WriteLine("more than 1 second");
                                    count1s++;
                                }
                                else if (timeCompare > timeSpanSub500)
                                {
                                    Console.WriteLine("more than 500 milliseconds");
                                    count500ms++;
                                }
                                else if (timeCompare > timeSpanSub400)
                                {
                                    Console.WriteLine("more than 400 milliseconds");
                                    count400ms++;
                                }
                                else if (timeCompare > timeSpanSub300)
                                {
                                    Console.WriteLine("more than 300 milliseconds");
                                    count300ms++;
                                }
                                else if (timeCompare > timeSpanSub200)
                                {
                                    Console.WriteLine("more than 200 milliseconds");
                                    count200ms++;
                                }
                                else if (timeCompare > timeSpanSub100)
                                {
                                    Console.WriteLine("more than 100 milliseconds");
                                    count100ms++;
                                }
                                else if (timeCompare >= timeSpanSub050)
                                {
                                    Console.WriteLine("more than 50 milliseconds");
                                    count50ms++;
                                }
                                else
                                {
                                    Console.WriteLine("less than 50ms");
                                    normalRange++;
                                }

                            }




                        }
                        if (lines[count].StartsWith(letterF))
                        {
                            scaleCount++;
                        }
                        if (lines[count].StartsWith(letterC))
                        {
                            c80Count++;
                        }
                        if (lines[count].StartsWith(letterE))
                        {
                            labelCount++;
                        }

                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                }
                Console.WriteLine();
                Console.WriteLine((count - 1) + ": Total data points checked");
                Console.WriteLine(delayCounter + ": total delayed packets");
                Console.WriteLine(delayCounter2 + ": C80 triggered before Flipp");
                Console.WriteLine();
                Console.WriteLine("Total scale count: " + scaleCount);
                Console.WriteLine("Total C80 count: " + c80Count);
                Console.WriteLine("Total label count: " + ((labelCount - errorEvoStatusProcessCount1) / 2));
                Console.WriteLine();
                Console.WriteLine(scaleCount - c80Count + " missing C80 data");
                Console.WriteLine(errorEvoStatusProcessCount1 + " missing or misplaced labels");
                Console.WriteLine(errorEvoStatusProcessCount2 + " labels finished after box has passed");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Delay Counts");
                Console.WriteLine(normalRange + " within normal range.");
                Console.WriteLine(count50ms + " delay between 50 & 100ms");
                Console.WriteLine(count100ms + " delay between 100 & 200ms");
                Console.WriteLine(count200ms + " delay between 200 & 300ms");
                Console.WriteLine(count300ms + " delay between 300 & 400ms");
                Console.WriteLine(count400ms + " delay between 400 & 500ms");
                Console.WriteLine(count500ms + " delay between 500ms & 1s");
                Console.WriteLine(count1s + " delays longer than 1 second");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine(errorEvoStatusProcessCount1 + ": Total Evo Process Errors");
                Console.WriteLine((errorEvoStatusProcessCount1 - errorEvoStatusProcessCount2) + ": Rendered but not finished - no label printed");
                Console.WriteLine(errorEvoStatusProcessCount2 + ": Rendered but finished at wrong time - labelled wrong box");
                Console.WriteLine(labelCountSub900ms + " below 900ms.");
                Console.WriteLine(labelCount900ms + " between 900 - 999ms");
                Console.WriteLine(labelCount1s + " between 1.00s - 1.099");
                Console.WriteLine(labelCount1_1s + " between 1.100s - 1.199");
                Console.WriteLine(labelCount1_2s + " between 1.200s - 1.299");
                Console.WriteLine(labelCount1_3s + " between 1.300s - 1.399");
                Console.WriteLine(labelCount1_4s + " between 1.400s - 1.499");
                Console.WriteLine(labelCount1_5s + " between 1.500s - 1.599");
                Console.WriteLine(labelCount1_6s + " between 1.600s - 1.699");
                Console.WriteLine(labelCount1_7s + " between 1.700s - 1.799");
                Console.WriteLine(labelCount1_8s + " between 1.800s - 1.899");
                Console.WriteLine(labelCount1_9s + " between 1.900s - 1.999");
                Console.WriteLine(labelCount2s + " more than 2 seconds");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();



            }
        }
    }
}