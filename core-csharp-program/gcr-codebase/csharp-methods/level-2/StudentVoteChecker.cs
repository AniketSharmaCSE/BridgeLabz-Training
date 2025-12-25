using System;

public class StudentVoteChecker
{
	//Method to check whether student can vote
	static bool CanStudentVote(int age)	{
		if(age>=18){
			return true;
		}
		else{
			return false;
		}
	}

	
	static void Main(string[] args)
	{
		//define array to store ages
		int[] ages=new int[10];
		//Take input from user
		for(int i=0;i<ages.Length;i++){
			Console.WriteLine("Enter age:");
			ages[i]=Convert.ToInt32(Console.ReadLine());
		}

		//Check voting eligibility
		for(int i=0;i<ages.Length;i++){
			if(CanStudentVote(ages[i])){
				Console.WriteLine("Can Vote");
			}
			else{
				Console.WriteLine("Cannot Vote");
			}
		}
	}
}
