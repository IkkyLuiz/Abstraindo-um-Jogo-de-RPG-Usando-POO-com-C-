namespace dotnet.src.Models
{
    public class Wizard : Hero
    {
       public  Wizard(string Name, int Level,string TipoHeroi) : base("Name",23,"White Wizard")
       {
         this.Name = Name;
            this.Level = Level;
            this.TipoHeroi = TipoHeroi;
       } 
      

        public override string Attack(){
            return this.Name +" " + "Lançou Magia";
        
    }
        public string Attack(int Bonus){

            if (Bonus> 6){
                return this.Name + " "+ "Lançou Magia super efetiva com bônus de ataque de" + " " + Bonus;
            }else{
                return this.Name + "Lançou magia com força baixa com bônus de" + " " + Bonus;
            }
    }
    }
}