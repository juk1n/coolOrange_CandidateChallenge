using System.Linq;
using System.Collections.Generic;
using coolOrange_CandidateChallenge;
using NUnit.Framework;

namespace coolOrange_CandidateChallengeTest
{
    [TestFixture]
    public class TaskTest
    {
        [Test]
        public void TaskConstructor_SetsName()
        {
            Task task = new Task("Doing Homework");
            Assert.AreEqual("Doing Homework", task.GetName());
        }

        [Test]
        public void TaskConstructor_SetsComplexityToZero()
        {
            Task task = new Task("Doing Homework");
            Assert.AreEqual(0, task.GetComplexity());
        }

        [Test]
        public void TaskConstructor_SetsPriorityToMedPriority()
        {
            Task task = new Task("Doing Homework");
            Assert.AreEqual(Priority.MED_PRIORITY, task.GetPriority());
        }

        [Test]
        public void SetComplexity_SetsComplexity()
        {
            Task task = new Task("Doing Homework");
            task.SetComplexity(8);
            Assert.AreEqual(8, task.GetComplexity());
        }

        [Test]
        public void SetPriority_SetsPriority()
        {
            Task task = new Task("Doing Homework");
            task.SetPriority(Priority.MAX_PRIORITY);
            Assert.AreEqual(Priority.MAX_PRIORITY, task.GetPriority());
        }

        [Test]
        public void CompareTo_ComparePriority()
        {
            Task task1 = new Task("Task1");
            task1.SetPriority(Priority.MAX_PRIORITY);

            Task task2 = new Task("Task2");
            task2.SetPriority(Priority.MIN_PRIORITY);

            Assert.AreEqual(1, task1.CompareTo(task2));
        }
    }
}