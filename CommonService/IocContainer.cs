using Ninject;
using Ninject.Modules;
using System.Collections.Generic;

namespace CommonService
{
    public class IocContainer
    {
        private static IocContainer _instance;
        private static IKernel _kernel;

        /// <summary>
        /// Instance public property
        /// </summary>
        public static IocContainer Instance
        {
            get
            {
                return _instance ?? (_instance = new IocContainer());
            }
        }

        /// <summary>
        /// Initialize kernel
        /// </summary>
        /// <param name="kernel"></param>
        public void Initialize(IKernel kernel)
        {
            _kernel = kernel;
        }

        /// <summary>
        /// Return generic type
        /// </summary>
        /// <typeparam name="T">Class Type</typeparam>
        /// <returns></returns>
        public T Get<T>()
        {
            return _kernel.Get<T>();
        }

        /// <summary>
        /// Return gerneric by name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public T Get<T>(string name)
        {
            return _kernel.Get<T>(name);
        }

        /// <summary>
        /// Load Ninject module
        /// </summary>
        /// <param name="list"></param>
        public void Load(List<NinjectModule> list)
        {
            _kernel.Load(list);
        }

    }
}
