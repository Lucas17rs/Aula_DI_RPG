namespace Aula_DI_RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp += this.Level/2;
            this.Mp += this.Level*2;
        }
        public override string Attack(){
            return this.Name + " Lançou Magia";
        }
        public string Attack(int Bonus){
            if (Bonus>6){
                return this.Name + " Lançou Magia Super Efetiva com bonus de:" + Bonus;
            }
            if (Bonus>=1){
                return this.Name + " A magia falhou.";
            }
            else{
                return this.Name + " Lançou Magia com bonus de:" + Bonus;
            }
        }
         

    }
}