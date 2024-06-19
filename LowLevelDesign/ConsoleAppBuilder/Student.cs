namespace ConsoleAppBuilder
{
    public class Student
    {
        private int id;
        private string name;
        private int gradYear;
        private int age;

        public static Builder getBuilder()
        {
            return new Builder();
        }
        private Student(Builder builder)
        {
            this.id = builder.getId();
            this.name = builder.getName();
            this.age = builder.getAge();
            this.gradYear = builder.getGradYear();
        }

        //Builder
        public class Builder
        {
            private int id;
            private string name;
            private int age;
            private int gradYear;
            public int getId()
            {
                return this.id;
            }
            public string getName()
            {
                return this.name;
            }
            public int getAge()
            {
                return this.age;
            }
            public int getGradYear()
            {
                return this.gradYear;
            }
            public Builder setId(int id)
            {
                this.id = id;
                return this;
            }
            public Builder setName(string name)
            {
                this.name = name;
                return this;
            }
            public Builder setGradYear(int gradYear)
            {
                if (gradYear < 2015)
                {
                    throw new System.InvalidArgumentException("gradYear can't be < 2015");
                }
                this.gradYear = gradYear;
                return this;
            }
            public Builder setAge(int age)
            {
                if (age < 20)
                {
                    throw new System.InvalidArgumentException("Age Should be > 19");
                }
                this.age = age;
                return this;
            }
            public Student build()
            {
                return new Student(this);
            }
        }
    }
}
