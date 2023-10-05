using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Console;

namespace Game_Haunted_house
{
    internal class Program
    {

        string Levelstatement;
        string answer;
        int options1;
        int options2;
        int option3;
        int option4;
     
        static void Main(string[] args)
        { 
           

            WriteLine("please enter you name ");
            string user_name = ReadLine();
            WriteLine("hello " + user_name );
            
            WriteLine("  would you like to play a game ?  Enter Y/N");
            string answer = ReadLine(); 
          
              while (answer .ToLower()!="N" )
            {

            if (answer.ToLower() != "N")
            {
                WriteLine("the objective of this game is to make it through  four  rooms in a haunted house ,\nchoose between options given to try and progress ,wrong deceions will result in DEATH");
                WriteLine("ready to start ?Y/N");
                string response = ReadLine();
                //BEGGINING OF THE GAME
             
                if (response.ToLower() != "N")
                {//SCENARIO 1
                    Write(" You enter a dimly lit room and encounter a translucent figure hovering in front of you. It extends a skeletal hand towards you, beckoning you closer.\n choice 1: Approach the ghostly figure.\nChoice 2: Back away and leave the room.");
                    WriteLine("\n what is your choice ? 1/2");
                    int options1 = int.Parse(ReadLine());
                    if (options1 == 1)
                    {
                        WriteLine("the ghostly figure approaches you and from its  tattered pocket gives you a flower ,and point to the next room  before fading away  ");
                      
                        //SCENARIO2
                        Write("\nIn a dusty, cobweb-filled room, you find an ornate mirror with an eerie glow. Your reflection beckons you with a chilling smile.\r\n\r\nChoice 1: Reach out and touch the mirror.\r\nChoice 2: Quickly exit the room and slam the door shut ");
                        WriteLine("what is your choice ? 1/2");
                        int options2 = int.Parse(ReadLine());
                        if (options2 == 2)
                        {
                            Write("\n you choose to quickly run out and slam the door shut ,as you do you can hear a blood curdling screaching from the other side ,you live to see another day ,you spot a another door infront of you  ");
                            //scenario3

                            Write("You enter a nursery filled with antique porcelain dolls. They start to whisper in eerie voices, inviting you to join their tea party.\r\n\r\nChoice 1: Sit down and join the tea party.\r\nChoice 2: Rush out of the nursery, ignoring the dolls.");
                            WriteLine("\n what is your choice ?1/2");
                            int option3 = int.Parse(ReadLine());
                            if (option3 == 2)
                            {
                                WriteLine(" the dolls scream after you ,as you make a beline for the stairs ,you surivive yet again ");

                                //scenario4
                                Write("You descend into a dark, damp basement filled with eerie shadows. You notice a flickering candle at the far end, casting unsettling shadows on the walls.\r\n\r\nChoice 1: Walk toward the candle to investigate.\r\nChoice 2: Turn and run back up the stairs.");
                                WriteLine("which option do you choose?1/2");
                                int option4 = int.Parse(ReadLine());
                                if (option4 == 1)
                                {
                                    Write("you approach the dancing shadows slowly ,as you drew closer you notice that the shadows wherent really shadows to begin with ,but a slimly withering pile of slime ,you stumble back tripping on something ,you look down to see a decomposing body the lower half already consumed by the monster ,the stench of rotting flesh assualted your nose ,you get up to make a beline for the stairs when you spot the basement window you rush towards it ,scrambling towrads it ,you make it out in time to see the basement being flooded by the black slime \n congrats you survived ")
                                ;
                                }
                                else if (option4 == 2) { Write(" as you make a move to leave ,you acceidentally knock a bottle of a shelf, the noise you make awakens the beast  , you turn arround in horror to witness the shadows peel themselves off the wall ,it surges forward grabbing you by wrapping you in a slimy mass ,as your slowly consumed you catch a glimpse of the distant open basement window ,you die knowing that your escape was so close  \n Dead"); }


                               
                            }
                            else if (option3 == 1)
                                { WriteLine("you approach the dolls slowly ,taking a seat at their table ,you accept the tea they offer reluculantly  ,it taste weird ,the dolls giggling softly in the background ,you start to feel dizzy and smallblack dots appear in your vision as you fight for concicness as you realize that it was drugged the last thing you hear as you drift out of conciousness is the dolls singing ring a ring a rossies ,they would be having you for tea later \n DEAD"); }
                                else { WriteLine("incorrect option "); }
                            
                        
                    }
                        else if (options2 != 2)
                            {
                                WriteLine("despite better judgement you choose to approach your refelction,its mouth splits in a toothy grin revealing ist rows of sharp preditory teeth ,before you can turn around and run,the reflection springs forward grabing you ,it drags you into the mirrior ,you where never seen again \n DEAD ");

                            }
                            else { WriteLine("INCORRECT OPTION" ); }
                           
                    }
                         else if (options1 != 1)
                        {
                            WriteLine("  you back away from the ghost only to trip and fall ,offended the by your retreat the ghost lunges forward and end you heads long term relationship with your shoulders YOU DIE");
                        }
                        else { WriteLine("incorrect option "); } }
                }
                else
                {
                    WriteLine(" have a lovely day further ");
                }











                ReadLine();
            }
        }
    }
}
