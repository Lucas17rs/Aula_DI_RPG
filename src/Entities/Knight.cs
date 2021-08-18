namespace Aula_DI_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp += Level*2;
            this.Mp += Level/2;
        }
        
        public string Attack(int Bonus){
            if (Bonus>6){
                return this.Name + " Usou Avan Strash: " + Bonus;
            }else{
                return this.Name + " Atacou com a espada" + Bonus;
            }
        }
    }
}