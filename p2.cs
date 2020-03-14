using System;

namespace Calculator{
	public class Calculator{
		public void Main(string[] args){
			int a;
			int b;
			int pil;

			Console.WriteLine("Pilihan menu Calculator \n");
			Console.WriteLine("1. Penambahan \n");
			Console.WriteLine("2. Pengurangan \n");
			Console.WriteLine("3. Perkalian \n");
			Console.WriteLine("4. Pembagian \n");
			Console.WriteLine("Masukan pilihan menu : ");
			pil = Convert.ToInt32(Console.ReadLine()); 
			
			Console.WriteLine("Masukan nilai A : ");
			a = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Masukan nilai B : ");
			b = Convert.ToInt32(Console.ReadLine());

			if(pil == 1){
				Console.WriteLine("Hasil penambahan: {0} + {1} = {2}", a,b, Penambahan(a,b));
			}
			if(pil == 2){
				Console.WriteLine("Hasil penambahan: {0} - {1} = {2}", a,b, Pengurangan(a,b));
			}
			if(pil == 3){
				Console.WriteLine("Hasil penambahan: {0} * {1} = {2}", a,b, Perkalian(a,b));
			}
			if(pil == 4){
				Console.WriteLine("Hasil penambahan: {0} / {1} = {2}", a,b, Pembagian(a,b));
			}
		}
		
		static int Penambahan(int a, int b){
			return a + b;
		}
		static int Pengurangan(int a, int b){
			return a - b;
		}
		static int Perkalian(int a, int b){
			return a * b;
		}
		static int Pembagian(int a, int b){
			return a / b;
		}

	}
	
}
