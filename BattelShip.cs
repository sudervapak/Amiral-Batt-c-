using System;

namespace MyApplication
{
    class Program
    {
        public static string[,] board_player1 = new string[10, 10];
        public static string[,] board_player2 = new string[10, 10];
        
        public static string[,] boardWships_player1 = new string[10, 10];
        public static string[,] boardWships_player2 = new string[10, 10];

        static int turn_player = 1;
        static int row1;
        static int column1;
        static int row2;
        static int column2;
        static Player P1 = new Player(0);
        static Player P2 = new Player(0);
        static string direction1;
        static string direction2;
        static bool transition_temp= true;
        static string inputx;
        static string inputy;
        static string inputx1;
        static string inputy1;
        
        static void Main(string[] args)
        {
            
            Starting_screen();
            
            
            Console.WriteLine("P1: Please enter your name:  ");
            string P1_name = Console.ReadLine();
            P1.name = P1_name;
            
            
            Console.WriteLine("P2: Please enter your name:  ");
            string P2_name = Console.ReadLine(); 
            P2.name = P2_name;
            
                
/* We have created a part that controls the turns of the players.
*/          
            Define_Board();
            ///////////////////////////////////
            int temp5=0;
            
            while (transition_temp == true){
                Console.WriteLine(" ");
                Console.WriteLine("************************");
                Console.WriteLine(" TIME TO PLACE THE SHIPS");
                Console.WriteLine("************************");
            
                if (temp5==0){ 
                    
                    Console.WriteLine(P1.name + ":Aircraft Carrier(5x1): ");
                    Input_ships1();
                    if(direction1 == "R"){
                        int key = 0;
                            
                        while(key == 0){
                                
                            if(column1 + 5 <= 10){
                                
                                int t= column1 + 5;
                                int stop=0;
                                
                                for(int i= column1; i<t; i++){
                                    if(boardWships_player1[row1,i] == "S"){
                                        stop++;
                                    }
                                } 
                                
                                if(stop >0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name +": Aircraft Carrier(5x1): ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= column1; i<t; i++) {
                                        boardWships_player1[row1,i]="S";
                                        
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine("Aircraft Carrier(5x1): ");
                                    Input_ships1();
                            }
                        }
                    }            
                    else if(direction1 == "L"){
                        int key1 = 0;
                            
                        while(key1 == 0){
                                
                            if(column1 - 5 >0){
                            
                                int t1= column1-5;
                                int stop1=0;
                                
                                for(int i = column1; i>=t1; i--){
                                    if(boardWships_player1[row1,i]== "S"){
                                        stop1++;
                                    }
                                } 
                                if(stop1>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + "Aircraft Carrier(5x1): ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i = column1; i>t1; i--) {
                                        boardWships_player1[row1,i]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key1++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Aircraft Carrier(5x1): ");
                                Input_ships1();
                            }
                        }
                    }
                    else if(direction1 == "U"){
                        int key3 = 0;
                            
                        while(key3 == 0){
                                
                            if(row1 - 5 >0){
                            
                                int t3= row1-5;
                                int stop3=0;
                                
                                for(int i = row1; i>=t3; i--){
                                    if(boardWships_player1[i,column1]== "S"){
                                        stop3++;
                                    }
                                } 
                                if(stop3>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + "Aircraft Carrier(5x1): ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= row1; i>t3; i--) {
                                        boardWships_player1[i,column1]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key3++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Aircraft Carrier(5x1): ");
                                Input_ships1();
                            }
                        }
                    }
                   else if(direction1 == "D"){
                        int key2 = 0;
                            
                        while(key2 == 0){
                                
                            if(row1 + 5 <= 10){
                            
                                int t2= row1+5;
                                int stop2=0;
                                
                                for(int i = row1; i<=t2; i++){
                                    if(boardWships_player1[i,column1]== "S"){
                                        stop2++;
                                    }
                                } 
                                if(stop2>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + "Aircraft Carrier(5x1): ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= row1; i<t2; i++) {
                                        boardWships_player1[i,column1]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key2++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Aircraft Carrier(5x1): ");
                                Input_ships1();
                            }
                        }
                    } 
                }
                if (temp5==1){ 
                    
                    Console.WriteLine(P1.name + ":Cruiser (4x1) ship: ");
                    Input_ships1();
                    if(direction1 == "R"){
                        int key4 = 0;
                            
                        while(key4 == 0){
                                
                            if(column1 + 4 <= 10){
                                
                                int t4= column1 + 4;
                                int stop4=0;
                                
                                for(int i= column1; i<t4; i++){
                                    if(boardWships_player1[row1,i] == "S"){
                                        stop4++;
                                    }
                                } 
                                
                                if(stop4 >0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name +": Cruiser (4x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= column1; i<t4; i++) {
                                        boardWships_player1[row1,i]="S";
                                        
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key4++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine("Cruiser (4x1) ship: ");
                                    Input_ships1();
                            }
                        }
                    }            
                    else if(direction1 == "L"){
                        int key5 = 0;
                            
                        while(key5 == 0){
                                
                            if(column1 - 4 >0){
                            
                                int t5= column1-4;
                                int stop5=0;
                                
                                for(int i = column1; i>=t5; i--){
                                    if(boardWships_player1[row1,i]== "S"){
                                        stop5++;
                                    }
                                } 
                                if(stop5>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + "Cruiser (4x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i = column1; i>t5; i--) {
                                        boardWships_player1[row1,i]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key5++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Cruiser (4x1) ship: ");
                                Input_ships1();
                            }
                        }
                    }
                    else if(direction1 == "U"){
                        int key6 = 0;
                            
                        while(key6 == 0){
                                
                            if(row1 - 4 >0){
                            
                                int t6= row1-4;
                                int stop6=0;
                                
                                for(int i = row1; i>=t6; i--){
                                    if(boardWships_player1[i,column1]== "S"){
                                        stop6++;
                                    }
                                } 
                                if(stop6>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + ": Cruiser (4x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= row1; i>t6; i--) {
                                        boardWships_player1[i,column1]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key6++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Cruiser (4x1) ship: ");
                                Input_ships1();
                            }
                        }
                    }
                   else if(direction1 == "D"){
                        int key7 = 0;
                            
                        while(key7 == 0){
                                
                            if(row1 + 4 <= 10){
                            
                                int t7= row1+4;
                                int stop7=0;
                                
                                for(int i = row1; i<=t7; i++){
                                    if(boardWships_player1[i,column1]== "S"){
                                        stop7++;
                                    }
                                } 
                                if(stop7>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + ": Cruiser (4x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= row1; i<t7; i++) {
                                        boardWships_player1[i,column1]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key7++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Cruiser (4x1) ship: ");
                                Input_ships1();
                            }
                        }
                    } 
                }
                if (temp5==2){ 
                    
                    Console.WriteLine(P1.name + " :Destroyer (3x1) ship: ");
                    Input_ships1();
                    if(direction1 == "R"){
                        int key8 = 0;
                            
                        while(key8 == 0){
                                
                            if(column1 + 3 <= 10){
                                
                                int t8= column1 + 3;
                                int stop8=0;
                                
                                for(int i= column1; i<t8; i++){
                                    if(boardWships_player1[row1,i] == "S"){
                                        stop8++;
                                    }
                                } 
                                
                                if(stop8 >0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name +": Destroyer (3x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= column1; i<t8; i++) {
                                        boardWships_player1[row1,i]="S";
                                        
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key8++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine("Destroyer (3x1) ship: ");
                                    Input_ships1();
                            }
                        }
                    }            
                    else if(direction1 == "L"){
                        int key9 = 0;
                            
                        while(key9 == 0){
                                
                            if(column1 - 3 >0){
                            
                                int t9= column1-3;
                                int stop9=0;
                                
                                for(int i = column1; i>=t9; i--){
                                    if(boardWships_player1[row1,i]== "S"){
                                        stop9++;
                                    }
                                } 
                                if(stop9>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + "Destroyer (3x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i = column1; i>t9; i--) {
                                        boardWships_player1[row1,i]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key9++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships1();
                            }
                        }
                    }
                    else if(direction1 == "U"){
                        int key10 = 0;
                            
                        while(key10 == 0){
                                
                            if(row1 - 3 >0){
                            
                                int t10= row1-3;
                                int stop10=0;
                                
                                for(int i = row1; i>=t10; i--){
                                    if(boardWships_player1[i,column1]== "S"){
                                        stop10++;
                                    }
                                } 
                                if(stop10>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + ": Destroyer (3x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= row1; i>t10; i--) {
                                        boardWships_player1[i,column1]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key10++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships1();
                            }
                        }
                    }
                   else if(direction1 == "D"){
                        int key11 = 0;
                            
                        while(key11 == 0){
                                
                            if(row1 + 3 <= 10){
                            
                                int t11= row1+3;
                                int stop11=0;
                                
                                for(int i = row1; i<=t11; i++){
                                    if(boardWships_player1[i,column1]== "S"){
                                        stop11++;
                                    }
                                } 
                                if(stop11>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + " :Destroyer (3x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= row1; i<t11; i++) {
                                        boardWships_player1[i,column1]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key11++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships1();
                            }
                        }
                    } 
                }
                if (temp5==3){ 
                    
                    Console.WriteLine(P1.name + " :Destroyer (3x1) ship: ");
                    Input_ships1();
                    if(direction1 == "R"){
                        int key12 = 0;
                            
                        while(key12 == 0){
                                
                            if(column1 + 3 <= 10){
                                
                                int t12= column1 + 3;
                                int stop12=0;
                                
                                for(int i= column1; i<t12; i++){
                                    if(boardWships_player1[row1,i] == "S"){
                                        stop12++;
                                    }
                                } 
                                
                                if(stop12 >0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name +": Destroyer (3x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= column1; i<t12; i++) {
                                        boardWships_player1[row1,i]="S";
                                        
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key12++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine("Destroyer (3x1) ship: ");
                                    Input_ships1();
                            }
                        }
                    }            
                    else if(direction1 == "L"){
                        int key13 = 0;
                            
                        while(key13 == 0){
                                
                            if(column1 - 3 >0){
                            
                                int t13= column1-3;
                                int stop13=0;
                                
                                for(int i = column1; i>=t13; i--){
                                    if(boardWships_player1[row1,i]== "S"){
                                        stop13++;
                                    }
                                } 
                                if(stop13>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + " :Destroyer (3x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i = column1; i>t13; i--) {
                                        boardWships_player1[row1,i]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key13++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships1();
                            }
                        }
                    }
                    else if(direction1 == "U"){
                        int key14 = 0;
                            
                        while(key14 == 0){
                                
                            if(row1 - 3 >0){
                            
                                int t14= row1-3;
                                int stop14=0;
                                
                                for(int i = row1; i>=t14; i--){
                                    if(boardWships_player1[i,column1]== "S"){
                                        stop14++;
                                    }
                                } 
                                if(stop14>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + ":Destroyer (3x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= row1; i>t14; i--) {
                                        boardWships_player1[i,column1]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key14++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships1();
                            }
                        }
                    }
                   else if(direction1 == "D"){
                        int key15 = 0;
                            
                        while(key15 == 0){
                                
                            if(row1 + 3 <= 10){
                            
                                int t15= row1+3;
                                int stop15=0;
                                
                                for(int i = row1; i<=t15; i++){
                                    if(boardWships_player1[i,column1]== "S"){
                                        stop15++;
                                    }
                                } 
                                if(stop15>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + ": Destroyer (3x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= row1; i<t15; i++) {
                                        boardWships_player1[i,column1]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key15++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships1();
                            }
                        }
                    } 
                }
                if (temp5==4){ 
                    
                    Console.WriteLine(P1.name + ": Frigates (2x1) ship: ");
                    Input_ships1();
                    if(direction1 == "R"){
                        int key16 = 0;
                            
                        while(key16 == 0){
                                
                            if(column1 + 2 <= 10){
                                
                                int t16= column1 + 2;
                                int stop16=0;
                                
                                for(int i= column1; i<t16; i++){
                                    if(boardWships_player1[row1,i] == "S"){
                                        stop16++;
                                    }
                                } 
                                
                                if(stop16 >0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name +": Frigates (2x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= column1; i<t16; i++) {
                                        boardWships_player1[row1,i]="S";
                                        
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key16++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine("Frigates (2x1) ship: ");
                                    Input_ships1();
                            }
                        }
                    }            
                    else if(direction1 == "L"){
                        int key17 = 0;
                            
                        while(key17 == 0){
                                
                            if(column1 - 2 >0){
                            
                                int t17= column1-2;
                                int stop17=0;
                                
                                for(int i = column1; i>=t17; i--){
                                    if(boardWships_player1[row1,i]== "S"){
                                        stop17++;
                                    }
                                } 
                                if(stop17>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + ": Frigates (2x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i = column1; i>t17; i--) {
                                        boardWships_player1[row1,i]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key17++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Frigates (2x1) ship: ");
                                Input_ships1();
                            }
                        }
                    }
                    else if(direction1 == "U"){
                        int key18 = 0;
                            
                        while(key18 == 0){
                                
                            if(row1 - 2 >0){
                            
                                int t18= row1-2;
                                int stop18=0;
                                
                                for(int i = row1; i>=t18; i--){
                                    if(boardWships_player1[i,column1]== "S"){
                                        stop18++;
                                    }
                                } 
                                if(stop18>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + ": Frigates (2x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= row1; i>t18; i--) {
                                        boardWships_player1[i,column1]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key18++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Frigates (2x1) ship: ");
                                Input_ships1();
                            }
                        }
                    }
                   else if(direction1 == "D"){
                        int key19 = 0;
                            
                        while(key19 == 0){
                                
                            if(row1 + 2 <= 10){
                            
                                int t19= row1+2;
                                int stop19=0;
                                
                                for(int i = row1; i<=t19; i++){
                                    if(boardWships_player1[i,column1]== "S"){
                                        stop19++;
                                    }
                                } 
                                if(stop19>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P1.name + "Frigates (2x1) ship: ");
                                    Input_ships1();
                                }
                                else{
                                    for(int i= row1; i<t19; i++) {
                                        boardWships_player1[i,column1]="S";
                                    }
                                    Display_BoardWships1(boardWships_player1);
                                    key19++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Frigates (2x1) ship: ");
                                Input_ships1();
                            }
                        }
                        
                    } 
                }
                Console.Clear();
                if (temp5==5){ 
                    
                    Console.WriteLine(P2.name + ": Aircraft Carrier(5x1): ");
                    Input_ships2();
                    if(direction2 == "R"){
                        int key20 = 0;
                            
                        while(key20 == 0){
                                
                            if(column2 + 5 <= 10){
                                
                                int t20= column2 + 5;
                                int stop20=0;
                                
                                for(int i= column2; i<t20; i++){
                                    if(boardWships_player2[row2,i] == "S"){
                                        stop20++;
                                    }
                                } 
                                
                                if(stop20 >0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name +": Aircraft Carrier(5x1): ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= column2; i<t20; i++) {
                                        boardWships_player2[row2,i]="S";
                                        
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key20++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine("Aircraft Carrier(5x1): ");
                                    Input_ships2();
                            }
                        }
                    }            
                    else if(direction2 == "L"){
                        int key21 = 0;
                            
                        while(key21 == 0){
                                
                            if(column2 - 5 >0){
                            
                                int t21= column2-5;
                                int stop21=0;
                                
                                for(int i = column2; i>=t21; i--){
                                    if(boardWships_player2[row2,i]== "S"){
                                        stop21++;
                                    }
                                } 
                                if(stop21>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + "Aircraft Carrier(5x1): ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i = column2; i>t21; i--) {
                                        boardWships_player2[row2,i]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key21++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Aircraft Carrier(5x1): ");
                                Input_ships2();
                            }
                        }
                    }
                    else if(direction2 == "U"){
                        int key22 = 0;
                            
                        while(key22 == 0){
                                
                            if(row2 - 5 >0){
                            
                                int t22= row2-5;
                                int stop22=0;
                                
                                for(int i = row2; i>=t22; i--){
                                    if(boardWships_player2[i,column2]== "S"){
                                        stop22++;
                                    }
                                } 
                                if(stop22>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + "Aircraft Carrier(5x1): ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= row2; i>t22; i--) {
                                        boardWships_player2[i,column2]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key22++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Aircraft Carrier(5x1): ");
                                Input_ships2();
                            }
                        }
                    }
                   else if(direction2 == "D"){
                        int key23 = 0;
                            
                        while(key23 == 0){
                                
                            if(row2 + 5 <= 10){
                            
                                int t23= row2+5;
                                int stop23=0;
                                
                                for(int i = row2; i<=t23; i++){
                                    if(boardWships_player2[i,column2]== "S"){
                                        stop23++;
                                    }
                                } 
                                if(stop23>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + "Aircraft Carrier(5x1): ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= row2; i<t23; i++) {
                                        boardWships_player2[i,column2]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key23++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Aircraft Carrier(5x1): ");
                                Input_ships2();
                            }
                        }
                    } 
                }
                if (temp5==6){ 
                    
                    Console.WriteLine(P2.name + ": Cruiser (4x1) ship: ");
                    Input_ships2();
                    if(direction2 == "R"){
                        int key24 = 0;
                            
                        while(key24 == 0){
                                
                            if(column2 + 4 <= 10){
                                
                                int t24= column2 + 4;
                                int stop24=0;
                                
                                for(int i= column2; i<t24; i++){
                                    if(boardWships_player2[row2,i] == "S"){
                                        stop24++;
                                    }
                                } 
                                
                                if(stop24 >0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name +": Cruiser (4x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= column2; i<t24; i++) {
                                        boardWships_player2[row2,i]="S";
                                        
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key24++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine("Cruiser (4x1) ship: ");
                                    Input_ships2();
                            }
                        }
                    }            
                    else if(direction2 == "L"){
                        int key25 = 0;
                            
                        while(key25 == 0){
                                
                            if(column2 - 4 >0){
                            
                                int t25= column2-4;
                                int stop25=0;
                                
                                for(int i = column2; i>=t25; i--){
                                    if(boardWships_player2[row2,i]== "S"){
                                        stop25++;
                                    }
                                } 
                                if(stop25>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + "Cruiser (4x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i = column2; i>t25; i--) {
                                        boardWships_player2[row2,i]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key25++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Cruiser (4x1) ship: ");
                                Input_ships2();
                            }
                        }
                    }
                    else if(direction2 == "U"){
                        int key26 = 0;
                            
                        while(key26 == 0){
                                
                            if(row2 - 4 >0){
                            
                                int t26= row2-5;
                                int stop26=0;
                                
                                for(int i = row2; i>=t26; i--){
                                    if(boardWships_player2[i,column2]== "S"){
                                        stop26++;
                                    }
                                } 
                                if(stop26>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + "Cruiser (4x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= row2; i>t26; i--) {
                                        boardWships_player2[i,column2]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key26++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Cruiser (4x1) ship: ");
                                Input_ships2();
                            }
                        }
                    }
                   else if(direction2 == "D"){
                        int key27 = 0;
                            
                        while(key27 == 0){
                                
                            if(row2 + 4 <= 10){
                            
                                int t27= row2+4;
                                int stop27=0;
                                
                                for(int i = row2; i<=t27; i++){
                                    if(boardWships_player2[i,column2]== "S"){
                                        stop27++;
                                    }
                                } 
                                if(stop27>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + "Cruiser (4x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= row2; i<t27; i++) {
                                        boardWships_player2[i,column2]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key27++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Cruiser (4x1) ship: ");
                                Input_ships2();
                            }
                        }
                    } 
                }
                if (temp5==7){ 
                    
                    Console.WriteLine(P2.name + ": Destroyer (3x1) ship: ");
                    Input_ships2();
                    if(direction2 == "R"){
                        int key28 = 0;
                            
                        while(key28 == 0){
                                
                            if(column2 + 3 <= 10){
                                
                                int t28= column2 + 3;
                                int stop28=0;
                                
                                for(int i= column2; i<t28; i++){
                                    if(boardWships_player2[row2,i] == "S"){
                                        stop28++;
                                    }
                                } 
                                
                                if(stop28 >0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name +": Destroyer (3x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= column2; i<t28; i++) {
                                        boardWships_player2[row2,i]="S";
                                        
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key28++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine("Destroyer (3x1) ship: ");
                                    Input_ships2();
                            }
                        }
                    }            
                    else if(direction2 == "L"){
                        int key29 = 0;
                            
                        while(key29 == 0){
                                
                            if(column2 - 3 >0){
                            
                                int t29= column2-3;
                                int stop29=0;
                                
                                for(int i = column2; i>=t29; i--){
                                    if(boardWships_player2[row2,i]== "S"){
                                        stop29++;
                                    }
                                } 
                                if(stop29>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + " :Destroyer (3x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i = column2; i>t29; i--) {
                                        boardWships_player2[row2,i]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key29++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships2();
                            }
                        }
                    }
                    else if(direction2 == "U"){
                        int key30 = 0;
                            
                        while(key30 == 0){
                                
                            if(row2 - 3 >0){
                            
                                int t30= row2-3;
                                int stop30=0;
                                
                                for(int i = row2; i>=t30; i--){
                                    if(boardWships_player2[i,column2]== "S"){
                                        stop30++;
                                    }
                                } 
                                if(stop30>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + " :Destroyer (3x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= row2; i>t30; i--) {
                                        boardWships_player2[i,column2]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key30++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships2();
                            }
                        }
                    }
                   else if(direction2 == "D"){
                        int key31 = 0;
                            
                        while(key31 == 0){
                                
                            if(row2 + 3 <= 10){
                            
                                int t31= row2+5;
                                int stop31=0;
                                
                                for(int i = row2; i<=t31; i++){
                                    if(boardWships_player2[i,column2]== "S"){
                                        stop31++;
                                    }
                                } 
                                if(stop31>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + "Destroyer (3x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= row2; i<t31; i++) {
                                        boardWships_player2[i,column2]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key31++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships2();
                            }
                        }
                    } 
                }
                if (temp5==8){ 
                    
                    Console.WriteLine(P2.name + ": :Destroyer (3x1) ship: ");
                    Input_ships2();
                    if(direction2 == "R"){
                        int key32 = 0;
                            
                        while(key32 == 0){
                                
                            if(column2 + 3 <= 10){
                                
                                int t32= column2 + 3;
                                int stop32=0;
                                
                                for(int i= column2; i<t32; i++){
                                    if(boardWships_player2[row2,i] == "S"){
                                        stop32++;
                                    }
                                } 
                                
                                if(stop32 >0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name +": Destroyer (3x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= column2; i<t32; i++) {
                                        boardWships_player2[row2,i]="S";
                                        
                                    }
                                    Display_BoardWships2(boardWships_player2); 
                                    key32++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine("Destroyer (3x1) ship: ");
                                    Input_ships2();
                            }
                        }
                    }            
                    else if(direction2 == "L"){
                        int key33 = 0;
                            
                        while(key33 == 0){
                                
                            if(column2 - 3 >0){
                            
                                int t33= column2-3;
                                int stop33=0;
                                
                                for(int i = column2; i>=t33; i--){
                                    if(boardWships_player2[row2,i]== "S"){
                                        stop33++;
                                    }
                                } 
                                if(stop33>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + "Destroyer (3x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i = column2; i>t33; i--) {
                                        boardWships_player2[row2,i]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key33++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships2();
                            }
                        }
                    }
                    else if(direction2 == "U"){
                        int key34 = 0;
                            
                        while(key34 == 0){
                                
                            if(row2 - 3 >0){
                            
                                int t34= row2-3;
                                int stop34=0;
                                
                                for(int i = row2; i>=t34; i--){
                                    if(boardWships_player2[i,column2]== "S"){
                                        stop34++;
                                    }
                                } 
                                if(stop34>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + " :Destroyer (3x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= row2; i>t34; i--) {
                                        boardWships_player2[i,column2]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key34++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships2();
                            }
                        }
                    }
                   else if(direction2 == "D"){
                        int key35 = 0;
                            
                        while(key35 == 0){
                                
                            if(row2 + 3 <= 10){
                            
                                int t35= row2+3;
                                int stop35=0;
                                
                                for(int i = row2; i<=t35; i++){
                                    if(boardWships_player2[i,column2]== "S"){
                                        stop35++;
                                    }
                                } 
                                if(stop35>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + "Destroyer (3x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= row2; i<t35; i++) {
                                        boardWships_player2[i,column2]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key35++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Destroyer (3x1) ship: ");
                                Input_ships2();
                            }
                        }
                    } 
                }
                if (temp5==9){ 
                    
                    Console.WriteLine(P2.name + ": Frigates (2x1) ship: ");
                    Input_ships2();
                    if(direction2 == "R"){
                        int key36 = 0;
                            
                        while(key36 == 0){
                                
                            if(column2 + 2 <= 10){
                                
                                int t36= column2 + 2;
                                int stop36=0;
                                
                                for(int i= column2; i<t36; i++){
                                    if(boardWships_player2[row2,i] == "S"){
                                        stop36++;
                                    }
                                } 
                                
                                if(stop36 >0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name +": Frigates (2x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= column2; i<t36; i++) {
                                        boardWships_player2[row2,i]="S";
                                        
                                    }
                                    Display_BoardWships2(boardWships_player2); 
                                    key36++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine("Frigates (2x1) ship: ");
                                    Input_ships2();
                            }
                        }
                    }            
                    else if(direction2 == "L"){
                        int key37 = 0;
                            
                        while(key37 == 0){
                                
                            if(column2 - 2 >0){
                            
                                int t37= column2-2;
                                int stop37=0;
                                
                                for(int i = column2; i>=t37; i--){
                                    if(boardWships_player2[row2,i]== "S"){
                                        stop37++;
                                    }
                                } 
                                if(stop37>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + " :Frigates (2x1) ship:  ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i = column2; i>t37; i--) {
                                        boardWships_player2[row2,i]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key37++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Frigates (2x1) ship: ");
                                Input_ships2();
                            }
                        }
                    }
                    else if(direction2 == "U"){
                        int key38 = 0;
                            
                        while(key38 == 0){
                                
                            if(row2 - 2 >0){
                            
                                int t38= row2-5;
                                int stop38=0;
                                
                                for(int i = row2; i>=t38; i--){
                                    if(boardWships_player2[i,column2]== "S"){
                                        stop38++;
                                    }
                                } 
                                if(stop38>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + "Frigates (2x1) ship: ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= row2; i>t38; i--) {
                                        boardWships_player2[i,column2]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key38++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Frigates (2x1) ship: ");
                                Input_ships2();
                            }
                        }
                    }
                   else if(direction2 == "D"){
                        int key39 = 0;
                            
                        while(key39 == 0){
                                
                            if(row2 + 2 <= 10){
                            
                                int t39= row2+2;
                                int stop39=0;
                                
                                for(int i = row2; i<=t39; i++){
                                    if(boardWships_player2[i,column2]== "S"){
                                        stop39++;
                                    }
                                } 
                                if(stop39>0){
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Please choose another unit to place your ship!");
                                    Console.WriteLine(P2.name + ": Frigates (2x1) ship: :  ");
                                    Input_ships2();
                                }
                                else{
                                    for(int i= row2; i<t39; i++) {
                                        boardWships_player2[i,column2]="S";
                                    }
                                    Display_BoardWships2(boardWships_player2);
                                    key39++;
                                    temp5++;
                                    
                                }
                            }
                            else{
                                Console.WriteLine(" ");
                                Console.WriteLine("Please choose another unit to place your ship!");
                                Console.WriteLine("Frigates (2x1) ship: ");
                                Input_ships2();
                            }
                        }
                    } 
                }
                
                transition_temp=false;
                
            }
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("************************");
            Console.WriteLine("  !!!!! WAR TIME !!!!!  ");
            Console.WriteLine("************************");
            ///////////////////////////////////////////
            
            while (transition_temp == false) { 
                
                if (turn_player == 1)
                {
                    
                    Console.WriteLine(" ");
                    
                    In_Puts_P1();
                    int temp1 = 0;
                    
                    while(temp1 == 0){
                        
                        if (board_player1[row1, column1] == "O"){
                        
                            Console.WriteLine(" ");
                            Console.WriteLine("Please choose another unit!");
                            In_Puts_P1();
                        }
                        else {
                            temp1+=1;
                        }
                    }

                    if(boardWships_player2[row1,column1] == "S"){
                        Console.WriteLine("P1: shot successfully!!!");
                        board_player1[row1,column1] = "X";
                        P1.score+=1;
                        Display_Board(board_player1,turn_player);
                        if(P1.score == 17){
                            Console.Clear();
                            Console.WriteLine("******************");                            
                            Console.WriteLine("P1 WON THE GAME!!!");
                            Environment.Exit(0);
                        }                        
                    }
                    else{
                        board_player1[row1, column1] = "O";
                        Display_Board(board_player1, turn_player);
                    }

                    turn_player+=1;
                    temp1-=1;

                }

                else if (turn_player == 2)
                {
                    
                    Console.WriteLine(" ");
                    In_Puts_P2();
                    int temp2 = 0;
                    
                    while(temp2 == 0){
                        
                        if (board_player2[row2, column2] == "O"){
                        
                        Console.WriteLine(" ");
                        Console.WriteLine("Please choose another unit!");
                        In_Puts_P2();
                        }
                        else {
                            temp2+=1;
                        }
                    }
                    if(boardWships_player1[row2,column2] == "S"){
                        Console.WriteLine("P2: shot successfully!!!");
                        board_player2[row2,column2] = "X";
                        P2.score+=1;
                        Display_Board(board_player2,turn_player);
                        if(P2.score == 17){
                            Console.Clear();
                            Console.WriteLine("******************");
                            Console.WriteLine("P2 WON THE GAME");
                            Environment.Exit(0);
                        }
                    }
                    else{
                        board_player2[row2, column2] = "O";
                        Display_Board(board_player2, turn_player);
                    }
                turn_player-=1;
                temp2-=1;
                    
                }

            }
        }

/*
We used a function named Display_Board to show 
the board after the selection of ship locations. 
We used ToString command for convert the string input to integer.
*/

        static void Display_Board(string[,] board, int x)
        {

            Console.WriteLine(" ");
            string y = x.ToString();

            Console.WriteLine("P" + y);

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {


                    Console.Write("[" + board[i, j] + "]");
                }

                Console.Write("\n");
            }

        }
        static void Display_BoardWships1(string[,] board)
        {

            Console.WriteLine(" ");
            

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {


                    Console.Write("[" + boardWships_player1[i, j] + "]");
                }

                Console.Write("\n");
            }

        } 
        static void Display_BoardWships2(string[,] board)
        {

            Console.WriteLine(" ");
            

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {


                    Console.Write("[" + boardWships_player2[i, j] + "]");
                }

                Console.Write("\n");
            }

        } 

/*   
We use that function named Define_Board to define and show both players’
        board. We have 10x10 board. For this we used 2D for loop. 
*/

        static void Define_Board()
        {
            
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < 10; j++)
                {

                    board_player1[i, j] = "?";
                    Console.Write("[" + board_player1[i, j] + "]");
                }
                Console.Write("  |  ");
                
                for (int j = 0; j < 10; j++)
                {

                    board_player2[i, j] = "?";
                    Console.Write("[" + board_player2[i, j] + "]");
                }
                Console.Write("\n");
            }
        }


/*
We created two player-specific functions named In_Puts to
take the string locations inputs from the user and convert them to integers.

*/
        static void In_Puts_P1()
        {

            int condition =0;
            while(condition == 0 ){
                    Console.WriteLine(P1.name + ": Please enter the value of column(1 to 10);  ");
                    
                    inputx = Console.ReadLine();
                    if(inputx=="1"|| inputx=="2"||inputx=="3"||inputx=="4"||inputx=="5"||inputx=="6"||inputx=="7"||inputx=="8"||inputx=="9"||inputx=="10" ){
                        column1 = Convert.ToInt32(inputx)-1;
                        condition++;
                    }
                    else{
                        Console.WriteLine("!!!INVALID INPUT!!!");
                        Console.WriteLine("Please, enter another value of column:");
                    }
                
            }
            while(condition == 1 ){
                    Console.WriteLine(P1.name + ": Please enter the value of row(1 to 10);  ");
                    inputy = Console.ReadLine();
                    if(inputy=="1"|| inputy=="2"||inputy=="3"||inputy=="4"||inputy=="5"||inputy=="6"||inputy=="7"||inputy=="8"||inputy=="9"||inputy=="10" ){
                        row1 = Convert.ToInt32(inputy)-1;
                        condition++;
                    }
                    else{
                        Console.WriteLine("!!!INVALID INPUT!!!");
                        Console.WriteLine("Please, enter another value of row:");
                    }
                
            }
        }    

        static void In_Puts_P2()
        {

            int condition1 =0;
            while(condition1 == 0 ){
                    Console.WriteLine(P2.name + ": Please enter the value of column(1 to 10);  ");
                    inputx1 = Console.ReadLine();
                    if(inputx1=="1"|| inputx1=="2"||inputx1=="3"||inputx1=="4"||inputx1=="5"||inputx1=="6"||inputx1=="7"||inputx1=="8"||inputx1=="9"||inputx1=="10" ){
                        column2 = Convert.ToInt32(inputx1)-1;
                        condition1++;
                    }
                    else{
                        Console.WriteLine("!!!INVALID INPUT!!!");
                        Console.WriteLine("Please, enter another value of column:");
                    }
                
            }
            while(condition1 == 1 ){
                    Console.WriteLine(P2.name + ": Please enter the value of row(1 to 10);  ");
                    inputy1 = Console.ReadLine();
                    if(inputy1=="1"|| inputy1=="2"||inputy1=="3"||inputy1=="4"||inputy1=="5"||inputy1=="6"||inputy1=="7"||inputy1=="8"||inputy1=="9"||inputy1=="10" ){
                        row2 = Convert.ToInt32(inputy1)-1;
                        condition1++;
                    }
                    else{
                        Console.WriteLine("!!!INVALID INPUT!!!");
                        Console.WriteLine("Please, enter another value of row:");
                    }
                
            }
            
        }
        
        static void Starting_screen()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("WELCOME TO BATTLESHIP GAME");
            Console.WriteLine("    LET THE WAR BEGIN!");
            Console.WriteLine("***************************");
            for (int i = 0; i < 2; i++) 
            {
                Console.WriteLine(" ");
            }

            
        }
        
        
        static void Input_ships1()
        {

            int condition2 =0;

            while(condition2 == 0 ){
                    Console.WriteLine(P1.name + ": Please enter the value of row(1 to 10);  ");
                    inputy = Console.ReadLine();
                    if(inputy=="1"|| inputy=="2"||inputy=="3"||inputy=="4"||inputy=="5"||inputy=="6"||inputy=="7"||inputy=="8"||inputy=="9"||inputy=="10" ){
                        row1 = Convert.ToInt32(inputy)-1;
                        condition2++;
                    }
                    else{
                        Console.WriteLine("!!!INVALID INPUT!!!");
                        Console.WriteLine("Please, enter another value of row:");
                    }
                    
            }
            while(condition2 == 1 ){
                    Console.WriteLine(P1.name + ": Please enter the value of column(1 to 10);  ");
                    
                    inputx = Console.ReadLine();
                    if(inputx=="1"|| inputx=="2"||inputx=="3"||inputx=="4"||inputx=="5"||inputx=="6"||inputx=="7"||inputx=="8"||inputx=="9"||inputx=="10" ){
                        column1 = Convert.ToInt32(inputx)-1;
                        condition2++;
                    }
                    else{
                        Console.WriteLine("!!!INVALID INPUT!!!");
                        Console.WriteLine("Please, enter another value of column:");
                    }
                
            }
            while(condition2 ==2){
                Console.WriteLine("Enter the direction of your ship(R:right, L:left, U:up, D:down): ");
                direction1=Console.ReadLine();
                if (direction1=="R"|| direction1=="L"||direction1=="U"||direction1=="D"){
                    condition2++;    
                }
                else{
                    Console.WriteLine("!!!INVALID INPUT!!!");
                    Console.WriteLine("Please, enter another direction:");
                
            
                }    
                
            }
        } 
        
        
        static void Input_ships2()
        {

            int condition3 =0;
            while(condition3 == 0 ){
                    Console.WriteLine(P2.name + ": Please enter the value of row(1 to 10);  ");
                    inputy = Console.ReadLine();
                    if(inputy=="1"|| inputy=="2"||inputy=="3"||inputy=="4"||inputy=="5"||inputy=="6"||inputy=="7"||inputy=="8"||inputy=="9"||inputy=="10" ){
                        row2 = Convert.ToInt32(inputy)-1;
                        condition3++;
                    }
                    else{
                        Console.WriteLine("!!!INVALID INPUT!!!");
                        Console.WriteLine("Please, enter another value of row:");
                    }
            }
            while(condition3 == 1 ){
                    Console.WriteLine(P2.name + ": Please enter the value of column(1 to 10);  ");
                    
                    inputx = Console.ReadLine();
                    if(inputx=="1"|| inputx=="2"||inputx=="3"||inputx=="4"||inputx=="5"||inputx=="6"||inputx=="7"||inputx=="8"||inputx=="9"||inputx=="10" ){
                        column2 = Convert.ToInt32(inputx)-1;
                        condition3++;
                    }
                    else{
                        Console.WriteLine("!!!INVALID INPUT!!!");
                        Console.WriteLine("Please, enter another value of column:");
                    }
                
            }
            
            while(condition3 ==2){
                Console.WriteLine("Enter the direction of your ship(R:right, L:left, U:up, D:down): ");
                direction2=Console.ReadLine();
                if (direction1=="R"|| direction1=="L"||direction1=="U"||direction1=="D"){
                    condition3++;    
                }
                else{
                    Console.WriteLine("!!!INVALID INPUT!!!");
                    Console.WriteLine("Please, enter another direction:");
                
                }
            } 
        }
    }
}


