using System;

// initialize variables - graded assignments
int currentAssignments = 5;

int[]	sophia = new int[] {90, 86, 87, 98, 100, 94, 90};
int[]	andrew = new int[] {92, 89, 81, 96, 90, 98};
int[]	emma = new int[] {90, 85, 87, 98, 68, 89, 89, 89};
int[]	lohan = new int[] {90, 95, 87, 88, 96, 96};
int[]	becky = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[]	chris = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[]	eric = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[]	gregor = new int[] { 91, 91, 91, 91, 91, 91, 91 };
string[]	names = new string[] {"sophia", "andrew", "emma", "lohan", "becky", "chris", "eric", "gregor"};
;

Console.WriteLine("Student\t\tExam Score\t\tOverall Grade\t\tExtra Credit");
foreach (string name in names){
	decimal extraPoints = 0;
	decimal	examGrade = 0;
	decimal	extraGrade = 0;
	int[] studentScores = new int[name.Length];
	string	currentStudentLetterGrade;
	int	gradeAssignments = 0;
	if (name == "sophia")
		studentScores = sophia;
	else if (name == "andrew")
		studentScores = andrew;
	else if (name == "emma")
		studentScores = emma;
	else if (name == "lohan")
		studentScores = lohan;
	else if (name == "becky")
		studentScores = becky;
	else if (name == "chris")
		studentScores = chris;
	else if (name == "eric")
		studentScores = eric;
	else if (name == "gregor")
		studentScores = gregor;
	decimal	total = 0;
	foreach(int	num in studentScores){
		gradeAssignments++;
		if (gradeAssignments <= currentAssignments)
			examGrade += num;
		else
			extraGrade += num;
	}
	total = (examGrade + (extraGrade / 10)) / currentAssignments;
	examGrade /= currentAssignments;
	extraGrade /= gradeAssignments - currentAssignments;
	extraPoints = extraGrade / 10 / currentAssignments;
	if (total >= 97)
        currentStudentLetterGrade = "A+";

    else if (total >= 93)
        currentStudentLetterGrade = "A";

    else if (total >= 90)
        currentStudentLetterGrade = "A-";

    else if (total >= 87)
        currentStudentLetterGrade = "B+";

    else if (total >= 83)
        currentStudentLetterGrade = "B";

    else if (total >= 80)
        currentStudentLetterGrade = "B-";

    else if (total >= 77)
        currentStudentLetterGrade = "C+";

    else if (total >= 73)
        currentStudentLetterGrade = "C";

    else if (total >= 70)
        currentStudentLetterGrade = "C-";

    else if (total >= 67)
        currentStudentLetterGrade = "D+";

    else if (total >= 63)
        currentStudentLetterGrade = "D";

    else if (total >= 60)
        currentStudentLetterGrade = "D-";
	else
		currentStudentLetterGrade = "F";
	Console.WriteLine($"{name}\t\t{examGrade}\t\t\t{total}\t{currentStudentLetterGrade}\t\t{extraGrade}\t{extraPoints}");

}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

/*decimal sophiaScore = 0;
foreach (int num in sophia)
	sophiaScore += num;
sophiaScore /= sophia.Length;
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine(); */
