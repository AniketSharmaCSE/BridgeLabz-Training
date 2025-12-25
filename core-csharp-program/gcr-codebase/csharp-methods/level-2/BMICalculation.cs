using System;

public class BMICalculation
{
	//Method to calculate BMI values
	static void CalculateBMI(double[,] data){
		for(int i=0;i<data.GetLength(0);i++){
			double heightInMeter=data[i,1]/100;
			data[i,2]=data[i,0]/(heightInMeter*heightInMeter);
		}
	}

	//Method to determine BMI status
	static string[] GetBMIStatus(double[,] data){
		string[] status=new string[data.GetLength(0)];

		for(int i=0;i<data.GetLength(0);i++){
			if(data[i,2]<18.5){
				status[i]="Underweight";
			}
			
			else if(data[i,2]<25){
				status[i]="Normal";
			}
			else{
				status[i]="Overweight";
			}
		}
		return status;
	}

	static void Main(string[] args)
	{
		double[,] data=new double[10,3];
		for(int i=0;i<10;i++){
			Console.WriteLine("Enter weight:");
			data[i,0]=Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter height in cm:");
			data[i,1]=Convert.ToDouble(Console.ReadLine());
		}

		CalculateBMI(data);
		string[] status=GetBMIStatus(data);

		for(int i=0;i<10;i++){
			Console.WriteLine(data[i,0]+" "+data[i,1]+" "+data[i,2]+" "+status[i]);
		}
	}
}
