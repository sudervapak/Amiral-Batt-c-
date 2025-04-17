/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

namespace MyApplication
{
  class Program
  {
        public static string [,] board_player1 = new string [10, 10]; 
        public static string [,] board_player2 = new string [10, 10]; 
        static int turn_player = 1;

    static void Main(string[] args)
    {
      
      Define_Board();
      
      if (turn_player == 1){
          Console.WriteLine(" ");
          Console.WriteLine("P1: Please enter the value of row;  ");
          int row = Console.ReadLine();
          Console.WriteLine("P1: Please enter the value of column;  ");
          int column = Console.ReadLine();
          
          board_player1[row][column] = "O";
          Display_Board(board_player1, turn_player);
          turn_player ++;
          
          
      }
      
      else if (turn_player == 2 ){
          Console.WriteLine(" ");
          Console.WriteLine("P2: Please enter the value of row;  ");
          int row = Console.ReadLine();
          Console.WriteLine("P2: Please enter the value of column;  ");
          int column = Console.ReadLine();
          
          board_player2[row][column] = "O";
          Display_Board(board_player2, turn_player);
          turn_player--;
      }
      

    }  
    
    
    static void Display_Board( string [,] board, int x){

        Console.WriteLine(" ");
        string y = x.ToString();
        
        Console.WriteLine("P" + y);
        
        for(int i=0; i<10; i++){
            
            for(int j=0; j<10; j++){
                
                
                Console.Write("[" + board[i,j] + "]");
            }

            Console.Write("\n");
        }  
        
    }
    
    
    
    static void Define_Board(){
        //string [,] board_player1 = new string [10, 10]; 
        //string [,] board_player2 = new string [10, 10]; 

        for(int i=0; i<10; i++){
            
            for(int j=0; j<10; j++){
                
                board_player1[i,j]= "?";
                Console.Write("[" + board_player1[i,j] + "]");
            }
            Console.Write("  |  ");
            
            for(int j=0; j<10; j++){
                
                board_player2[i,j]= "?";
                Console.Write("[" + board_player2[i,j] + "]");
            }
            Console.Write("\n");
        }    
    }

  }
}

