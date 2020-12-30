using Ninject;

namespace BookSaller.Business.Cross_Cutting_Concerns.DependecyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            return new StandardKernel(new BusinessModule()).Get<T>();
        }
    }
}
