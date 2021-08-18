namespace Aula_DI_RPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Hero()
        {   
        }
        public string Name;
        public int Level;
        public string HeroType;
        public int Hp = 100;
        public int Mp = 50;

        public override string ToString(){
            return this.Name +" "+ this.Level +" " + this.HeroType + " Hp: " + Hp + "Mp: " + Mp;
        }

        public virtual string Attack(){
            return this.Name + " Atacou";
        }
        public virtual string LevelUp(){
            this.Level +=1;
            this.Hp += 10;
            this.Mp += 10;
            return this.Name + " agora esta no level: " + Level + " Hp: " + Hp + "Mp: " + Mp;
        }


    }
}