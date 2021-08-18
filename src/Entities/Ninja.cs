namespace Aula_DI_RPG.src.Entities
{
    public class Ninja :Hero
    {
         public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public  string Attack(int Bonus){
            if (Bonus>6){
                return this.Name + " Usou Ataque Furtivo: " + Bonus;
            }else{
                return this.Name + " Atacou com shuriken" + Bonus;
            }
        }

        
    }
}