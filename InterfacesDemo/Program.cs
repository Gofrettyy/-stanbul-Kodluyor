namespace InterfacesDemo

{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker (),
                new Robots(),
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager(),

            };

        }
    }
    interface IWorker
    {
        void Work();
      
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker: IWorker, IEat,ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robots : IWorker
    {
           public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
 // Solid Araştırılacak biz burada Interface Segregation

