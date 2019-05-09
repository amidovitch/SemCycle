using System;
using System.Collections.Generic;
using System.Text;

namespace SemCycle.DataBase
{
    class EduProcess
    {
        private static int currentSem = 0;

        protected static List<Semester> semList = new List<Semester> ();

        public static int CurrentSem { get => currentSem; set => currentSem = value; }

        public EduProcess()
        {

        }
        public void ClearDiscipline(int i)
        {
            semList[i].ClearDiscipline();
        }
        public void addSem()
        {
            currentSem++;
            semList.Add(new Semester(currentSem));
        }
        public void deleteSem(int num)
        {

        }
        public int GetSizeSemList()
        {
            return semList.Count;
        }
        public Semester getSem(int num)
        {
            return semList[num];
        }

    }
}
