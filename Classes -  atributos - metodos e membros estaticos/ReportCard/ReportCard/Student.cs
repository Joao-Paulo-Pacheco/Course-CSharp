using System;

namespace ReportCard
{
    class Student
    {
        public string Name;
        public double Note1, Note2, Note3;

        public double NoteFinish()
        {
            return Note1 + Note2 + Note3;
        }
        public bool Acredited()
        {
            if (NoteFinish() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double RemainingNote()
        {
            if (Acredited())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NoteFinish();
            }
        }
    }
}
