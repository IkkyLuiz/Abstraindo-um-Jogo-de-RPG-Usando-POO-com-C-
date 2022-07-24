namespace dotnet.src.Models
{
    public abstract class Hero
    {
        public Hero(string Name, int Level,string TipoHeroi)
        {
            this.Name = Name;
            this.Level = Level;
            this.TipoHeroi = TipoHeroi;
        }
        
        public string Name;
        public int Level;
        public string TipoHeroi;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.TipoHeroi;

        }

       
        public virtual string Attack(){
            return this.Name +" " + "Atacou com a espada";
        }

    }
}