namespace dotnet.src.Models
{
    public class Knight: Hero
    {
         public  Knight(string Name, int Level,string TipoHeroi) : base("Name",23,"White Wizard")
       {
         this.Name = Name;
            this.Level = Level;
            this.TipoHeroi = TipoHeroi;
       } 
       public override string ToString(){
            return this.Name + " " + this.Level + " " + this.TipoHeroi;

        }
    }
}