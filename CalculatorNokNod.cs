using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program
    {
        public static void Main() 
        {
            // TODO: Enter the numbers from the kyboard
            var calculator = new CalculatorNokNod(3, 5);
            var nod = calculator.CalcNod();
            
            Console.WriteLine("The NOD is equal to " + nod);
        }
        
        
    }
    
    public class CalculatorNokNod
    {
    	private int a;
    	private int b;
    	
    	public CalculatorNokNod(int a, int b)
    	{
    		this.a = a;
    		this.b = b;
    	}
    	
    	public int CalcNok()
    	{
    		return 5;
    	}
    	
    	public int CalcNod()
    	{
    		return 5765;
    	}
    }
}
