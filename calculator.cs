class calculator
[
	static void main(string[] args)
	{
		int a =10;
		int b = 0;
		
	Console.WriteLiine("hasil penambahan: {0}+[1} = {2}",a,b,penambahan(a,b));
	Console.WriteLiine("hasil prngurangan: {0}-[1} = {2}",a,b,pengurangan(a,b));
	
	Console.WriteLiine(\\n tekan sembarang key untuk keluar)
	Console.ReadKey();
	}
	
	static int penambahan(int a,int b)
	{
		return a+b;
	}
	static int pengurangan(int a,int b)
	{
		return a-b;
	}
]