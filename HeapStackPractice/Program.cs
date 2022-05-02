namespace practice {
    class Prgram
    {
        static void Main(string[] args)
        {
            int score = 44;
            int score2 = score;
            Console.WriteLine("Score = {0}, score2 = {1}", score, score2);

            score2 = 47;
            Console.WriteLine("Score = {0}, score2 modified = {1}", score, score2);

            Course myCourse = new Course()
            {
                Name = "CSCI .Net",
                Desc = "Learning more of stack and heap using .Net",
                Score = 55
            };
            Course myCourse2 = myCourse;

            Console.WriteLine(myCourse.Display());
            Console.WriteLine(myCourse2.Display());

            myCourse2.Score = 88;

            /* Both objects have the same value because a POINTER named myGrade is created when the new object
             * is instatiated. myGrade2 being set to equal myGrade made it POINT to the object within the heap.
             * so far there is only ONE object in the heap and 4 varaibles in the stack. 
             *
             * However, if the Grade class is a struct, it will be stored on the stack, updating the value in
             * the Score.
             */
            Console.WriteLine(myCourse.Display());
            Console.WriteLine(myCourse2.Display());

            /* Objects are passed as reference so the value will change, but if this was a struct
             * it would not change. */
            Process(score, myCourse);
            Console.WriteLine("Score is {0}", score);
            Console.WriteLine(myCourse.Display());
            Console.WriteLine(myCourse2.Display());

            Console.ReadLine();
        }

        static void Process(int score, Course course)
        {
            score = 92;
            course.Desc = "desc has been changed changed"; 
        }
    }

    class Course
    {
        public string? Name { get; set;}
        public string? Desc { get; set; }
        public int Score { get; set; }
        
        public string Display()
        {
            return String.Format("Course Name: {0}, Course Desc: {1}, Course Score: {2}", Name, Desc, Score);
        }
    }
}