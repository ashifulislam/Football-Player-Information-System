using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballPlayerInformatio
{
    class Player
    {
       private String name;
       private  String team_Name;
       private   int shirt_Number;
       private  String nick_Name;
       private  String gender;
       private  String current_Team;
       private  int height;
       private int age;
       private int weight;
       int year = 2019;


       /* public Player(String name, String team_name, int shirt_Number, String nick_name, String gender, String current_Team, int height, int weight)
        {
            this.name = name;
            this.team_Name = team_Name;
            this.shirt_Number = shirt_Number;
            this.nick_Name = nick_Name;
            this.gender = gender;
            this.current_Team = current_Team;
            this.height = height;
           
            this.weight = weight;
        }
        */
        public int ageCalculate(int birth_year)
        {
            age = year - birth_year;
            return age;

        }
       

        


    }
}
