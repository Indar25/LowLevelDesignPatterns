namespace ConsoleAppPrototypeAndRegistry
{
    public class Trainee : Employee
    {
        private string College;
        public Trainee()
        {

        }
        public void setCollege(string college)
        {
            this.College = college;
        }
        public Trainee(Trainee trainee) : base(trainee)
        {
            this.College = trainee.College;
        }

        public override Employee Clone()
        {
            return new Trainee(this);
        }
    }
}
