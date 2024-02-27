using System;
using System.Collections.Generic;

namespace coolOrange_CandidateChallenge
{
    public class Task : IComplexity, IPriority, IComparable
    {
        private string name;
        private int complexity;
        private Priority priority;

        public Task(string name)
        {
            this.name = name;
            complexity = 0;
            priority = Priority.MED_PRIORITY;
        }

        public void SetComplexity(int c)
        {
            this.complexity = c;
        }

        public int GetComplexity()
        {
            return this.complexity;
        }

        public void SetPriority(Priority p)
        {
            this.priority = p;
        }

        public Priority GetPriority()
        {
            return this.priority;
        }

        public string GetName()
        {
            return this.name;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) 
                return 1;

            var otherTask = obj as Task;
            if (otherTask != null)
            {
                return this.priority.CompareTo(otherTask.priority);
            }
            else
            {
                throw new ArgumentException("Object is not a Task");
            }
        }
    }

    public enum Priority
    {
        MIN_PRIORITY = 1,
        MED_PRIORITY = 5,
        MAX_PRIORITY = 10,
    }
    interface IComplexity
    {
        void SetComplexity(int c);
        int GetComplexity();
    }
    interface IPriority
    {
        void SetPriority(Priority p);
        Priority GetPriority();
    }
    
    class TaskDriver
    {
        static void Main(string[] args)
        {
            List<Task> liste = new List<Task>();
            
            Task task1 = new Task("Doing Homework");
            task1.SetComplexity(8);
            task1.SetPriority(Priority.MAX_PRIORITY);
            liste.Add(task1);

            Task task2 = new Task("Eating Lunch");
            task2.SetComplexity(2);
            task2.SetPriority(Priority.MIN_PRIORITY);
            liste.Add(task2);

            Task task3 = new Task("Programming");
            task3.SetComplexity(5);
            task3.SetPriority(Priority.MED_PRIORITY);
            liste.Add(task3);
            
            for (int i=0; i<3; i++)
                Console.WriteLine(liste[i].GetName()+" priority: "+liste[i].GetPriority()+
                                  " complexity: "+liste[i].GetComplexity());
            liste.Sort();
            Console.WriteLine(liste[liste.Count-1].GetName()+" is one of the most important tasks.");
            
        }
    }
}
